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
using System.Data;
using DnD.XML;
using DnD.XML.Serialized;

namespace DnD.NPC
{
    /// <summary>
    /// Interaction logic for Monsters.xaml
    /// </summary>
    public partial class Monsters : Window
    {
        public MonsterCompendium MonsterList { get; set; }

        public Monsters()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "DnDAppFiles\\Bestiary\\";
            LoadXML(path);
        }

        private void LoadXML(string folder = "")
        {
            MonsterList = MonsterReadWrite.GetMonsterData();
            GridMonster.ItemsSource = MonsterList.Monsters;
        }

        //private void LoadXML()
        //{
        //    DataSet ds = new DataSet();
        //    ds.ReadXml("C:\\File\\Volo.xml");
        //    ds.ReadXml("C:\\File\\CoS.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\HotDQ.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\MM.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\OOTA.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\PB.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\PoA.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\RoT.xml", XmlReadMode.Fragment);
        //    ds.ReadXml("C:\\File\\SKT.xml", XmlReadMode.Fragment);

        //    ds.Tables["monster"].DefaultView.Sort = "name";
        //    int ct = ds.Tables.Count;
        //    ct = ds.Tables["monster"].DefaultView.Count;

        //    GridMonster.ItemsSource = ds.Tables["monster"].DefaultView;
        //}

        private void chkDetails_Click(object sender, RoutedEventArgs e)
        {
            if(chkDetails.IsChecked == true)
                GridMonster.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Visible;
            else
                GridMonster.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.VisibleWhenSelected;
        }
    }
}
