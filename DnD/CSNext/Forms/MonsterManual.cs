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
    public partial class MonsterManual : Form
    {
        DataSet MonsterDS = new DataSet();
        bool supress = false;
        bool searching = false;

        public MonsterManual()
        {
            InitializeComponent();
        }

        private void MonsterManual_Load(object sender, EventArgs e)
        {
            supress = true;
            MonsterDS.ReadXml("XML\\MonsterManual.xml");        
            GridMonsters.DataSource = MonsterDS.Tables[0];
            SetGrid();
            ShowMonsters(0);
            supress = false;
        }

        private void SetGrid()
        {
            supress = true;
            GridMonsters.Columns[0].Width = 150;
            GridMonsters.Columns[1].Width = 100;
            GridMonsters.Columns[2].Visible = false;
            GridMonsters.Columns[3].Width = 100;
            GridMonsters.Columns[4].Width = 200;
            GridMonsters.Columns[5].Visible = false;
            GridMonsters.Columns[6].Visible = false;
            GridMonsters.Columns[7].Visible = false;
            GridMonsters.Columns[8].Visible = false;
            GridMonsters.Columns[9].Visible = false;
            GridMonsters.Columns[10].Visible = false;
            GridMonsters.Columns[11].Width = 200;
            GridMonsters.Columns[12].Visible = false;
            GridMonsters.Columns[13].Visible = false;
            GridMonsters.Columns[14].Width = 55;
            GridMonsters.Columns[15].Width = 55;
            GridMonsters.Columns[16].Visible = false;
            supress = false;
        }

        private void GridMonsters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ShowMonsters(e.RowIndex);
            }
        }

        private void ShowMonsters(int row)
        {
            try
            {
                supress = true;
                tName.Text = GridMonsters.Rows[row].Cells[0].Value.ToString();
                tType.Text = GridMonsters.Rows[row].Cells[1].Value.ToString();
                tAC.Text = GridMonsters.Rows[row].Cells[2].Value.ToString();
                tHP.Text = GridMonsters.Rows[row].Cells[3].Value.ToString();
                tSpeed.Text = SetSpeedString(GridMonsters.Rows[row].Cells[4].Value.ToString());
                tStr.Text = GridMonsters.Rows[row].Cells[5].Value.ToString();
                tDex.Text = GridMonsters.Rows[row].Cells[6].Value.ToString();
                tCon.Text = GridMonsters.Rows[row].Cells[7].Value.ToString();
                tInt.Text = GridMonsters.Rows[row].Cells[8].Value.ToString();
                tWis.Text = GridMonsters.Rows[row].Cells[9].Value.ToString();
                tCha.Text = GridMonsters.Rows[row].Cells[10].Value.ToString();

                if (GridMonsters.Rows[row].Cells[11].Value.ToString() == "")
                    tLanguages.Text = "";
                else
                    tLanguages.Text = GridMonsters.Rows[row].Cells[11].Value.ToString();

                if (GridMonsters.Rows[row].Cells[12].Value.ToString() == "")
                    tTraits.Text = "";
                else
                    tTraits.Text = GridMonsters.Rows[row].Cells[12].Value.ToString();

                tActions.Text = GridMonsters.Rows[row].Cells[13].Value.ToString();
                cbLevel.Text = GridMonsters.Rows[row].Cells[14].Value.ToString();
                tXP.Text = GridMonsters.Rows[row].Cells[15].Value.ToString();

                if (GridMonsters.Rows[row].Cells[16].Value.ToString() == "")
                    tCustomization.Text = "";
                else
                    tCustomization.Text = GridMonsters.Rows[row].Cells[16].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                supress = false;
                searching = true;
            }
        }

        private string SetSpeedString(string s)
        {
            string speed = "";
            speed = s.Replace("Climb:", "\r\nClimb:6");
            s = speed.Replace("Senses:", "\r\nSenses:");
            speed = s.Replace("Burrow:", "\r\nBurrow:");
            s = speed.Replace("fly", "\r\nfly");
            speed = s.Replace("Tremorsense:", "\r\nTremorsense:");
        
            return speed;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            supress = true;
            cbLevel.Text = "";
            cbLevel.SelectedIndex = -1;
            supress = false;
            tName.Text = "";
            tType.Text = "";
            searching = true;
            supress = false;
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
                DataTable monsters = MonsterDS.Tables[0];
                string name = tName.Text;
                string lvl = cbLevel.SelectedIndex.ToString();
                string type = tType.Text;

                if (lvl == "-1")
                    lvl = "";
                if (name == "" && lvl == "")
                {
                    GridMonsters.DataSource = MonsterDS.Tables[0];
                    SetGrid();
                    return;
                }

                

                var search =
                    from monster in monsters.AsEnumerable()
                    where monster.Field<string>("Name").StartsWith(name, StringComparison.OrdinalIgnoreCase) &&
                    monster.Field<string>("Level").StartsWith(lvl, StringComparison.OrdinalIgnoreCase) &&
                    monster.Field<string>("Type").StartsWith(type, StringComparison.OrdinalIgnoreCase)
                    select monster;

                if (search.Any())
                {
                    DataTable result = search.CopyToDataTable<DataRow>();
                    GridMonsters.DataSource = result;
                    SetGrid();
                }
                else
                {
                    GridMonsters.DataSource = null;
                    GridMonsters.Rows.Clear();
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
