namespace couchDbPrototypee
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.playerName = new System.Windows.Forms.Label();
            this.txtPlayerClass = new System.Windows.Forms.TextBox();
            this.playerClasslbl = new System.Windows.Forms.Label();
            this.txtPlayerLevel = new System.Windows.Forms.TextBox();
            this.plrlevellbl = new System.Windows.Forms.Label();
            this.txtPlayerHealth = new System.Windows.Forms.TextBox();
            this.lblCurrentHealth = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerInformation = new System.Windows.Forms.Label();
            this.cboPlayerName = new System.Windows.Forms.ComboBox();
            this.lblUpdatePlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdatePlayerHealth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdatePlayerLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdatePlayerClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdatePlayerName = new System.Windows.Forms.TextBox();
            this.txtDeletePlayerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.grpSelectPlayer = new System.Windows.Forms.GroupBox();
            this.txtRevNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.txtShowPlayerRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.grpWhatToDoNext = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnToDeletePLayer = new System.Windows.Forms.Button();
            this.btnToUpdatePlayer = new System.Windows.Forms.Button();
            this.btnToAddNewPLayer = new System.Windows.Forms.Button();
            this.grpUpdatePlayer = new System.Windows.Forms.GroupBox();
            this.cboUpdateRegion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddPlayerHealth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddPlayerLevel = new System.Windows.Forms.TextBox();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddPlayerClass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddPlayerName = new System.Windows.Forms.TextBox();
            this.grpAddPlayer = new System.Windows.Forms.GroupBox();
            this.cboAddRegion = new System.Windows.Forms.ComboBox();
            this.playerRegionaa = new System.Windows.Forms.Label();
            this.grpDeleteBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrpShowAllRegions = new System.Windows.Forms.GroupBox();
            this.listAllRegions = new System.Windows.Forms.ListBox();
            this.grpSelectPlayer.SuspendLayout();
            this.grpInformation.SuspendLayout();
            this.grpWhatToDoNext.SuspendLayout();
            this.grpUpdatePlayer.SuspendLayout();
            this.grpAddPlayer.SuspendLayout();
            this.grpDeleteBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GrpShowAllRegions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(107, 92);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(148, 23);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(26, 95);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(77, 15);
            this.playerName.TabIndex = 1;
            this.playerName.Text = "player Name:";
            // 
            // txtPlayerClass
            // 
            this.txtPlayerClass.Location = new System.Drawing.Point(107, 121);
            this.txtPlayerClass.Name = "txtPlayerClass";
            this.txtPlayerClass.Size = new System.Drawing.Size(148, 23);
            this.txtPlayerClass.TabIndex = 0;
            this.txtPlayerClass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerClasslbl
            // 
            this.playerClasslbl.AutoSize = true;
            this.playerClasslbl.Location = new System.Drawing.Point(26, 124);
            this.playerClasslbl.Name = "playerClasslbl";
            this.playerClasslbl.Size = new System.Drawing.Size(72, 15);
            this.playerClasslbl.TabIndex = 1;
            this.playerClasslbl.Text = "Player Class:";
            // 
            // txtPlayerLevel
            // 
            this.txtPlayerLevel.Location = new System.Drawing.Point(107, 150);
            this.txtPlayerLevel.Name = "txtPlayerLevel";
            this.txtPlayerLevel.Size = new System.Drawing.Size(148, 23);
            this.txtPlayerLevel.TabIndex = 0;
            this.txtPlayerLevel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // plrlevellbl
            // 
            this.plrlevellbl.AutoSize = true;
            this.plrlevellbl.Location = new System.Drawing.Point(26, 153);
            this.plrlevellbl.Name = "plrlevellbl";
            this.plrlevellbl.Size = new System.Drawing.Size(72, 15);
            this.plrlevellbl.TabIndex = 1;
            this.plrlevellbl.Text = "Player Level:";
            // 
            // txtPlayerHealth
            // 
            this.txtPlayerHealth.Location = new System.Drawing.Point(107, 179);
            this.txtPlayerHealth.Name = "txtPlayerHealth";
            this.txtPlayerHealth.Size = new System.Drawing.Size(148, 23);
            this.txtPlayerHealth.TabIndex = 0;
            this.txtPlayerHealth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCurrentHealth
            // 
            this.lblCurrentHealth.AutoSize = true;
            this.lblCurrentHealth.Location = new System.Drawing.Point(26, 182);
            this.lblCurrentHealth.Name = "lblCurrentHealth";
            this.lblCurrentHealth.Size = new System.Drawing.Size(80, 15);
            this.lblCurrentHealth.TabIndex = 1;
            this.lblCurrentHealth.Text = "Player Health:";
            // 
            // lblDocument
            // 
            this.lblDocument.AutoSize = true;
            this.lblDocument.Location = new System.Drawing.Point(183, 46);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(143, 15);
            this.lblDocument.TabIndex = 1;
            this.lblDocument.Text = "Please select a document:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(11, 96);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(77, 15);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Document ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete a player:";
            // 
            // playerInformation
            // 
            this.playerInformation.AutoSize = true;
            this.playerInformation.Location = new System.Drawing.Point(107, 40);
            this.playerInformation.Name = "playerInformation";
            this.playerInformation.Size = new System.Drawing.Size(108, 15);
            this.playerInformation.TabIndex = 1;
            this.playerInformation.Text = "Player information:";
            // 
            // cboPlayerName
            // 
            this.cboPlayerName.FormattingEnabled = true;
            this.cboPlayerName.Location = new System.Drawing.Point(106, 93);
            this.cboPlayerName.Name = "cboPlayerName";
            this.cboPlayerName.Size = new System.Drawing.Size(230, 23);
            this.cboPlayerName.TabIndex = 4;
            this.cboPlayerName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblUpdatePlayer
            // 
            this.lblUpdatePlayer.AutoSize = true;
            this.lblUpdatePlayer.Location = new System.Drawing.Point(124, 33);
            this.lblUpdatePlayer.Name = "lblUpdatePlayer";
            this.lblUpdatePlayer.Size = new System.Drawing.Size(92, 15);
            this.lblUpdatePlayer.TabIndex = 1;
            this.lblUpdatePlayer.Text = "Update a player:";
            this.lblUpdatePlayer.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Health:";
            // 
            // txtUpdatePlayerHealth
            // 
            this.txtUpdatePlayerHealth.Location = new System.Drawing.Point(109, 176);
            this.txtUpdatePlayerHealth.Name = "txtUpdatePlayerHealth";
            this.txtUpdatePlayerHealth.Size = new System.Drawing.Size(148, 23);
            this.txtUpdatePlayerHealth.TabIndex = 3;
            this.txtUpdatePlayerHealth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Player Level:";
            // 
            // txtUpdatePlayerLevel
            // 
            this.txtUpdatePlayerLevel.Location = new System.Drawing.Point(109, 147);
            this.txtUpdatePlayerLevel.Name = "txtUpdatePlayerLevel";
            this.txtUpdatePlayerLevel.Size = new System.Drawing.Size(148, 23);
            this.txtUpdatePlayerLevel.TabIndex = 2;
            this.txtUpdatePlayerLevel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Player Class:";
            // 
            // txtUpdatePlayerClass
            // 
            this.txtUpdatePlayerClass.Location = new System.Drawing.Point(109, 118);
            this.txtUpdatePlayerClass.Name = "txtUpdatePlayerClass";
            this.txtUpdatePlayerClass.Size = new System.Drawing.Size(148, 23);
            this.txtUpdatePlayerClass.TabIndex = 1;
            this.txtUpdatePlayerClass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Player name:";
            // 
            // txtUpdatePlayerName
            // 
            this.txtUpdatePlayerName.Location = new System.Drawing.Point(109, 87);
            this.txtUpdatePlayerName.Name = "txtUpdatePlayerName";
            this.txtUpdatePlayerName.Size = new System.Drawing.Size(148, 23);
            this.txtUpdatePlayerName.TabIndex = 0;
            this.txtUpdatePlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDeletePlayerName
            // 
            this.txtDeletePlayerName.Location = new System.Drawing.Point(147, 58);
            this.txtDeletePlayerName.Name = "txtDeletePlayerName";
            this.txtDeletePlayerName.Size = new System.Drawing.Size(148, 23);
            this.txtDeletePlayerName.TabIndex = 0;
            this.txtDeletePlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Player name:";
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(132, 205);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePlayer.TabIndex = 5;
            this.btnUpdatePlayer.Text = "Update";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(174, 92);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePlayer.TabIndex = 5;
            this.btnDeletePlayer.Text = "Detele";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // grpSelectPlayer
            // 
            this.grpSelectPlayer.Controls.Add(this.txtRevNumber);
            this.grpSelectPlayer.Controls.Add(this.label3);
            this.grpSelectPlayer.Controls.Add(this.lblDocument);
            this.grpSelectPlayer.Controls.Add(this.lblSelect);
            this.grpSelectPlayer.Controls.Add(this.cboPlayerName);
            this.grpSelectPlayer.Location = new System.Drawing.Point(75, 14);
            this.grpSelectPlayer.Name = "grpSelectPlayer";
            this.grpSelectPlayer.Size = new System.Drawing.Size(381, 206);
            this.grpSelectPlayer.TabIndex = 6;
            this.grpSelectPlayer.TabStop = false;
            this.grpSelectPlayer.Text = "Select a document/player";
            // 
            // txtRevNumber
            // 
            this.txtRevNumber.Enabled = false;
            this.txtRevNumber.Location = new System.Drawing.Point(106, 122);
            this.txtRevNumber.Name = "txtRevNumber";
            this.txtRevNumber.Size = new System.Drawing.Size(230, 23);
            this.txtRevNumber.TabIndex = 0;
            this.txtRevNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rev number";
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.txtShowPlayerRegion);
            this.grpInformation.Controls.Add(this.lblRegion);
            this.grpInformation.Controls.Add(this.playerInformation);
            this.grpInformation.Controls.Add(this.txtPlayerName);
            this.grpInformation.Controls.Add(this.playerName);
            this.grpInformation.Controls.Add(this.txtPlayerClass);
            this.grpInformation.Controls.Add(this.playerClasslbl);
            this.grpInformation.Controls.Add(this.txtPlayerLevel);
            this.grpInformation.Controls.Add(this.plrlevellbl);
            this.grpInformation.Controls.Add(this.txtPlayerHealth);
            this.grpInformation.Controls.Add(this.lblCurrentHealth);
            this.grpInformation.Enabled = false;
            this.grpInformation.Location = new System.Drawing.Point(106, 229);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(305, 261);
            this.grpInformation.TabIndex = 7;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Player information";
            // 
            // txtShowPlayerRegion
            // 
            this.txtShowPlayerRegion.Location = new System.Drawing.Point(107, 63);
            this.txtShowPlayerRegion.Name = "txtShowPlayerRegion";
            this.txtShowPlayerRegion.Size = new System.Drawing.Size(148, 23);
            this.txtShowPlayerRegion.TabIndex = 0;
            this.txtShowPlayerRegion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(26, 66);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(82, 15);
            this.lblRegion.TabIndex = 1;
            this.lblRegion.Text = "player Region:";
            // 
            // grpWhatToDoNext
            // 
            this.grpWhatToDoNext.Controls.Add(this.label15);
            this.grpWhatToDoNext.Controls.Add(this.btnToDeletePLayer);
            this.grpWhatToDoNext.Controls.Add(this.btnToUpdatePlayer);
            this.grpWhatToDoNext.Enabled = false;
            this.grpWhatToDoNext.Location = new System.Drawing.Point(479, 26);
            this.grpWhatToDoNext.Name = "grpWhatToDoNext";
            this.grpWhatToDoNext.Size = new System.Drawing.Size(461, 134);
            this.grpWhatToDoNext.TabIndex = 8;
            this.grpWhatToDoNext.TabStop = false;
            this.grpWhatToDoNext.Text = "To do next";
            this.grpWhatToDoNext.Enter += new System.EventHandler(this.grpWhatToDoNext_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(180, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "To do next:";
            // 
            // btnToDeletePLayer
            // 
            this.btnToDeletePLayer.Location = new System.Drawing.Point(240, 72);
            this.btnToDeletePLayer.Name = "btnToDeletePLayer";
            this.btnToDeletePLayer.Size = new System.Drawing.Size(107, 27);
            this.btnToDeletePLayer.TabIndex = 4;
            this.btnToDeletePLayer.Text = "Delete player";
            this.btnToDeletePLayer.UseVisualStyleBackColor = true;
            this.btnToDeletePLayer.Click += new System.EventHandler(this.btnToDeletePLayer_Click);
            // 
            // btnToUpdatePlayer
            // 
            this.btnToUpdatePlayer.Location = new System.Drawing.Point(99, 72);
            this.btnToUpdatePlayer.Name = "btnToUpdatePlayer";
            this.btnToUpdatePlayer.Size = new System.Drawing.Size(95, 27);
            this.btnToUpdatePlayer.TabIndex = 2;
            this.btnToUpdatePlayer.Text = "Update Player";
            this.btnToUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnToUpdatePlayer.Click += new System.EventHandler(this.btnToUpdatePlayer_Click);
            // 
            // btnToAddNewPLayer
            // 
            this.btnToAddNewPLayer.Location = new System.Drawing.Point(127, 43);
            this.btnToAddNewPLayer.Name = "btnToAddNewPLayer";
            this.btnToAddNewPLayer.Size = new System.Drawing.Size(104, 27);
            this.btnToAddNewPLayer.TabIndex = 3;
            this.btnToAddNewPLayer.Text = "Add new player";
            this.btnToAddNewPLayer.UseVisualStyleBackColor = true;
            this.btnToAddNewPLayer.Click += new System.EventHandler(this.btnToAddNewPLayer_Click);
            // 
            // grpUpdatePlayer
            // 
            this.grpUpdatePlayer.Controls.Add(this.cboUpdateRegion);
            this.grpUpdatePlayer.Controls.Add(this.label14);
            this.grpUpdatePlayer.Controls.Add(this.lblUpdatePlayer);
            this.grpUpdatePlayer.Controls.Add(this.label2);
            this.grpUpdatePlayer.Controls.Add(this.txtUpdatePlayerHealth);
            this.grpUpdatePlayer.Controls.Add(this.label4);
            this.grpUpdatePlayer.Controls.Add(this.txtUpdatePlayerLevel);
            this.grpUpdatePlayer.Controls.Add(this.btnUpdatePlayer);
            this.grpUpdatePlayer.Controls.Add(this.label5);
            this.grpUpdatePlayer.Controls.Add(this.txtUpdatePlayerClass);
            this.grpUpdatePlayer.Controls.Add(this.label6);
            this.grpUpdatePlayer.Controls.Add(this.txtUpdatePlayerName);
            this.grpUpdatePlayer.Enabled = false;
            this.grpUpdatePlayer.Location = new System.Drawing.Point(479, 260);
            this.grpUpdatePlayer.Name = "grpUpdatePlayer";
            this.grpUpdatePlayer.Size = new System.Drawing.Size(324, 288);
            this.grpUpdatePlayer.TabIndex = 9;
            this.grpUpdatePlayer.TabStop = false;
            this.grpUpdatePlayer.Text = "Update Player";
            // 
            // cboUpdateRegion
            // 
            this.cboUpdateRegion.FormattingEnabled = true;
            this.cboUpdateRegion.Items.AddRange(new object[] {
            "Europe",
            "Asia",
            "America",
            "Africa",
            "Russia",
            "Mexico"});
            this.cboUpdateRegion.Location = new System.Drawing.Point(109, 55);
            this.cboUpdateRegion.Name = "cboUpdateRegion";
            this.cboUpdateRegion.Size = new System.Drawing.Size(148, 23);
            this.cboUpdateRegion.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "player Region:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Add a new player:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Player Health:";
            // 
            // txtAddPlayerHealth
            // 
            this.txtAddPlayerHealth.Location = new System.Drawing.Point(110, 178);
            this.txtAddPlayerHealth.Name = "txtAddPlayerHealth";
            this.txtAddPlayerHealth.Size = new System.Drawing.Size(148, 23);
            this.txtAddPlayerHealth.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Player Level:";
            // 
            // txtAddPlayerLevel
            // 
            this.txtAddPlayerLevel.Location = new System.Drawing.Point(110, 149);
            this.txtAddPlayerLevel.Name = "txtAddPlayerLevel";
            this.txtAddPlayerLevel.Size = new System.Drawing.Size(148, 23);
            this.txtAddPlayerLevel.TabIndex = 2;
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(133, 207);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewPlayer.TabIndex = 5;
            this.btnAddNewPlayer.Text = "Add";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Player Class:";
            // 
            // txtAddPlayerClass
            // 
            this.txtAddPlayerClass.Location = new System.Drawing.Point(110, 120);
            this.txtAddPlayerClass.Name = "txtAddPlayerClass";
            this.txtAddPlayerClass.Size = new System.Drawing.Size(148, 23);
            this.txtAddPlayerClass.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Player name:";
            // 
            // txtAddPlayerName
            // 
            this.txtAddPlayerName.Location = new System.Drawing.Point(110, 89);
            this.txtAddPlayerName.Name = "txtAddPlayerName";
            this.txtAddPlayerName.Size = new System.Drawing.Size(148, 23);
            this.txtAddPlayerName.TabIndex = 0;
            // 
            // grpAddPlayer
            // 
            this.grpAddPlayer.Controls.Add(this.cboAddRegion);
            this.grpAddPlayer.Controls.Add(this.playerRegionaa);
            this.grpAddPlayer.Controls.Add(this.label8);
            this.grpAddPlayer.Controls.Add(this.label9);
            this.grpAddPlayer.Controls.Add(this.txtAddPlayerHealth);
            this.grpAddPlayer.Controls.Add(this.label10);
            this.grpAddPlayer.Controls.Add(this.txtAddPlayerLevel);
            this.grpAddPlayer.Controls.Add(this.btnAddNewPlayer);
            this.grpAddPlayer.Controls.Add(this.label11);
            this.grpAddPlayer.Controls.Add(this.txtAddPlayerClass);
            this.grpAddPlayer.Controls.Add(this.label12);
            this.grpAddPlayer.Controls.Add(this.txtAddPlayerName);
            this.grpAddPlayer.Enabled = false;
            this.grpAddPlayer.Location = new System.Drawing.Point(831, 260);
            this.grpAddPlayer.Name = "grpAddPlayer";
            this.grpAddPlayer.Size = new System.Drawing.Size(324, 253);
            this.grpAddPlayer.TabIndex = 9;
            this.grpAddPlayer.TabStop = false;
            this.grpAddPlayer.Text = "Add Player";
            this.grpAddPlayer.Enter += new System.EventHandler(this.grpAddPlayer_Enter);
            // 
            // cboAddRegion
            // 
            this.cboAddRegion.FormattingEnabled = true;
            this.cboAddRegion.Items.AddRange(new object[] {
            "Europe",
            "Asia",
            "America",
            "Africa",
            "Russia",
            "Mexico"});
            this.cboAddRegion.Location = new System.Drawing.Point(110, 60);
            this.cboAddRegion.Name = "cboAddRegion";
            this.cboAddRegion.Size = new System.Drawing.Size(150, 23);
            this.cboAddRegion.TabIndex = 6;
            // 
            // playerRegionaa
            // 
            this.playerRegionaa.AutoSize = true;
            this.playerRegionaa.Location = new System.Drawing.Point(29, 64);
            this.playerRegionaa.Name = "playerRegionaa";
            this.playerRegionaa.Size = new System.Drawing.Size(79, 15);
            this.playerRegionaa.TabIndex = 1;
            this.playerRegionaa.Text = "Player region:";
            // 
            // grpDeleteBox
            // 
            this.grpDeleteBox.Controls.Add(this.label1);
            this.grpDeleteBox.Controls.Add(this.txtDeletePlayerName);
            this.grpDeleteBox.Controls.Add(this.label7);
            this.grpDeleteBox.Controls.Add(this.btnDeletePlayer);
            this.grpDeleteBox.Enabled = false;
            this.grpDeleteBox.Location = new System.Drawing.Point(955, 45);
            this.grpDeleteBox.Name = "grpDeleteBox";
            this.grpDeleteBox.Size = new System.Drawing.Size(375, 133);
            this.grpDeleteBox.TabIndex = 10;
            this.grpDeleteBox.TabStop = false;
            this.grpDeleteBox.Text = "Delete a player";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(164, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "To do next:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete player";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update Player";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To do next";
            this.groupBox1.Enter += new System.EventHandler(this.grpWhatToDoNext_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Add a new player:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToAddNewPLayer);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(522, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new player:";
            // 
            // GrpShowAllRegions
            // 
            this.GrpShowAllRegions.Controls.Add(this.listAllRegions);
            this.GrpShowAllRegions.Location = new System.Drawing.Point(86, 572);
            this.GrpShowAllRegions.Name = "GrpShowAllRegions";
            this.GrpShowAllRegions.Size = new System.Drawing.Size(1091, 241);
            this.GrpShowAllRegions.TabIndex = 2;
            this.GrpShowAllRegions.TabStop = false;
            this.GrpShowAllRegions.Text = "Show all regions view:";
            // 
            // listAllRegions
            // 
            this.listAllRegions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listAllRegions.FormattingEnabled = true;
            this.listAllRegions.ItemHeight = 17;
            this.listAllRegions.Location = new System.Drawing.Point(20, 22);
            this.listAllRegions.Name = "listAllRegions";
            this.listAllRegions.ScrollAlwaysVisible = true;
            this.listAllRegions.Size = new System.Drawing.Size(1003, 174);
            this.listAllRegions.TabIndex = 0;
            this.listAllRegions.SelectedIndexChanged += new System.EventHandler(this.listAllRegions_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 861);
            this.Controls.Add(this.GrpShowAllRegions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpDeleteBox);
            this.Controls.Add(this.grpAddPlayer);
            this.Controls.Add(this.grpUpdatePlayer);
            this.Controls.Add(this.grpWhatToDoNext);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.grpSelectPlayer);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSelectPlayer.ResumeLayout(false);
            this.grpSelectPlayer.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpWhatToDoNext.ResumeLayout(false);
            this.grpWhatToDoNext.PerformLayout();
            this.grpUpdatePlayer.ResumeLayout(false);
            this.grpUpdatePlayer.PerformLayout();
            this.grpAddPlayer.ResumeLayout(false);
            this.grpAddPlayer.PerformLayout();
            this.grpDeleteBox.ResumeLayout(false);
            this.grpDeleteBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GrpShowAllRegions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.TextBox txtPlayerClass;
        private System.Windows.Forms.Label playerClasslbl;
        private System.Windows.Forms.TextBox txtPlayerLevel;
        private System.Windows.Forms.Label plrlevellbl;
        private System.Windows.Forms.TextBox txtPlayerHealth;
        private System.Windows.Forms.Label lblCurrentHealth;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerInformation;
        private System.Windows.Forms.ComboBox cboPlayerName;
        private System.Windows.Forms.Label lblUpdatePlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdatePlayerHealth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdatePlayerLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdatePlayerClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdatePlayerName;
        private System.Windows.Forms.TextBox txtDeletePlayerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.GroupBox grpSelectPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.GroupBox grpWhatToDoNext;
        private System.Windows.Forms.GroupBox grpUpdatePlayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddPlayerHealth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddPlayerLevel;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddPlayerClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddPlayerName;
        private System.Windows.Forms.GroupBox grpAddPlayer;
        private System.Windows.Forms.GroupBox grpDeleteBox;
        private System.Windows.Forms.Button btnToUpdatePlayer;
        private System.Windows.Forms.Button btnToDeletePLayer;
        private System.Windows.Forms.Button btnToAddNewPLayer;
        private System.Windows.Forms.TextBox txtRevNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtShowPlayerRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox GrpShowAllRegions;
        private System.Windows.Forms.ListBox listAllRegions;
        private System.Windows.Forms.Label playerRegionaa;
        private System.Windows.Forms.ComboBox cboUpdateRegion;
        private System.Windows.Forms.ComboBox cboAddRegion;
    }
}

