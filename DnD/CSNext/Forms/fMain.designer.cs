namespace CSNext
{
    partial class fMain
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
            this.bCharacter = new System.Windows.Forms.Button();
            this.btnXMLSpells = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCharacter
            // 
            this.bCharacter.Location = new System.Drawing.Point(12, 12);
            this.bCharacter.Name = "bCharacter";
            this.bCharacter.Size = new System.Drawing.Size(126, 32);
            this.bCharacter.TabIndex = 1;
            this.bCharacter.Text = "Characters";
            this.bCharacter.UseVisualStyleBackColor = true;
            this.bCharacter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXMLSpells
            // 
            this.btnXMLSpells.Location = new System.Drawing.Point(12, 50);
            this.btnXMLSpells.Name = "btnXMLSpells";
            this.btnXMLSpells.Size = new System.Drawing.Size(126, 32);
            this.btnXMLSpells.TabIndex = 4;
            this.btnXMLSpells.Text = "Spells Database";
            this.btnXMLSpells.UseVisualStyleBackColor = true;
            this.btnXMLSpells.Click += new System.EventHandler(this.btnXMLSpells_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Monster Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXMLSpells);
            this.Controls.Add(this.bCharacter);
            this.Name = "fMain";
            this.Text = "DnD Next";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCharacter;
        private System.Windows.Forms.Button btnXMLSpells;
        private System.Windows.Forms.Button button1;
    }
}

