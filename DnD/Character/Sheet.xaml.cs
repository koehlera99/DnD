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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD.Character
{
    /// <summary>
    /// Interaction logic for Sheet.xaml
    /// </summary>
    public partial class Sheet : UserControl
    {
        public Sheet()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AbilityScores frmAbility = new AbilityScores();
            frmAbility.ShowDialog();

            //tStr.Text = frmAbility.Strength.ToString();
            //tDex.Text = frmAbility.Dexterity.ToString();
            //tCon.Text = frmAbility.Constitution.ToString();
            //tInt.Text = frmAbility.Intelligence.ToString();
            //tWis.Text = frmAbility.Wisdom.ToString();
            //tCha.Text = frmAbility.Charisma.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked!");
        }
    }
}
