namespace CSNext
{
    partial class Monsters
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
            this.GridMonsters = new System.Windows.Forms.DataGridView();
            this.MonsterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Str = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridMonsters)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMonsters
            // 
            this.GridMonsters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMonsters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMonsters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonsterName,
            this.Type,
            this.AC,
            this.HP,
            this.Speed,
            this.Str,
            this.Dex,
            this.Con,
            this.Int,
            this.Wis,
            this.Cha,
            this.Languages,
            this.Traits,
            this.Actions,
            this.Level,
            this.XP,
            this.Customization});
            this.GridMonsters.Location = new System.Drawing.Point(12, 131);
            this.GridMonsters.Name = "GridMonsters";
            this.GridMonsters.Size = new System.Drawing.Size(970, 313);
            this.GridMonsters.TabIndex = 0;
            // 
            // MonsterName
            // 
            this.MonsterName.HeaderText = "Name";
            this.MonsterName.Name = "MonsterName";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // AC
            // 
            this.AC.HeaderText = "AC";
            this.AC.Name = "AC";
            // 
            // HP
            // 
            this.HP.HeaderText = "HP";
            this.HP.Name = "HP";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            // 
            // Str
            // 
            this.Str.HeaderText = "Str";
            this.Str.Name = "Str";
            // 
            // Dex
            // 
            this.Dex.HeaderText = "Dex";
            this.Dex.Name = "Dex";
            // 
            // Con
            // 
            this.Con.HeaderText = "Con";
            this.Con.Name = "Con";
            // 
            // Int
            // 
            this.Int.HeaderText = "Int";
            this.Int.Name = "Int";
            // 
            // Wis
            // 
            this.Wis.HeaderText = "Wis";
            this.Wis.Name = "Wis";
            // 
            // Cha
            // 
            this.Cha.HeaderText = "Cha";
            this.Cha.Name = "Cha";
            // 
            // Languages
            // 
            this.Languages.HeaderText = "Languages";
            this.Languages.Name = "Languages";
            // 
            // Traits
            // 
            this.Traits.HeaderText = "Traits";
            this.Traits.Name = "Traits";
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // XP
            // 
            this.XP.HeaderText = "XP";
            this.XP.Name = "XP";
            // 
            // Customization
            // 
            this.Customization.HeaderText = "Customization";
            this.Customization.Name = "Customization";
            // 
            // Monsters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 456);
            this.Controls.Add(this.GridMonsters);
            this.Name = "Monsters";
            this.Text = "Monsters";
            this.Load += new System.EventHandler(this.Monsters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMonsters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMonsters;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Str;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Languages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn XP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customization;
    }
}