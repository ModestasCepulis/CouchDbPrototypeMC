using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCouch;
using MyCouch.Net;
using MyCouch.Requests;
using MyCouch.Responses;
using System.Collections;
using System.Diagnostics;

namespace couchDbPrototypee
{

    public partial class frmMain : Form
    {
        MyCouchClient db = new MyCouchClient(new DbConnectionInfo("http://admin:admin@127.0.0.1:5984/", "players/"));
        ArrayList documentIds = new ArrayList();
        ArrayList revIds = new ArrayList();
        string[] finalPlayerNames;


        public frmMain()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listAllRegions.Items.Clear();
            getAllDocumentsFromDb();
            getAllRegionsFromDb();
        }


        public async Task getAllDocumentsFromDb()
        {
            DocumentResponse response = await db.Documents.GetAsync(new GetDocumentRequest("_all_docs"));
            String str = response.Content.ToString();

            // txtUpdatePlayerName.Text = str;

            string[] words = str.Split('"');

            for (int i = 0; i < words.Length; i++)
            {
                if (words.GetValue(i).ToString().StartsWith("id"))
                {
                    documentIds.Add(words.GetValue(i + 2).ToString());
                }
            }

            for (int j = 0; j < documentIds.Count; j++)
            {
                if(!documentIds[j].ToString().StartsWith('_') && !cboPlayerName.Items.Contains(documentIds[j].ToString()))
                {
                    cboPlayerName.Items.Add(documentIds[j].ToString());
                }

            }

        }

        public async Task getAllRegionsFromDb()
        {
            var query = new QueryViewRequest("allDocs", "byPlayerRegion").Configure(q => q.Group(true));
            ViewQueryResponse result = await db.Views.QueryAsync(query);

            listAllRegions.Items.Add("All player regions\n");
            listAllRegions.Items.Add("----------------------------------------------");
            listAllRegions.Items.Add("\nPlayer Region" + "\tPlayer Count");
            listAllRegions.Items.Add("----------------------------------------------");

            for (int i=0; i < result.RowCount; i++)
            {
                listAllRegions.Items.Add(result.Rows[i].Key + " \t\t" + result.Rows[i].Value);
            }      
        }

        public async Task getPlayerNamesBasedOnDocumentId(string documentID)
        {
            //this finds the correspondand id to regards of name and retrieves it and adds it into the list (combo box)
            for (int i = 0; i < documentIds.Count; i++)
            {
                DocumentResponse getPlayerNames = await db.Documents.GetAsync(new GetDocumentRequest(documentID));
                String allOfTheInformation = getPlayerNames.Content.ToString();
                //  txtUpdatePlayerName.Text = allOfTheInformation;
                finalPlayerNames = allOfTheInformation.Split('"');

                for (int j = 0; j < finalPlayerNames.Length; j++)
                {
                    if (finalPlayerNames.GetValue(j).ToString().StartsWith("playerRegion"))
                    {
                        txtShowPlayerRegion.Text = finalPlayerNames.GetValue(j + 2).ToString();
                    }
                    if (finalPlayerNames.GetValue(j).ToString().StartsWith("player_name"))
                    {
                        txtPlayerName.Text = finalPlayerNames.GetValue(j + 2).ToString();
                        txtDeletePlayerName.Text = finalPlayerNames.GetValue(j + 2).ToString();
                    }
                    if (finalPlayerNames.GetValue(j).ToString().StartsWith("player_class"))
                    {
                        txtPlayerClass.Text = finalPlayerNames.GetValue(j + 2).ToString();
                    }
                    if (finalPlayerNames.GetValue(j).ToString().StartsWith("player_level"))
                    {
                        txtPlayerLevel.Text = finalPlayerNames.GetValue(j + 2).ToString();
                    }
                    if (finalPlayerNames.GetValue(j).ToString().StartsWith("player_current_health"))
                    {
                        txtPlayerHealth.Text = finalPlayerNames.GetValue(j + 2).ToString();
                    }
                    if (finalPlayerNames.GetValue(j).ToString().StartsWith("_rev"))
                    {
                        txtRevNumber.Text = finalPlayerNames.GetValue(j + 2).ToString();
                    }
                }

            }
        }

        public async Task UpdatePlayerInformation(string documentID, string revID)
        {
            // DocumentHeaderResponse updatePlayerNames =
            //   DocumentHeaderResponse banana = await db.Documents.PostAsync(new PostDocumentRequest("73329c4f70376ee4cf695b4eaa0165c3", "{\"player_name\":\"Daniel\"}"));
            DocumentHeaderResponse response = await db.Documents.PutAsync(new PutDocumentRequest(documentID, revID, "{\"playerRegion\":\""+cboUpdateRegion.Text+"\",\n\"playerStats\": [\n{\n\"player_name\": \"" + txtUpdatePlayerName.Text + "\"," +
                                                                                                                                    "\n\"player_class\": \"" + txtUpdatePlayerClass.Text + "\"," +
                                                                                                                                    "\n\"player_level\": \"" + txtUpdatePlayerLevel.Text.ToString() + "\"," +
                                                                                                                                    "\n\"player_current_health\":\"" + txtUpdatePlayerHealth.Text.ToString() + "\"}\n]\n}"));
            Debug.WriteLine(response.ToStringDebugVersion());
        }

        public async Task AddNewPlayer()
        {
            DocumentHeaderResponse response = await db.Documents.PostAsync(new PostDocumentRequest("{\"playerRegion\":\"" + cboAddRegion.Text + "\",\n\"playerStats\": [\n{\n\"player_name\": \"" + txtAddPlayerName.Text + "\"," +
                                                                                                                                    "\n\"player_class\": \"" + txtAddPlayerClass.Text + "\"," +
                                                                                                                                    "\n\"player_level\": \"" + txtAddPlayerLevel.Text.ToString() + "\"," +
                                                                                                                                    "\n\"player_current_health\":\"" + txtAddPlayerHealth.Text.ToString() + "\"}\n]\n}"));

            Debug.WriteLine(response.ToStringDebugVersion());
        }

        public async Task DeleteExistingPlayer(string documentId, string revID)
        {
            DocumentHeaderResponse response = await db.Documents.DeleteAsync(new DeleteDocumentRequest(documentId, revID));
            Debug.WriteLine(response.ToStringDebugVersion());
        }

        private void domainUpDownPlayer_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpInformation.Enabled = true;
            grpWhatToDoNext.Enabled = true;
            string documentID = cboPlayerName.Text;
            string revID = txtRevNumber.Text;
            getPlayerNamesBasedOnDocumentId(documentID);


        }

        private void btnUpdatePlayer_Click(object sender, EventArgs e)
        {


            string documentIdForUpdate = cboPlayerName.Text;
            string revIdForUpdate = txtRevNumber.Text;
            UpdatePlayerInformation(documentIdForUpdate, revIdForUpdate);

            cboUpdateRegion.Text = "";
            txtUpdatePlayerClass.Clear();
            txtUpdatePlayerHealth.Clear();
            txtUpdatePlayerLevel.Clear();
            txtUpdatePlayerName.Clear();

            grpInformation.Enabled = false;
            grpWhatToDoNext.Enabled = false;

            MessageBox.Show("Player updated succesfully!");
            grpUpdatePlayer.Enabled = false;
            cboPlayerName.Text = "";
            cboPlayerName.Items.Clear();
            listAllRegions.Items.Clear();
            getAllRegionsFromDb();
            getAllDocumentsFromDb();

            //Debug.WriteLine(async.IsCompleted);
        }

        private void btnToUpdatePlayer_Click(object sender, EventArgs e)
        {
            grpUpdatePlayer.Enabled = true;
        }

        private void btnToAddNewPLayer_Click(object sender, EventArgs e)
        {
            grpAddPlayer.Enabled = true;
        }

        private void btnToDeletePLayer_Click(object sender, EventArgs e)
        {
            grpDeleteBox.Enabled = true;
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            AddNewPlayer();
            txtAddPlayerClass.Clear();
            txtAddPlayerHealth.Clear();
            txtAddPlayerLevel.Clear();
            txtAddPlayerName.Clear();
            cboAddRegion.Text = "";

            grpInformation.Enabled = false;
            grpWhatToDoNext.Enabled = false;
            grpUpdatePlayer.Enabled = false;
            grpAddPlayer.Enabled = false;

            cboPlayerName.Text = "";
            cboPlayerName.Items.Clear();
            listAllRegions.Items.Clear();
            getAllRegionsFromDb();
            getAllDocumentsFromDb();
            MessageBox.Show("Player added succesfully!");


        }

        private void grpWhatToDoNext_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            string documentIdForDelete = cboPlayerName.Text;
            string revIdForDelete = txtRevNumber.Text;
            grpInformation.Enabled = false;
            grpWhatToDoNext.Enabled = false;
            grpUpdatePlayer.Enabled = false;
            grpAddPlayer.Enabled = false;
            grpDeleteBox.Enabled = false;


            cboPlayerName.Text = "";
            cboPlayerName.Items.Remove(documentIdForDelete);
            listAllRegions.Items.Clear();
            txtDeletePlayerName.Clear();
            DeleteExistingPlayer(documentIdForDelete, revIdForDelete);
            getAllRegionsFromDb();
            MessageBox.Show("Player deleted succesfully!");
        }

        private void listAllRegions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpAddPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
