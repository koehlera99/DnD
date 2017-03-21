using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace DnD.Campaign
{
    /// <summary>
    /// Interaction logic for CampaignManager.xaml
    /// </summary>
    public partial class CampaignManager : Window
    {
        public CampaignManager()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtGoldTotal.Text = Money.GetMoney().ToString();

            //using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConnection))
            //{
            //    string sql = "INSERT INTO tblMoney (Gold) VALUES (10)";
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    con.Close();
            //    cmd.Connection.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();

            //    string getSQL = "SELECT * FROM tblMoney";
            //    SqlCommand cmdGet = new SqlCommand(getSQL, con);

            //    SqlDataAdapter da = new SqlDataAdapter(cmdGet);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    int gold = 0;

            //    foreach(DataRow r in dt.Rows)
            //    {
            //        gold += (int)r["Gold"];
            //    }

            //    MessageBox.Show("Gold: " + gold.ToString());
            //}
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int gold;

            if(Int32.TryParse(txtGold.Text, out gold))
            {
                Money m = new Campaign.Money(gold);
                m.SaveMoney();
                txtGold.Text = string.Empty;
                
               // MessageBox.Show("Gold: " + Money.GetMoney().ToString());
            }

            txtGoldTotal.Text = Money.GetMoney().ToString();





        }
    }
}
