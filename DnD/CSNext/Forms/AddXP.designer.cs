namespace CSNext
{
    partial class AddXP
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
            this.tXP1 = new System.Windows.Forms.TextBox();
            this.tXP5 = new System.Windows.Forms.TextBox();
            this.tXP4 = new System.Windows.Forms.TextBox();
            this.tXP3 = new System.Windows.Forms.TextBox();
            this.tXP2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tXP1
            // 
            this.tXP1.Location = new System.Drawing.Point(18, 22);
            this.tXP1.Name = "tXP1";
            this.tXP1.Size = new System.Drawing.Size(89, 20);
            this.tXP1.TabIndex = 0;
            this.tXP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XP_KeyPress);
            // 
            // tXP5
            // 
            this.tXP5.Location = new System.Drawing.Point(18, 126);
            this.tXP5.Name = "tXP5";
            this.tXP5.Size = new System.Drawing.Size(89, 20);
            this.tXP5.TabIndex = 4;
            this.tXP5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XP_KeyPress);
            // 
            // tXP4
            // 
            this.tXP4.Location = new System.Drawing.Point(18, 100);
            this.tXP4.Name = "tXP4";
            this.tXP4.Size = new System.Drawing.Size(89, 20);
            this.tXP4.TabIndex = 3;
            this.tXP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XP_KeyPress);
            // 
            // tXP3
            // 
            this.tXP3.Location = new System.Drawing.Point(18, 74);
            this.tXP3.Name = "tXP3";
            this.tXP3.Size = new System.Drawing.Size(89, 20);
            this.tXP3.TabIndex = 2;
            this.tXP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XP_KeyPress);
            // 
            // tXP2
            // 
            this.tXP2.Location = new System.Drawing.Point(18, 48);
            this.tXP2.Name = "tXP2";
            this.tXP2.Size = new System.Drawing.Size(89, 20);
            this.tXP2.TabIndex = 1;
            this.tXP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XP_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(113, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 70);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Enter all session XP into the textboxes then click the \'Add\' Button to add to you" +
    "r total XP";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(143, 111);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(112, 35);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "Add XP";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // AddXP
            // 
            this.AcceptButton = this.bAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 159);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tXP2);
            this.Controls.Add(this.tXP3);
            this.Controls.Add(this.tXP4);
            this.Controls.Add(this.tXP5);
            this.Controls.Add(this.tXP1);
            this.Name = "AddXP";
            this.Text = "AddXP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tXP1;
        private System.Windows.Forms.TextBox tXP5;
        private System.Windows.Forms.TextBox tXP4;
        private System.Windows.Forms.TextBox tXP3;
        private System.Windows.Forms.TextBox tXP2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAdd;
    }
}