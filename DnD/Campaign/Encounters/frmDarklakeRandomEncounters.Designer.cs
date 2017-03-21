namespace DnD.OOTA
{
    partial class frmDarklakeRandomEncounters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridEncounters = new System.Windows.Forms.DataGridView();
            this.cDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numRolls = new System.Windows.Forms.NumericUpDown();
            this.rdRolls = new System.Windows.Forms.RadioButton();
            this.rdHours = new System.Windows.Forms.RadioButton();
            this.rdDays = new System.Windows.Forms.RadioButton();
            this.btnRoll = new System.Windows.Forms.Button();
            this.chkHour = new System.Windows.Forms.CheckBox();
            this.gbRoll = new System.Windows.Forms.GroupBox();
            this.txtTerrain = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreature = new System.Windows.Forms.RichTextBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridEncounters)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRolls)).BeginInit();
            this.gbRoll.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridEncounters
            // 
            this.GridEncounters.AllowUserToAddRows = false;
            this.GridEncounters.AllowUserToDeleteRows = false;
            this.GridEncounters.AllowUserToResizeRows = false;
            this.GridEncounters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridEncounters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridEncounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEncounters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDay,
            this.cHour,
            this.cRoll,
            this.cCreature,
            this.cLocation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEncounters.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridEncounters.Location = new System.Drawing.Point(12, 130);
            this.GridEncounters.Name = "GridEncounters";
            this.GridEncounters.RowHeadersVisible = false;
            this.GridEncounters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEncounters.Size = new System.Drawing.Size(584, 283);
            this.GridEncounters.TabIndex = 0;
            this.GridEncounters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEncounters_RowEnter);
            // 
            // cDay
            // 
            this.cDay.DataPropertyName = "Day";
            this.cDay.HeaderText = "Day";
            this.cDay.Name = "cDay";
            this.cDay.Width = 51;
            // 
            // cHour
            // 
            this.cHour.DataPropertyName = "Hour";
            this.cHour.HeaderText = "Hour";
            this.cHour.Name = "cHour";
            this.cHour.Width = 55;
            // 
            // cRoll
            // 
            this.cRoll.DataPropertyName = "Roll";
            this.cRoll.HeaderText = "Roll";
            this.cRoll.Name = "cRoll";
            this.cRoll.Width = 50;
            // 
            // cCreature
            // 
            this.cCreature.DataPropertyName = "Creature";
            this.cCreature.HeaderText = "Creature";
            this.cCreature.Name = "cCreature";
            this.cCreature.Width = 72;
            // 
            // cLocation
            // 
            this.cLocation.DataPropertyName = "Location";
            this.cLocation.HeaderText = "Location";
            this.cLocation.Name = "cLocation";
            this.cLocation.Width = 73;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // numRolls
            // 
            this.numRolls.Location = new System.Drawing.Point(17, 26);
            this.numRolls.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRolls.Name = "numRolls";
            this.numRolls.Size = new System.Drawing.Size(107, 20);
            this.numRolls.TabIndex = 3;
            this.numRolls.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdRolls
            // 
            this.rdRolls.AutoSize = true;
            this.rdRolls.Checked = true;
            this.rdRolls.Location = new System.Drawing.Point(17, 63);
            this.rdRolls.Name = "rdRolls";
            this.rdRolls.Size = new System.Drawing.Size(48, 17);
            this.rdRolls.TabIndex = 4;
            this.rdRolls.TabStop = true;
            this.rdRolls.Text = "Rolls";
            this.rdRolls.UseVisualStyleBackColor = true;
            // 
            // rdHours
            // 
            this.rdHours.AutoSize = true;
            this.rdHours.Location = new System.Drawing.Point(82, 63);
            this.rdHours.Name = "rdHours";
            this.rdHours.Size = new System.Drawing.Size(53, 17);
            this.rdHours.TabIndex = 5;
            this.rdHours.Text = "Hours";
            this.rdHours.UseVisualStyleBackColor = true;
            // 
            // rdDays
            // 
            this.rdDays.AutoSize = true;
            this.rdDays.Location = new System.Drawing.Point(152, 63);
            this.rdDays.Name = "rdDays";
            this.rdDays.Size = new System.Drawing.Size(49, 17);
            this.rdDays.TabIndex = 6;
            this.rdDays.Text = "Days";
            this.rdDays.UseVisualStyleBackColor = true;
            // 
            // btnRoll
            // 
            this.btnRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRoll.Location = new System.Drawing.Point(467, 19);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(111, 33);
            this.btnRoll.TabIndex = 7;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // chkHour
            // 
            this.chkHour.AutoSize = true;
            this.chkHour.Checked = true;
            this.chkHour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHour.Location = new System.Drawing.Point(467, 58);
            this.chkHour.Name = "chkHour";
            this.chkHour.Size = new System.Drawing.Size(63, 17);
            this.chkHour.TabIndex = 8;
            this.chkHour.Text = "4 Hours";
            this.chkHour.UseVisualStyleBackColor = true;
            this.chkHour.CheckedChanged += new System.EventHandler(this.chkHour_CheckedChanged);
            // 
            // gbRoll
            // 
            this.gbRoll.Controls.Add(this.numRolls);
            this.gbRoll.Controls.Add(this.btnRoll);
            this.gbRoll.Controls.Add(this.chkHour);
            this.gbRoll.Controls.Add(this.rdDays);
            this.gbRoll.Controls.Add(this.rdRolls);
            this.gbRoll.Controls.Add(this.rdHours);
            this.gbRoll.Location = new System.Drawing.Point(12, 27);
            this.gbRoll.Name = "gbRoll";
            this.gbRoll.Size = new System.Drawing.Size(584, 97);
            this.gbRoll.TabIndex = 9;
            this.gbRoll.TabStop = false;
            this.gbRoll.Text = "Every 4 Hours";
            // 
            // txtTerrain
            // 
            this.txtTerrain.Location = new System.Drawing.Point(12, 432);
            this.txtTerrain.Name = "txtTerrain";
            this.txtTerrain.Size = new System.Drawing.Size(584, 86);
            this.txtTerrain.TabIndex = 10;
            this.txtTerrain.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Terrain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Creature:";
            // 
            // txtCreature
            // 
            this.txtCreature.Location = new System.Drawing.Point(12, 537);
            this.txtCreature.Name = "txtCreature";
            this.txtCreature.Size = new System.Drawing.Size(584, 97);
            this.txtCreature.TabIndex = 12;
            this.txtCreature.Text = "";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.underToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // underToolStripMenuItem
            // 
            this.underToolStripMenuItem.Name = "underToolStripMenuItem";
            this.underToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.underToolStripMenuItem.Text = "Under";
            this.underToolStripMenuItem.Click += new System.EventHandler(this.underToolStripMenuItem_Click);
            // 
            // frmDarklakeRandomEncounters
            // 
            this.AcceptButton = this.btnRoll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTerrain);
            this.Controls.Add(this.gbRoll);
            this.Controls.Add(this.GridEncounters);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDarklakeRandomEncounters";
            this.Text = "Darklake Random Encounters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEncounters)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRolls)).EndInit();
            this.gbRoll.ResumeLayout(false);
            this.gbRoll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEncounters;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numRolls;
        private System.Windows.Forms.RadioButton rdRolls;
        private System.Windows.Forms.RadioButton rdHours;
        private System.Windows.Forms.RadioButton rdDays;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreature;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLocation;
        private System.Windows.Forms.CheckBox chkHour;
        private System.Windows.Forms.GroupBox gbRoll;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtTerrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCreature;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underToolStripMenuItem;
    }
}

