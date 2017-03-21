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
using System.Xml.Serialization;

namespace CSNext
{
    public partial class fPlayerCharacter : Form
    {
        public fPlayerCharacter()
        {
            InitializeComponent();
        }
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


        private void Character_Load(object sender, EventArgs e)
        {

        }

        private void CalculateStats()
        {
            //Stat formula - (s - 10) / 2
            try
            {

                if (tStr.Text != "" && tStr.Text != "-")
                {
                    if (tStrR.Text != "")
                        rstr = Convert.ToDecimal(tStrR.Text);
                    if (tMiscStr.Text != "" && tMiscStr.Text != "-")
                        ostr = Convert.ToDecimal(tMiscStr.Text);
                    str = rstr + ostr + Convert.ToDecimal(tStr.Text);
                    tStrB.Text = Decimal.Floor(((str - ten) / two)).ToString();
                    tStrT.Text = str.ToString();
                }

                if (tDex.Text != "" && tDex.Text != "-")
                {
                    if (tDexR.Text != "")
                        rdex = Convert.ToDecimal(tDexR.Text);
                    if (tMiscDex.Text != "" && tMiscDex.Text != "-")
                        odex = Convert.ToDecimal(tMiscDex.Text);
                    dex = rdex + odex + Convert.ToDecimal(tDex.Text);
                    tDexB.Text = Decimal.Floor(((dex - ten) / two)).ToString();
                    tDexT.Text = dex.ToString();
                }

                if (tCon.Text != "" && tCon.Text != "-")
                {
                    if (tConR.Text != "")
                        rcon = Convert.ToDecimal(tConR.Text);
                    if (tMiscCon.Text != "" && tMiscCon.Text != "-")
                        ocon = Convert.ToDecimal(tMiscCon.Text);
                    con = rcon + ocon + Convert.ToDecimal(tCon.Text);
                    tConB.Text = Decimal.Floor(((con - ten) / two)).ToString();
                    tConT.Text = con.ToString();
                }

                if (tWis.Text != "" && tWis.Text != "-")
                {
                    if (tWisR.Text != "")
                        rwis = Convert.ToDecimal(tWisR.Text);
                    if (tMiscWis.Text != "" && tMiscWis.Text != "-")
                        owis = Convert.ToDecimal(tMiscWis.Text);
                    wis = rwis + owis + Convert.ToDecimal(tWis.Text);
                    tWisB.Text = Decimal.Floor(((wis - ten) / two)).ToString();
                    tWisT.Text = wis.ToString();
                }

                if (tInt.Text != "" && tInt.Text != "-")
                {
                    if (tIntR.Text != "")
                        rintl = Convert.ToDecimal(tIntR.Text);
                    if (tMiscInt.Text != "" && tMiscInt.Text != "-")
                        ointl = Convert.ToDecimal(tMiscInt.Text);
                    intl = rintl + ointl + Convert.ToDecimal(tInt.Text);
                    tIntB.Text = Decimal.Floor(((intl - ten) / two)).ToString();
                    tIntT.Text = intl.ToString();
                }

                if (tCha.Text != "" && tCha.Text != "-")
                {
                    if (tChaR.Text != "")
                        rcha = Convert.ToDecimal(tChaR.Text);
                    if (tMiscCha.Text != "" && tMiscCha.Text != "-")
                        ocha = Convert.ToDecimal(tMiscCha.Text);
                    cha = rcha + ocha + Convert.ToDecimal(tCha.Text);
                    tChaB.Text = Decimal.Floor(((cha - ten) / two)).ToString();
                    tChaT.Text = cha.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Stat_TextChanged(object sender, EventArgs e)
        {
            CalculateStats();
        }

        private void Stat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void CalculateStatsAll()
        {
            tStrR.Text = "";
            tDexR.Text = "";
            tConR.Text = "";
            tIntR.Text = "";
            tWisR.Text = "";
            tChaR.Text = "";
            cbRace.Text = this.cbRace.Text;

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

            CalculateStats();
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateStatsAll();
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
                    if (tTotalXP.Text == "")
                        tTotalXP.Text = x.ToString();
                    else
                        tTotalXP.Text = (x + int.Parse(tTotalXP.Text)).ToString();

                    int lvl = int.Parse(tTotalXP.Text);
                    int i;
                    for (i = 0; i < 19; i++)
                    {
                        if (lvl >= levels[i] && lvl < levels[i + 1])
                        {
                            tLevel.Text = (i + 1).ToString();
                            tNextLevel.Text = levels[i + 1].ToString();
                        }
                    }
                    if (i == 19 && lvl >= levels[i])
                    {
                        tLevel.Text = (i + 1).ToString();
                        tNextLevel.Text = "Max Level";
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbRace_TextChanged(object sender, EventArgs e)
        {
            cbRace.SelectedItem = cbRace.Text;
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCharacterDiag.FileName = tName.Text;
                SaveCharacterDiag.Filter = "XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                DialogResult result = SaveCharacterDiag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Characters c = new Characters();
                    GetCharacterData(c);
                    string filename = SaveCharacterDiag.FileName;

                    XmlSerializer xml = new XmlSerializer(typeof(Characters));
                    using (Stream fstream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        xml.Serialize(fstream, c);
                    }

                    MessageBox.Show("File Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenCharacterDiag.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = OpenCharacterDiag.FileName;
                XmlSerializer xml = new XmlSerializer(typeof(Characters));

                Characters c;
                using (Stream fstream = new FileStream(filename, FileMode.Open))
                {
                    c = (Characters)xml.Deserialize(fstream);
                }

                SetCharacterData(c);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetCharacterData(Characters c)
        {
            c.name = tName.Text;
            c.cclass = tClass.Text;
            c.race = cbRace.SelectedText;
            c.level = tLevel.Text;
            c.totalxp = tTotalXP.Text;
            c.background = tBackground.Text;
            c.flaws = tFlaws.Text;
            c.bonds = tBonds.Text;
            c.ideals = tIdeals.Text;
            c.religion = tReligion.Text;
            c.Alignment = tAlignment.Text;
            c.profession = tProfession.Text;
            c.size = tSize.Text;
            c.height = tHeight.Text;
            c.weight = tWeight.Text;
            c.hair = tHair.Text;
            c.eyes = tEyes.Text;
            c.age = tAge.Text;
            c.gender = tGender.Text;
            c.description = tDescription.Text;
            c.languages = tLanguages.Text;

            c.str = tStr.Text;
            c.intl = tInt.Text;
            c.wis = tWis.Text;
            c.con = tCon.Text;
            c.dex = tDex.Text;
            c.cha = tCha.Text;

            c.mstr = tMiscStr.Text;
            c.mdex = tMiscDex.Text;
            c.mcon = tMiscCon.Text;
            c.mintl = tMiscInt.Text;
            c.mwis = tMiscWis.Text;
            c.mcha = tMiscCha.Text;
        }

        private void SetCharacterData(Characters c)
        {
            tName.Text = c.name;
            tClass.Text = c.cclass;
            cbRace.SelectedText = c.race;
            tLevel.Text = c.level;
            tTotalXP.Text = c.totalxp;
            tBackground.Text = c.background;
            tFlaws.Text = c.flaws;
            tBonds.Text = c.bonds;
            tIdeals.Text = c.ideals;
            tReligion.Text = c.religion;
            tAlignment.Text = c.Alignment;
            tProfession.Text = c.profession;
            tSize.Text = c.size;
            tHeight.Text = c.height;
            tWeight.Text = c.weight;
            tHair.Text = c.hair;
            tEyes.Text = c.eyes;
            tAge.Text = c.age;
            tGender.Text = c.gender;
            tDescription.Text = c.description;
            tLanguages.Text = c.languages;

            tStr.Text = c.str;
            tInt.Text = c.intl;
            tWis.Text = c.wis;
            tCon.Text = c.con;
            tDex.Text = c.dex;
            tCha.Text = c.cha;

            tMiscStr.Text = c.mstr;
            tMiscDex.Text = c.mdex;
            tMiscCon.Text = c.mcon;
            tMiscInt.Text = c.mintl;
            tMiscWis.Text = c.mwis;
            tMiscCha.Text = c.mcha;

            CalculateStatsAll();
        }

        private void addXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmx = new AddXP())
            {
                int x;

                var result = frmx.ShowDialog();
                if (result == DialogResult.OK)
                {
                    x = frmx.XP;
                    if (tTotalXP.Text == "")
                        tTotalXP.Text = x.ToString();
                    else
                        tTotalXP.Text = (x + int.Parse(tTotalXP.Text)).ToString();

                    int lvl = int.Parse(tTotalXP.Text);
                    int i;
                    for (i = 0; i < 19; i++)
                    {
                        if (lvl >= levels[i] && lvl < levels[i + 1])
                        {
                            tLevel.Text = (i + 1).ToString();
                            tNextLevel.Text = levels[i + 1].ToString();
                        }
                    }
                    if (i == 19 && lvl >= levels[i])
                    {
                        tLevel.Text = (i + 1).ToString();
                        tNextLevel.Text = "Max Level";
                    }
                }
            }
        }

        private void abilityScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbilityScores frmAbility = new AbilityScores();
            frmAbility.ShowDialog();

            tStr.Text = frmAbility.Strength.ToString();
            tDex.Text = frmAbility.Dexterity.ToString();
            tCon.Text = frmAbility.Constitution.ToString();
            tInt.Text = frmAbility.Intelligence.ToString();
            tWis.Text = frmAbility.Wisdom.ToString();
            tCha.Text = frmAbility.Charisma.ToString();
        }

        private void fPlayerCharacter_Load(object sender, EventArgs e)
        {

        }
    }
}
