namespace CSNext
{
    partial class SpellBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridSpells = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.tDuration = new System.Windows.Forms.TextBox();
            this.tRange = new System.Windows.Forms.TextBox();
            this.tTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSchool = new System.Windows.Forms.ComboBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridSpells)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridSpells
            // 
            this.GridSpells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSpells.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLevel,
            this.colSchool,
            this.colTime,
            this.colRange,
            this.colDuration,
            this.colDescription});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridSpells.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridSpells.Location = new System.Drawing.Point(12, 276);
            this.GridSpells.Name = "GridSpells";
            this.GridSpells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSpells.Size = new System.Drawing.Size(941, 355);
            this.GridSpells.TabIndex = 7;
            this.GridSpells.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSpells_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spell Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range of Spell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Casting Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "School of Magic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Spell Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(703, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Duration of Spell:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Spell Level:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(19, 43);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(146, 20);
            this.tName.TabIndex = 0;
            this.tName.TextChanged += new System.EventHandler(this.AutoSearch);
            this.tName.Enter += new System.EventHandler(this.tName_Enter);
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(19, 91);
            this.tDescription.Multiline = true;
            this.tDescription.Name = "tDescription";
            this.tDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDescription.Size = new System.Drawing.Size(904, 103);
            this.tDescription.TabIndex = 6;
            // 
            // tDuration
            // 
            this.tDuration.Location = new System.Drawing.Point(706, 43);
            this.tDuration.Name = "tDuration";
            this.tDuration.Size = new System.Drawing.Size(217, 20);
            this.tDuration.TabIndex = 5;
            this.tDuration.TextChanged += new System.EventHandler(this.AutoSearch);
            // 
            // tRange
            // 
            this.tRange.Location = new System.Drawing.Point(524, 43);
            this.tRange.Name = "tRange";
            this.tRange.Size = new System.Drawing.Size(176, 20);
            this.tRange.TabIndex = 4;
            this.tRange.TextChanged += new System.EventHandler(this.AutoSearch);
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(367, 43);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(151, 20);
            this.tTime.TabIndex = 3;
            this.tTime.TextChanged += new System.EventHandler(this.AutoSearch);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSchool);
            this.groupBox1.Controls.Add(this.cbLevel);
            this.groupBox1.Controls.Add(this.tDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tRange);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tDuration);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spell Details";
            // 
            // cbSchool
            // 
            this.cbSchool.AutoCompleteCustomSource.AddRange(new string[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
            this.cbSchool.FormattingEnabled = true;
            this.cbSchool.Items.AddRange(new object[] {
            "Abjuration",
            "Conjuration",
            "Divination",
            "Enchantment",
            "Evocation",
            "Illusion",
            "Necromancy",
            "Transmutation"});
            this.cbSchool.Location = new System.Drawing.Point(258, 43);
            this.cbSchool.Name = "cbSchool";
            this.cbSchool.Size = new System.Drawing.Size(103, 21);
            this.cbSchool.TabIndex = 2;
            this.cbSchool.TextChanged += new System.EventHandler(this.AutoSearch);
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
            this.cbLevel.Location = new System.Drawing.Point(171, 43);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(81, 21);
            this.cbLevel.TabIndex = 1;
            this.cbLevel.TextChanged += new System.EventHandler(this.AutoSearch);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(115, 12);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(97, 31);
            this.bClear.TabIndex = 9;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(856, 12);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(97, 31);
            this.bExit.TabIndex = 10;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(12, 12);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(97, 31);
            this.bSearch.TabIndex = 8;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Width = 45;
            // 
            // colSchool
            // 
            this.colSchool.HeaderText = "School";
            this.colSchool.Name = "colSchool";
            this.colSchool.Width = 95;
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Casting Time";
            this.colTime.Name = "colTime";
            // 
            // colRange
            // 
            this.colRange.HeaderText = "Range";
            this.colRange.Name = "colRange";
            this.colRange.Width = 85;
            // 
            // colDuration
            // 
            this.colDuration.HeaderText = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 255;
            // 
            // SpellBook
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 643);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridSpells);
            this.Name = "SpellBook";
            this.Text = "Spells";
            this.Load += new System.EventHandler(this.XMLSpells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSpells)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridSpells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.TextBox tDuration;
        private System.Windows.Forms.TextBox tRange;
        private System.Windows.Forms.TextBox tTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ComboBox cbSchool;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}