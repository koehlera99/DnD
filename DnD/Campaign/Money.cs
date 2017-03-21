using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DnD.Campaign
{
    class Money
    {
        public int Platinum { get; set; }
        public int Gold { get; set; }
        public int Electrum { get; set; }
        public int Silver { get; set; }
        public int Copper { get; set; }

        public Money() { }

        public Money(int gold)
        {
            Gold = gold;
        }

        public Money(int platinum, int gold, int electrum, int silver, int copper)
        {
            Platinum = platinum;
            Gold = gold;
            Electrum = electrum;
            Silver = silver;
            Copper = copper;
        }

        public void SaveMoney()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConnection))
                {
                    string sql = "INSERT INTO tblMoney(Platinum, Gold, Electrum, Silver, Copper) ";
                    sql += "VALUES (" + Platinum.ToString() + ", " + Gold.ToString() + ", " + Electrum.ToString() + ", " + Silver.ToString() + ", " + Copper.ToString() +  ")";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Close();
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {

            }
        }

        public static int GetMoney()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConnection))
            {
                string getSQL = "SELECT * FROM tblMoney";
                SqlCommand cmdGet = new SqlCommand(getSQL, con);

                SqlDataAdapter da = new SqlDataAdapter(cmdGet);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int gold = 0;

                foreach (DataRow r in dt.Rows)
                {
                    gold += (int)r["Gold"];
                }

                return gold;
            }
        }
    }
}
