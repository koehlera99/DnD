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
    public partial class SpellBook : Form
    {
        DataSet SpellDS = new DataSet();
        bool supress = false;
        bool searching = false;

        public SpellBook()
        {
            InitializeComponent();
        }

        private void XMLSpells_Load(object sender, EventArgs e)
        {
            supress = true;
            SpellDS.ReadXml("XML\\Spellbook.xml");
            SetGridSpells(SpellDS.Tables[0]);          
            ShowSpells(0);
            supress = false;
        }

        private void SetGridSpells(DataTable dt)
        {
            GridSpells.Rows.Clear();
            int row = -1;

            foreach (DataRow dr in dt.Rows)
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
        }

        private void GridSpells_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowSpells(e.RowIndex);
        }

        private void ShowSpells(int row)
        {
            supress = true;
            tName.Text = GridSpells.Rows[row].Cells["colName"].Value.ToString();
            cbLevel.SelectedIndex = Convert.ToInt32(GridSpells.Rows[row].Cells["colLevel"].Value.ToString());
            cbSchool.Text = GridSpells.Rows[row].Cells["colSchool"].Value.ToString();
            tTime.Text = GridSpells.Rows[row].Cells["colTime"].Value.ToString();
            tRange.Text = GridSpells.Rows[row].Cells["colRange"].Value.ToString();
            tDuration.Text = GridSpells.Rows[row].Cells["colDuration"].Value.ToString();
            tDescription.Text = GridSpells.Rows[row].Cells["colDescription"].Value.ToString();
            supress = false;
            searching = true;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            supress = true;
            cbLevel.SelectedIndex = -1;
            cbSchool.SelectedIndex = -1;
            tTime.Text = "";
            tRange.Text = "";
            tDuration.Text = "";
            tDescription.Text = "";
            supress = false;
            tName.Text = "";
            searching = true;
        }

        private void AutoSearch(object sender, EventArgs e)
        {
            if (supress == false)
            {
                Search();
                searching = false;
            }
        }

        private void Search()
        {
            try
            {
                DataTable spells = SpellDS.Tables[0];
                string name = tName.Text;
                string lvl = cbLevel.SelectedIndex.ToString();
                string school = cbSchool.Text;
                string time = tTime.Text;
                string range = tRange.Text;
                string duration = tDuration.Text;
                string desc = tDescription.Text;

                if (lvl == "-1")
                    lvl = "";

                var search =
                    from spell in spells.AsEnumerable()
                    where spell.Field<string>("name").StartsWith(name, StringComparison.OrdinalIgnoreCase) &&
                    spell.Field<string>("school").StartsWith(school, StringComparison.OrdinalIgnoreCase) &&
                    spell.Field<string>("level").StartsWith(lvl, StringComparison.OrdinalIgnoreCase) &&
                    spell.Field<string>("time").StartsWith(time, StringComparison.OrdinalIgnoreCase) &&
                    spell.Field<string>("range").StartsWith(range, StringComparison.OrdinalIgnoreCase) &&
                    spell.Field<string>("duration").StartsWith(duration, StringComparison.OrdinalIgnoreCase)
                    select spell;

                if (search.Any())
                {
                    DataTable result = search.CopyToDataTable<DataRow>();
                    SetGridSpells(result);
                }
                else
                {
                    GridSpells.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("What the hell did you do! You caused: " + ex.Message, "You Broke it!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void tName_Enter(object sender, EventArgs e)
        {
            if (searching)
                bClear.PerformClick();
        }
    }
}
