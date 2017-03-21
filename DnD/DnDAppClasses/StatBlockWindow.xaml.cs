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
using DnD.XML.Serialized;

namespace DnD.NPC
{
    /// <summary>
    /// Interaction logic for StatBlockWindow.xaml
    /// </summary>
    public partial class StatBlockWindow : Window
    {
        public MonsterCompendium Compendium { get; set; }
        public Monster Monster { get; set; }
        public int ItemNumber { get; set; }
        public string AC { get; set; } = "AC3";

        public StatBlockWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            
            lblMonsterName.Content = Monster.Name;
            lblMonsterType.Content = Monster.Type;

            lblAC.Content = Monster.AC;
            lblHP.Content = Monster.HP;
            lblSpeed.Content = Monster.Speed;

            lblStr.Content = Monster.Strength;
            lblDex.Content = Monster.Dexterity;
            lblCon.Content = Monster.Constitution;

            lblInt.Content = Monster.Intelligence;
            lblWis.Content = Monster.Wisdom;
            lblCha.Content = Monster.Charisma;

        }
    }
}
