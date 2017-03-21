

namespace CSNext
{
    partial class AbilityScores
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nStr = new System.Windows.Forms.NumericUpDown();
            this.nDex = new System.Windows.Forms.NumericUpDown();
            this.nCon = new System.Windows.Forms.NumericUpDown();
            this.nInt = new System.Windows.Forms.NumericUpDown();
            this.nWis = new System.Windows.Forms.NumericUpDown();
            this.nCha = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tCurrent = new System.Windows.Forms.TextBox();
            this.ckPoint = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tCostCha = new System.Windows.Forms.TextBox();
            this.tCostWis = new System.Windows.Forms.TextBox();
            this.tCostInt = new System.Windows.Forms.TextBox();
            this.tCostCon = new System.Windows.Forms.TextBox();
            this.tCostDex = new System.Windows.Forms.TextBox();
            this.tCostStr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Charisma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wisdom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Intelligence:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Constitution:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dexterity:";
            // 
            // nStr
            // 
            this.nStr.Location = new System.Drawing.Point(76, 12);
            this.nStr.Name = "nStr";
            this.nStr.Size = new System.Drawing.Size(71, 20);
            this.nStr.TabIndex = 15;
            this.nStr.Tag = "str";
            this.nStr.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            this.nStr.Enter += new System.EventHandler(this.Numeric_Enter);
            // 
            // nDex
            // 
            this.nDex.Location = new System.Drawing.Point(76, 38);
            this.nDex.Name = "nDex";
            this.nDex.Size = new System.Drawing.Size(71, 20);
            this.nDex.TabIndex = 16;
            this.nDex.Tag = "dex";
            this.nDex.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            this.nDex.Enter += new System.EventHandler(this.Numeric_Enter);
            // 
            // nCon
            // 
            this.nCon.Location = new System.Drawing.Point(76, 64);
            this.nCon.Name = "nCon";
            this.nCon.Size = new System.Drawing.Size(71, 20);
            this.nCon.TabIndex = 17;
            this.nCon.Tag = "con";
            this.nCon.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            this.nCon.Enter += new System.EventHandler(this.Numeric_Enter);
            // 
            // nInt
            // 
            this.nInt.Location = new System.Drawing.Point(76, 90);
            this.nInt.Name = "nInt";
            this.nInt.Size = new System.Drawing.Size(71, 20);
            this.nInt.TabIndex = 18;
            this.nInt.Tag = "int";
            this.nInt.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            this.nInt.Enter += new System.EventHandler(this.Numeric_Enter);
            // 
            // nWis
            // 
            this.nWis.Location = new System.Drawing.Point(76, 116);
            this.nWis.Name = "nWis";
            this.nWis.Size = new System.Drawing.Size(71, 20);
            this.nWis.TabIndex = 19;
            this.nWis.Tag = "wis";
            this.nWis.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            this.nWis.Enter += new System.EventHandler(this.Numeric_Enter);
            // 
            // nCha
            // 
            this.nCha.Location = new System.Drawing.Point(76, 142);
            this.nCha.Name = "nCha";
            this.nCha.Size = new System.Drawing.Size(71, 20);
            this.nCha.TabIndex = 20;
            this.nCha.Tag = "cha";
            this.nCha.ValueChanged += new System.EventHandler(this.Numeric_ValueChanged);
            this.nCha.Enter += new System.EventHandler(this.Numeric_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Remaining:";
            // 
            // tCurrent
            // 
            this.tCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCurrent.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tCurrent.Location = new System.Drawing.Point(190, 31);
            this.tCurrent.Multiline = true;
            this.tCurrent.Name = "tCurrent";
            this.tCurrent.ReadOnly = true;
            this.tCurrent.Size = new System.Drawing.Size(71, 41);
            this.tCurrent.TabIndex = 25;
            // 
            // ckPoint
            // 
            this.ckPoint.AutoSize = true;
            this.ckPoint.Location = new System.Drawing.Point(190, 78);
            this.ckPoint.Name = "ckPoint";
            this.ckPoint.Size = new System.Drawing.Size(71, 17);
            this.ckPoint.TabIndex = 26;
            this.ckPoint.Text = "Point Buy";
            this.ckPoint.UseVisualStyleBackColor = true;
            this.ckPoint.CheckedChanged += new System.EventHandler(this.ckPoint_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tCostCha
            // 
            this.tCostCha.Location = new System.Drawing.Point(153, 142);
            this.tCostCha.Name = "tCostCha";
            this.tCostCha.ReadOnly = true;
            this.tCostCha.Size = new System.Drawing.Size(28, 20);
            this.tCostCha.TabIndex = 28;
            // 
            // tCostWis
            // 
            this.tCostWis.Location = new System.Drawing.Point(153, 116);
            this.tCostWis.Name = "tCostWis";
            this.tCostWis.ReadOnly = true;
            this.tCostWis.Size = new System.Drawing.Size(28, 20);
            this.tCostWis.TabIndex = 29;
            // 
            // tCostInt
            // 
            this.tCostInt.Location = new System.Drawing.Point(153, 89);
            this.tCostInt.Name = "tCostInt";
            this.tCostInt.ReadOnly = true;
            this.tCostInt.Size = new System.Drawing.Size(28, 20);
            this.tCostInt.TabIndex = 30;
            // 
            // tCostCon
            // 
            this.tCostCon.Location = new System.Drawing.Point(153, 64);
            this.tCostCon.Name = "tCostCon";
            this.tCostCon.ReadOnly = true;
            this.tCostCon.Size = new System.Drawing.Size(28, 20);
            this.tCostCon.TabIndex = 31;
            // 
            // tCostDex
            // 
            this.tCostDex.Location = new System.Drawing.Point(153, 38);
            this.tCostDex.Name = "tCostDex";
            this.tCostDex.ReadOnly = true;
            this.tCostDex.Size = new System.Drawing.Size(28, 20);
            this.tCostDex.TabIndex = 32;
            // 
            // tCostStr
            // 
            this.tCostStr.Location = new System.Drawing.Point(153, 12);
            this.tCostStr.Name = "tCostStr";
            this.tCostStr.ReadOnly = true;
            this.tCostStr.Size = new System.Drawing.Size(28, 20);
            this.tCostStr.TabIndex = 33;
            // 
            // AbilityScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 172);
            this.Controls.Add(this.tCostStr);
            this.Controls.Add(this.tCostDex);
            this.Controls.Add(this.tCostCon);
            this.Controls.Add(this.tCostInt);
            this.Controls.Add(this.tCostWis);
            this.Controls.Add(this.tCostCha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ckPoint);
            this.Controls.Add(this.tCurrent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nCha);
            this.Controls.Add(this.nWis);
            this.Controls.Add(this.nInt);
            this.Controls.Add(this.nCon);
            this.Controls.Add(this.nDex);
            this.Controls.Add(this.nStr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AbilityScores";
            this.Text = "AbilityScores";
            this.Load += new System.EventHandler(this.AbilityScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nStr;
        private System.Windows.Forms.NumericUpDown nDex;
        private System.Windows.Forms.NumericUpDown nCon;
        private System.Windows.Forms.NumericUpDown nInt;
        private System.Windows.Forms.NumericUpDown nWis;
        private System.Windows.Forms.NumericUpDown nCha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tCurrent;
        private System.Windows.Forms.CheckBox ckPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tCostCha;
        private System.Windows.Forms.TextBox tCostWis;
        private System.Windows.Forms.TextBox tCostInt;
        private System.Windows.Forms.TextBox tCostCon;
        private System.Windows.Forms.TextBox tCostDex;
        private System.Windows.Forms.TextBox tCostStr;
    }
}