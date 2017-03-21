namespace CSNext
{
    partial class XMLSpells
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridSpells = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpellsDS = new System.Data.DataSet();
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
            this.tSchool = new System.Windows.Forms.TextBox();
            this.tLevel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellsDS)).BeginInit();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridSpells.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridSpells.Location = new System.Drawing.Point(12, 224);
            this.GridSpells.Name = "GridSpells";
            this.GridSpells.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSpells.Size = new System.Drawing.Size(904, 341);
            this.GridSpells.TabIndex = 0;
            this.GridSpells.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSpells_CellClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Width = 60;
            // 
            // colSchool
            // 
            this.colSchool.HeaderText = "School";
            this.colSchool.Name = "colSchool";
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Casting Time";
            this.colTime.Name = "colTime";
            this.colTime.Width = 80;
            // 
            // colRange
            // 
            this.colRange.HeaderText = "Range";
            this.colRange.Name = "colRange";
            this.colRange.Width = 80;
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
            this.colDescription.Width = 285;
            // 
            // SpellsDS
            // 
            this.SpellsDS.DataSetName = "SpellsDS";
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
            this.label2.Location = new System.Drawing.Point(493, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range of Spell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Casting Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 27);
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
            this.label6.Location = new System.Drawing.Point(675, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Duration of Spell:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Spell Level:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(19, 43);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(118, 20);
            this.tName.TabIndex = 8;
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(19, 91);
            this.tDescription.Multiline = true;
            this.tDescription.Name = "tDescription";
            this.tDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDescription.Size = new System.Drawing.Size(871, 103);
            this.tDescription.TabIndex = 9;
            // 
            // tDuration
            // 
            this.tDuration.Location = new System.Drawing.Point(678, 43);
            this.tDuration.Name = "tDuration";
            this.tDuration.Size = new System.Drawing.Size(212, 20);
            this.tDuration.TabIndex = 10;
            // 
            // tRange
            // 
            this.tRange.Location = new System.Drawing.Point(496, 43);
            this.tRange.Name = "tRange";
            this.tRange.Size = new System.Drawing.Size(176, 20);
            this.tRange.TabIndex = 11;
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(339, 43);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(151, 20);
            this.tTime.TabIndex = 12;
            // 
            // tSchool
            // 
            this.tSchool.Location = new System.Drawing.Point(230, 43);
            this.tSchool.Name = "tSchool";
            this.tSchool.Size = new System.Drawing.Size(103, 20);
            this.tSchool.TabIndex = 13;
            // 
            // tLevel
            // 
            this.tLevel.Location = new System.Drawing.Point(143, 43);
            this.tLevel.Name = "tLevel";
            this.tLevel.Size = new System.Drawing.Size(81, 20);
            this.tLevel.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tDescription);
            this.groupBox1.Controls.Add(this.tLevel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tSchool);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spell Details";
            // 
            // XMLSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridSpells);
            this.Name = "XMLSpells";
            this.Text = "Spells";
            this.Load += new System.EventHandler(this.XMLSpells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridSpells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellsDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridSpells;
        private System.Data.DataSet SpellsDS;
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
        private System.Windows.Forms.TextBox tSchool;
        private System.Windows.Forms.TextBox tLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
    }
}