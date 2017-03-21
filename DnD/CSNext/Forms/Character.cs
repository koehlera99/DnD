using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSNext
{
    public partial class Character : Form
    {
        private decimal str;
        private decimal dex;
        private decimal con;
        private decimal wis;
        private decimal intl;
        private decimal cha;

        private decimal rstr;
        private decimal rdex;
        private decimal rcon;
        private decimal rwis;
        private decimal rintl;
        private decimal rcha;

        private decimal ostr;
        private decimal odex;
        private decimal ocon;
        private decimal owis;
        private decimal ointl;
        private decimal ocha;

        const Decimal ten = 10;
        const Decimal two = 2;

        int[] levels = new int[20] {0, 250, 950, 2250, 4750, 9500, 16000, 25000, 38000, 56000, 77000, 96000, 120000, 150000, 190000, 
            230000, 280000, 330000, 390000, 460000};


        public Character()
        {
            InitializeComponent();
        }

        private void Character_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nextDataSet.Sheet' table. You can move, or remove it, as needed.
            //this.characterTableAdapter.Fill(this.nextDataSet.Sheet);

        }

        private void Stat_TextChanged(object sender, EventArgs e)
        {
            //Stat formula - (s - 10) / 2
            try
            {

                if (strBaseTextBox.Text != "" && strBaseTextBox.Text != "-")
                {
                    if (tStrR.Text != "")
                        rstr = Convert.ToDecimal(tStrR.Text);
                    if (strMiscTextBox.Text != "" && strMiscTextBox.Text != "-")
                        ostr = Convert.ToDecimal(strMiscTextBox.Text);
                    str = rstr + ostr + Convert.ToDecimal(strBaseTextBox.Text);
                    tStrB.Text = Decimal.Floor(((str - ten) / two)).ToString();
                    tStrT.Text = str.ToString();
                }

                if (dexBaseTextBox.Text != "" && dexBaseTextBox.Text != "-")
                {
                    if (tDexR.Text != "")
                        rdex = Convert.ToDecimal(tDexR.Text);
                    if (dexMiscTextBox.Text != "" && dexMiscTextBox.Text != "-")
                        odex = Convert.ToDecimal(dexMiscTextBox.Text);
                    dex = rdex + odex + Convert.ToDecimal(dexBaseTextBox.Text);
                    tDexB.Text = Decimal.Floor(((dex - ten) / two)).ToString();
                    tDexT.Text = dex.ToString();
                }

                if (conBaseTextBox.Text != "" && conBaseTextBox.Text != "-")
                {
                    if (tConR.Text != "")
                        rcon = Convert.ToDecimal(tConR.Text);
                    if (conMiscTextBox.Text != "" && conMiscTextBox.Text != "-")
                        ocon = Convert.ToDecimal(conMiscTextBox.Text);
                    con = rcon + ocon + Convert.ToDecimal(conBaseTextBox.Text);
                    tConB.Text = Decimal.Floor(((con - ten) / two)).ToString();
                    tConT.Text = con.ToString();
                }

                if (wisBaseTextBox.Text != "" && wisBaseTextBox.Text != "-")
                {
                    if (tWisR.Text != "")
                        rwis = Convert.ToDecimal(tWisR.Text);
                    if (wisMiscTextBox.Text != "" && wisMiscTextBox.Text != "-")
                        owis = Convert.ToDecimal(wisMiscTextBox.Text);
                    wis = rwis + owis + Convert.ToDecimal(wisBaseTextBox.Text);
                    tWisB.Text = Decimal.Floor(((wis - ten) / two)).ToString();
                    tWisT.Text = wis.ToString();
                }

                if (intBaseTextBox.Text != "" && intBaseTextBox.Text != "-")
                {
                    if (tIntR.Text != "")
                        rintl = Convert.ToDecimal(tIntR.Text);
                    if (intMiscTextBox.Text != "" && intMiscTextBox.Text != "-")
                        ointl = Convert.ToDecimal(intMiscTextBox.Text);
                    intl = rintl + ointl + Convert.ToDecimal(intBaseTextBox.Text);
                    tIntB.Text = Decimal.Floor(((intl - ten) / two)).ToString();
                    tIntT.Text = intl.ToString();
                }

                if (chaBaseTextBox.Text != "" && chaBaseTextBox.Text != "-")
                {
                    if (tChaR.Text != "")
                        rcha = Convert.ToDecimal(tChaR.Text);
                    if (chaMiscTextBox.Text != "" && chaMiscTextBox.Text != "-")
                        ocha = Convert.ToDecimal(chaMiscTextBox.Text);
                    cha = rcha + ocha + Convert.ToDecimal(chaBaseTextBox.Text);
                    tChaB.Text = Decimal.Floor(((cha - ten) / two)).ToString();
                    tChaT.Text = cha.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            tStrR.Text = "";
            tDexR.Text = "";
            tConR.Text = "";
            tIntR.Text = "";
            tWisR.Text = "";
            tChaR.Text = "";
            raceTextBox.Text = this.cbRace.Text;

            switch (this.cbRace.Text)
            {
                case "Dwarf":
                    tConR.Text = "1";
                    break;
                case "Dwarf - Hill":
                    tStrR.Text = "1";
                    break;
                case "Dwarf - Mountain":
                    tStrR.Text = "1";
                    break;
                case "Elf":
                    tDexR.Text = "1";
                    break;
                case "Elf - High":
                    tIntR.Text = "1";
                    break;
                case "Elf - Wood":
                    tWisR.Text = "1";
                    break;
                case "Hafling":
                    tDexR.Text = "1";
                    break;
                case "Halfing - Light Foot":
                    tChaR.Text = "1";
                    break;
                case "Hafling - Stout":
                    tConR.Text = "1";
                    break;
                case "Human":
                    tStrR.Text = "1";
                    tDexR.Text = "1";
                    tConR.Text = "1";
                    tIntR.Text = "1";
                    tWisR.Text = "1";
                    tChaR.Text = "1";
                    break;
                case "Dragonborn":
                    tStrR.Text = "1";
                    tChaR.Text = "1";
                    break;
                case "Drow":
                    tDexR.Text = "1";
                    tChaR.Text = "1";
                    break;
                case "Gnome":
                    tIntR.Text = "1";
                    break;
                case "Gnome - Forest":
                    tDexR.Text = "1";
                    break;
                case "Gnome - Rock":
                    tConR.Text = "1";
                    break;
                case "Half-Elf":
                    tChaR.Text = "1";
                    break;
                case "Half-Orc":
                    tStrR.Text = "2";
                    tConR.Text = "1";
                    break;
                case "Kender":
                    tDexR.Text = "1";
                    tChaR.Text = "1";
                    break;
                case "Tiefling":
                    tIntR.Text = "1";
                    tChaR.Text = "1";
                    break;
                case "Warforged":
                    tStrR.Text = "1";
                    tConR.Text = "1";
                     break;
            }
            Stat_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var frmx = new AddXP())
            {
                int x;

                var result = frmx.ShowDialog();
                if (result == DialogResult.OK)
                {
                    x = frmx.XP;
                    if (xPTextBox.Text == "")
                        xPTextBox.Text = x.ToString();
                    else
                        xPTextBox.Text = (x + int.Parse(xPTextBox.Text)).ToString();

                    int lvl = int.Parse(xPTextBox.Text);
                    int i;
                    for (i = 0; i < 19; i++)
                    {
                        if (lvl >= levels[i] && lvl < levels[i+1])
                        {
                            levelTextBox.Text = (i + 1).ToString();
                            tNextLevel.Text = levels[i + 1].ToString();
                        }
                    }
                    if (i == 19 && lvl >= levels[i])
                    {
                        levelTextBox.Text = (i + 1).ToString();
                        tNextLevel.Text = "Max Level";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            XDocument spells = XDocument.Load("Spells.xml");
            descriptionTextBox.Text = spells.ToString();
            

        }

        private void characterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.characterBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nextDataSet);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void raceTextBox_TextChanged(object sender, EventArgs e)
        {
            cbRace.SelectedItem = raceTextBox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
