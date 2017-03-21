namespace CSNext
{
    partial class MonsterManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tType = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.tAC = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.tHP = new System.Windows.Forms.TextBox();
            this.tSpeed = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tCustomization = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tXP = new System.Windows.Forms.TextBox();
            this.tActions = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tTraits = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tLanguages = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tInt = new System.Windows.Forms.TextBox();
            this.tWis = new System.Windows.Forms.TextBox();
            this.tCha = new System.Windows.Forms.TextBox();
            this.tCon = new System.Windows.Forms.TextBox();
            this.tDex = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tStr = new System.Windows.Forms.TextBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.GridMonsters = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMonsters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monster Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monster Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Monster Level:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(134, 39);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(146, 20);
            this.tName.TabIndex = 0;
            this.tName.TextChanged += new System.EventHandler(this.AutoSearch);
            this.tName.Enter += new System.EventHandler(this.tName_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tType);
            this.groupBox1.Controls.Add(this.bSearch);
            this.groupBox1.Controls.Add(this.tAC);
            this.groupBox1.Controls.Add(this.bClear);
            this.groupBox1.Controls.Add(this.bExit);
            this.groupBox1.Controls.Add(this.tHP);
            this.groupBox1.Controls.Add(this.tSpeed);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.tCustomization);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tXP);
            this.groupBox1.Controls.Add(this.tActions);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tTraits);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tLanguages);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tInt);
            this.groupBox1.Controls.Add(this.tWis);
            this.groupBox1.Controls.Add(this.tCha);
            this.groupBox1.Controls.Add(this.tCon);
            this.groupBox1.Controls.Add(this.tDex);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tStr);
            this.groupBox1.Controls.Add(this.cbLevel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 441);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monster Details";
            // 
            // tType
            // 
            this.tType.Location = new System.Drawing.Point(376, 39);
            this.tType.Name = "tType";
            this.tType.Size = new System.Drawing.Size(219, 20);
            this.tType.TabIndex = 36;
            this.tType.TextChanged += new System.EventHandler(this.AutoSearch);
            this.tType.Enter += new System.EventHandler(this.tName_Enter);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(865, 14);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(97, 31);
            this.bSearch.TabIndex = 8;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tAC
            // 
            this.tAC.Location = new System.Drawing.Point(162, 91);
            this.tAC.Name = "tAC";
            this.tAC.Size = new System.Drawing.Size(190, 20);
            this.tAC.TabIndex = 35;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(865, 51);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(97, 31);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bExit
            // 
            this.bExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExit.Location = new System.Drawing.Point(865, 88);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(97, 31);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // tHP
            // 
            this.tHP.Location = new System.Drawing.Point(162, 65);
            this.tHP.Name = "tHP";
            this.tHP.Size = new System.Drawing.Size(85, 20);
            this.tHP.TabIndex = 34;
            // 
            // tSpeed
            // 
            this.tSpeed.Location = new System.Drawing.Point(376, 87);
            this.tSpeed.Multiline = true;
            this.tSpeed.Name = "tSpeed";
            this.tSpeed.Size = new System.Drawing.Size(202, 105);
            this.tSpeed.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(131, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "AC:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(131, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "HP:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Speed:";
            // 
            // tCustomization
            // 
            this.tCustomization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tCustomization.Location = new System.Drawing.Point(6, 367);
            this.tCustomization.Multiline = true;
            this.tCustomization.Name = "tCustomization";
            this.tCustomization.Size = new System.Drawing.Size(951, 59);
            this.tCustomization.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Customization:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(598, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "XP Value:";
            // 
            // tXP
            // 
            this.tXP.Location = new System.Drawing.Point(601, 39);
            this.tXP.Name = "tXP";
            this.tXP.ReadOnly = true;
            this.tXP.Size = new System.Drawing.Size(84, 20);
            this.tXP.TabIndex = 26;
            // 
            // tActions
            // 
            this.tActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tActions.Location = new System.Drawing.Point(6, 221);
            this.tActions.Multiline = true;
            this.tActions.Name = "tActions";
            this.tActions.Size = new System.Drawing.Size(951, 53);
            this.tActions.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Actions:";
            // 
            // tTraits
            // 
            this.tTraits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tTraits.Location = new System.Drawing.Point(6, 296);
            this.tTraits.Multiline = true;
            this.tTraits.Name = "tTraits";
            this.tTraits.Size = new System.Drawing.Size(951, 52);
            this.tTraits.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Traits:";
            // 
            // tLanguages
            // 
            this.tLanguages.Location = new System.Drawing.Point(134, 141);
            this.tLanguages.Multiline = true;
            this.tLanguages.Name = "tLanguages";
            this.tLanguages.Size = new System.Drawing.Size(218, 51);
            this.tLanguages.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Languages:";
            // 
            // tInt
            // 
            this.tInt.Location = new System.Drawing.Point(58, 117);
            this.tInt.Name = "tInt";
            this.tInt.Size = new System.Drawing.Size(59, 20);
            this.tInt.TabIndex = 19;
            // 
            // tWis
            // 
            this.tWis.Location = new System.Drawing.Point(58, 143);
            this.tWis.Name = "tWis";
            this.tWis.Size = new System.Drawing.Size(59, 20);
            this.tWis.TabIndex = 18;
            // 
            // tCha
            // 
            this.tCha.Location = new System.Drawing.Point(58, 169);
            this.tCha.Name = "tCha";
            this.tCha.Size = new System.Drawing.Size(59, 20);
            this.tCha.TabIndex = 17;
            // 
            // tCon
            // 
            this.tCon.Location = new System.Drawing.Point(58, 91);
            this.tCon.Name = "tCon";
            this.tCon.Size = new System.Drawing.Size(59, 20);
            this.tCon.TabIndex = 16;
            // 
            // tDex
            // 
            this.tDex.Location = new System.Drawing.Point(58, 65);
            this.tDex.Name = "tDex";
            this.tDex.Size = new System.Drawing.Size(59, 20);
            this.tDex.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Wis:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Int:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Con:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Dex:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Str:";
            // 
            // tStr
            // 
            this.tStr.Location = new System.Drawing.Point(58, 39);
            this.tStr.Name = "tStr";
            this.tStr.Size = new System.Drawing.Size(59, 20);
            this.tStr.TabIndex = 8;
            // 
            // cbLevel
            // 
            this.cbLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "Cantrip",
            "1st Level",
            "2nd Level",
            "3rd Level",
            "4th Level",
            "5th Level",
            "6th Level",
            "7th Level",
            "8th Level",
            "9th Level"});
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbLevel.Location = new System.Drawing.Point(286, 39);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(81, 21);
            this.cbLevel.TabIndex = 1;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.AutoSearch);
            this.cbLevel.TextChanged += new System.EventHandler(this.AutoSearch);
            // 
            // GridMonsters
            // 
            this.GridMonsters.AllowUserToResizeRows = false;
            this.GridMonsters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMonsters.Location = new System.Drawing.Point(12, 459);
            this.GridMonsters.MultiSelect = false;
            this.GridMonsters.Name = "GridMonsters";
            this.GridMonsters.ReadOnly = true;
            this.GridMonsters.RowHeadersVisible = false;
            this.GridMonsters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMonsters.Size = new System.Drawing.Size(968, 258);
            this.GridMonsters.TabIndex = 16;
            this.GridMonsters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMonsters_CellClick);
            // 
            // MonsterManual
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 729);
            this.Controls.Add(this.GridMonsters);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(721, 598);
            this.Name = "MonsterManual";
            this.Text = "Monster Manual";
            this.Load += new System.EventHandler(this.MonsterManual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMonsters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridView GridMonsters;
        private System.Windows.Forms.TextBox tCustomization;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tXP;
        private System.Windows.Forms.TextBox tActions;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tTraits;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tLanguages;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tInt;
        private System.Windows.Forms.TextBox tWis;
        private System.Windows.Forms.TextBox tCha;
        private System.Windows.Forms.TextBox tCon;
        private System.Windows.Forms.TextBox tDex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tStr;
        private System.Windows.Forms.TextBox tAC;
        private System.Windows.Forms.TextBox tHP;
        private System.Windows.Forms.TextBox tSpeed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tType;
    }
}