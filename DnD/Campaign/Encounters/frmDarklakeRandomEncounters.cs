using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD.OOTA
{
    public partial class frmDarklakeRandomEncounters : Form
    {
        DataTable dtEncounters;

        public frmDarklakeRandomEncounters()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtEncounters = new DataTable();
            dtEncounters.TableName = "Encounters";
            dtEncounters.Columns.Add(new DataColumn("Day", System.Type.GetType("System.Int32")));
            dtEncounters.Columns.Add(new DataColumn("Hour", System.Type.GetType("System.Int32")));
            dtEncounters.Columns.Add(new DataColumn("Roll", System.Type.GetType("System.Int32")));
            dtEncounters.Columns.Add(new DataColumn("Creature", System.Type.GetType("System.String")));
            dtEncounters.Columns.Add(new DataColumn("Location", System.Type.GetType("System.String")));
            dtEncounters.Columns.Add(new DataColumn("CreatureDescription", System.Type.GetType("System.String")));
            dtEncounters.Columns.Add(new DataColumn("TerrainDescription", System.Type.GetType("System.String")));
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            dtEncounters.Rows.Clear();

            DarkLakeEncounters dl = new DarkLakeEncounters();

            Random r = new Random();
            int numHour;
            int hour;

            if (chkHour.Checked)
                hour = 4;
            else
                hour = 1;

            numHour = hour;

            int day = 1;

            int rolls = Convert.ToInt32(numRolls.Value);
            int d20;

            int terrain;
            int creature;

            if (rdHours.Checked)
                rolls /= hour;
            else if (rdDays.Checked)
                rolls *= (24 / hour);

            for(int i = 1; i <= rolls; i++)
            {
                d20 = r.Next(1, 20);
                DataRow row = dtEncounters.NewRow();

                terrain = r.Next(1, 10);
                creature = r.Next(1, 12);

                if (d20 >= 1 && d20 <= 13)
                {
                    row["Roll"] = d20;
                    row["Creature"] = DBNull.Value;
                    row["Location"] = DBNull.Value;
                    row["CreatureDescription"] = DBNull.Value;
                    row["TerrainDescription"] = DBNull.Value;
                }
                else if (d20 >= 14 && d20 <= 15)
                {
                    row["Roll"] = d20;
                    row["Creature"] = DBNull.Value;
                    row["Location"] = dl.TerrainEncounter.Encounter[terrain];
                    row["CreatureDescription"] = DBNull.Value;
                    row["TerrainDescription"] = dl.TerrainEncounter.Description[terrain];
                }
                else if (d20 >= 16 && d20 <= 17)
                {
                    row["Roll"] = d20;
                    row["Creature"] = dl.CreatureEncounter.Encounter[creature];
                    row["Location"] = DBNull.Value;
                    row["CreatureDescription"] = dl.CreatureEncounter.Description[creature];
                    row["TerrainDescription"] = DBNull.Value;
                }
                else if (d20 >= 18 && d20 <= 20)
                {
                    row["Roll"] = d20;
                    row["Creature"] = dl.CreatureEncounter.Encounter[creature];
                    row["Location"] = dl.TerrainEncounter.Encounter[terrain]; ;
                    row["CreatureDescription"] = dl.CreatureEncounter.Description[creature];
                    row["TerrainDescription"] = dl.TerrainEncounter.Description[terrain];
                }
                else
                    MessageBox.Show("Error");

                row["Day"] = day;
                row["Hour"] = numHour;

                if(numHour == 24)
                {
                    numHour = 0;
                    day++;
                }

                numHour += hour;
                dtEncounters.Rows.Add(row);
            }

            GridEncounters.AutoGenerateColumns = false;
            GridEncounters.DataSource = dtEncounters;
        }

        private void chkHour_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHour.Checked)
                gbRoll.Text = "Every 4 Hours";
            else
                gbRoll.Text = "Every Hour";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtEncounters.WriteXml("Encounters.xml");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Encounters.xml");
            dtEncounters = ds.Tables[0];

            GridEncounters.AutoGenerateColumns = false;
            GridEncounters.DataSource = dtEncounters;
        }

        private void GridEncounters_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(GridEncounters.SelectedRows.Count > 0)
            {
                int index = GridEncounters.SelectedRows[0].Index;

                txtCreature.Text = dtEncounters.Rows[index]["CreatureDescription"].ToString();
                txtTerrain.Text = dtEncounters.Rows[index]["TerrainDescription"].ToString();
            }
        }

        private void underToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDarklakeRandomEncounters f = new frmDarklakeRandomEncounters();
            f.Show();
        }
    }
}
