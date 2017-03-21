using System.Data;
using System.Data.SqlClient;


namespace CSNext
{
    partial class Spells
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label schoolLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label rangeLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spells));
            this.spellsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.spellsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.schoolTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.rangeTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GridSpells = new System.Windows.Forms.DataGridView();
            this.spellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.nextDataSet = new CSNext.NextDataSet();
            //this.spellsTableAdapter = new CSNext.NextDataSetTableAdapters.SpellsTableAdapter();
            //this.tableAdapterManager = new CSNext.NextDataSetTableAdapters.TableAdapterManager();
            this.xmlDS = new System.Data.DataSet();
            nameLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            schoolLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            rangeLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingNavigator)).BeginInit();
            this.spellsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSpells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.nextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlDS)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 51);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(369, 51);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(36, 13);
            levelLabel.TabIndex = 5;
            levelLabel.Text = "Level:";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.Location = new System.Drawing.Point(242, 51);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new System.Drawing.Size(43, 13);
            schoolLabel.TabIndex = 7;
            schoolLabel.Text = "School:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(260, 97);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(78, 13);
            timeLabel.TabIndex = 9;
            timeLabel.Text = "Casting Action:";
            // 
            // rangeLabel
            // 
            rangeLabel.AutoSize = true;
            rangeLabel.Location = new System.Drawing.Point(133, 97);
            rangeLabel.Name = "rangeLabel";
            rangeLabel.Size = new System.Drawing.Size(42, 13);
            rangeLabel.TabIndex = 11;
            rangeLabel.Text = "Range:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(6, 97);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 13;
            durationLabel.Text = "Duration:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(9, 148);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // spellsBindingNavigator
            // 
            this.spellsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.spellsBindingNavigator.BindingSource = this.spellsBindingSource;
            this.spellsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.spellsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.spellsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.spellsBindingNavigatorSaveItem});
            this.spellsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.spellsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.spellsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.spellsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.spellsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.spellsBindingNavigator.Name = "spellsBindingNavigator";
            this.spellsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.spellsBindingNavigator.Size = new System.Drawing.Size(835, 25);
            this.spellsBindingNavigator.TabIndex = 0;
            this.spellsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // spellsBindingNavigatorSaveItem
            // 
            this.spellsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spellsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("spellsBindingNavigatorSaveItem.Image")));
            this.spellsBindingNavigatorSaveItem.Name = "spellsBindingNavigatorSaveItem";
            this.spellsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.spellsBindingNavigatorSaveItem.Text = "Save Data";
            this.spellsBindingNavigatorSaveItem.Click += new System.EventHandler(this.spellsBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(9, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // levelTextBox
            // 
            this.levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "Level", true));
            this.levelTextBox.Location = new System.Drawing.Point(372, 67);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(41, 20);
            this.levelTextBox.TabIndex = 2;
            // 
            // schoolTextBox
            // 
            this.schoolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "School", true));
            this.schoolTextBox.Location = new System.Drawing.Point(245, 67);
            this.schoolTextBox.Name = "schoolTextBox";
            this.schoolTextBox.Size = new System.Drawing.Size(121, 20);
            this.schoolTextBox.TabIndex = 1;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "Time", true));
            this.timeTextBox.Location = new System.Drawing.Point(263, 113);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(150, 20);
            this.timeTextBox.TabIndex = 5;
            // 
            // rangeTextBox
            // 
            this.rangeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "Range", true));
            this.rangeTextBox.Location = new System.Drawing.Point(136, 113);
            this.rangeTextBox.Name = "rangeTextBox";
            this.rangeTextBox.Size = new System.Drawing.Size(121, 20);
            this.rangeTextBox.TabIndex = 4;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(9, 113);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(121, 20);
            this.durationTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spellsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 164);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(401, 173);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridSpells
            // 
            this.GridSpells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSpells.Location = new System.Drawing.Point(12, 343);
            this.GridSpells.Name = "GridSpells";
            this.GridSpells.Size = new System.Drawing.Size(811, 245);
            this.GridSpells.TabIndex = 17;
            // 
            // spellsBindingSource
            // 
            //this.spellsBindingSource.DataMember = "Spells";
            //this.spellsBindingSource.DataSource = this.nextDataSet;
            //// 
            //// nextDataSet
            //// 
            //this.nextDataSet.DataSetName = "NextDataSet";
            //this.nextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            //// spellsTableAdapter
            //// 
            //this.spellsTableAdapter.ClearBeforeFill = true;
            //// 
            //// tableAdapterManager
            //// 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.CharacterTableAdapter = null;
            //this.tableAdapterManager.SpellsTableAdapter = this.spellsTableAdapter;
            //this.tableAdapterManager.UpdateOrder = CSNext.NextDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //// 
            //// xmlDS
            //// 
            //this.xmlDS.DataSetName = "xmlDS";
            // 
            // Spells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 600);
            this.Controls.Add(this.GridSpells);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(levelLabel);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(schoolLabel);
            this.Controls.Add(this.schoolTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(rangeLabel);
            this.Controls.Add(this.rangeTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.spellsBindingNavigator);
            this.Name = "Spells";
            this.Text = "Spells";
            this.Load += new System.EventHandler(this.Spells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingNavigator)).EndInit();
            this.spellsBindingNavigator.ResumeLayout(false);
            this.spellsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSpells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spellsBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.nextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource spellsBindingSource;

        private System.Windows.Forms.BindingNavigator spellsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton spellsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox schoolTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox rangeTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridSpells;
        private DataSet xmlDS;
    }
}