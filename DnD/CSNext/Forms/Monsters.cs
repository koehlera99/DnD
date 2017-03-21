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

namespace CSNext
{
    public partial class Monsters : Form
    {
        public Monsters()
        {
            InitializeComponent();
        }

        private void Monsters_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in GridMonsters.Columns)
            {
                col.Visible = false;
            }

            DataSet ds = new DataSet();
            ds.ReadXml("Xml//Monsters2.xml");

            GridMonsters.Rows.Clear();
            GridMonsters.DataSource = ds.Tables[0];

            //int row = -1;
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    row++;
            //    GridMonsters.Rows.Add();
            //    GridMonsters.Rows[row].Cells["colName"].Value = dr["name"].ToString();
            //    GridMonsters.Rows[row].Cells["colLevel"].Value = dr["level"].ToString();
            //    GridMonsters.Rows[row].Cells["colSchool"].Value = dr["school"].ToString();
            //    GridMonsters.Rows[row].Cells["colTime"].Value = dr["time"].ToString();
            //    GridMonsters.Rows[row].Cells["colRange"].Value = dr["range"].ToString();
            //    GridMonsters.Rows[row].Cells["colDuration"].Value = dr["duration"].ToString();
            //    GridMonsters.Rows[row].Cells["colDescription"].Value = dr["description"].ToString();

            //}
        }
    }
}
