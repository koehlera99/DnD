using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace CSNext
{
    public partial class XMLSpells : Form
    {
        public XMLSpells()
        {
            InitializeComponent();
        }

        private void XMLSpells_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Xml//Spells.xml");
                       
            GridSpells.Rows.Clear();
            int row = -1;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                row++;
                GridSpells.Rows.Add();
                GridSpells.Rows[row].Cells["colName"].Value = dr["name"].ToString();
                GridSpells.Rows[row].Cells["colLevel"].Value = dr["level"].ToString();
                GridSpells.Rows[row].Cells["colSchool"].Value = dr["school"].ToString();
                GridSpells.Rows[row].Cells["colTime"].Value = dr["time"].ToString();
                GridSpells.Rows[row].Cells["colRange"].Value = dr["range"].ToString();
                GridSpells.Rows[row].Cells["colDuration"].Value = dr["duration"].ToString();
                GridSpells.Rows[row].Cells["colDescription"].Value = dr["description"].ToString();
            }

            ShowSpells(0);
        }

        private void GridSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowSpells(e.RowIndex);
        }

        private void ShowSpells(int row)
        {
            tName.Text = GridSpells.Rows[row].Cells["colName"].Value.ToString();
            tLevel.Text = GridSpells.Rows[row].Cells["colLevel"].Value.ToString();
            tSchool.Text = GridSpells.Rows[row].Cells["colSchool"].Value.ToString();
            tTime.Text = GridSpells.Rows[row].Cells["colTime"].Value.ToString();
            tRange.Text = GridSpells.Rows[row].Cells["colRange"].Value.ToString();
            tDuration.Text = GridSpells.Rows[row].Cells["colDuration"].Value.ToString();
            tDescription.Text = GridSpells.Rows[row].Cells["colDescription"].Value.ToString();
        }
    }
}
