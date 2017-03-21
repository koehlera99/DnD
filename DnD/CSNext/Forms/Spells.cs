using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


namespace CSNext
{
    public partial class Spells : Form
    {
        public Spells()
        {
            InitializeComponent();
        }

        private void spellsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            

            this.Validate();
            this.spellsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nextDataSet);

        }

        private void Spells_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nextDataSet.Spells' table. You can move, or remove it, as needed.
            //this.spellsTableAdapter.Fill(this.nextDataSet.Spells);

            string filePath = "Spells.xml";

            DataSet ds = new DataSet();
            ds.ReadXml(filePath);

            GridSpells.DataSource = ds;
            GridSpells.DataMember = "spell";

            xmlDS.ReadXml("Spells.xml");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "Spells.xml";

            DataSet ds = new DataSet();
            ds.ReadXml(filePath);

            GridSpells.DataSource = ds;
            GridSpells.DataMember = "spell";

            

        }
    }
}
