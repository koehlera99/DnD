using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNext
{
    public partial class AbilityScores : Form
    {
        int current = 30;
        int start = 8;

        decimal before;

        decimal str;
        decimal dex;
        decimal con;
        decimal intl;
        decimal wis;
        decimal cha;

        bool supress = false;

        public int Strength
        {
            get { return Convert.ToInt32(str); }
            set { str = value; }
        }

        public int Dexterity
        {
            get { return Convert.ToInt32(dex); }
            set { dex = value; }
        }

        public int Constitution
        {
            get { return Convert.ToInt32(con); }
            set { con = value; }
        }

        public int Intelligence
        {
            get { return Convert.ToInt32(intl); }
            set { intl = value; }
        }

        public int Wisdom
        {
            get { return Convert.ToInt32(wis); }
            set { wis = value; }
        }

        public int Charisma
        {
            get { return Convert.ToInt32(cha); }
            set { cha = value; }
        }

        public AbilityScores()
        {
            InitializeComponent();
        }

        private void AbilityScores_Load(object sender, EventArgs e)
        {

        }

        private void Numeric_Enter(object sender, EventArgs e)
        {
            NumericUpDown n = (NumericUpDown)sender;
            before = n.Value;
        }

        private void ckPoint_CheckedChanged(object sender, EventArgs e)
        {
            supress = true;
            if (ckPoint.Checked)
            {
                nStr.Value = start;
                nDex.Value = start;
                nCon.Value = start;
                nInt.Value = start;
                nWis.Value = start;
                nCha.Value = start;

                nStr.ReadOnly = true;
                nDex.ReadOnly = true;
                nCon.ReadOnly = true;
                nInt.ReadOnly = true;
                nWis.ReadOnly = true;
                nCha.ReadOnly = true;


                str = start;
                dex = start;
                con = start;
                intl = start;
                wis = start;
                cha = start;

                tCurrent.Text = current.ToString();
            }
            else
            {
                nStr.Value = 0;
                nDex.Value = 0;
                nCon.Value = 0;
                nInt.Value = 0;
                nWis.Value = 0;
                nCha.Value = 0;

                nStr.ReadOnly = false;
                nDex.ReadOnly = false;
                nCon.ReadOnly = false;
                nInt.ReadOnly = false;
                nWis.ReadOnly = false;
                nCha.ReadOnly = false;
            }
            supress = false;
        }

        private int UpCalculateCurrent(int value)
        {
            int temp = current;

            switch (value)
            {
                case 9:
                    current--;
                    break;
                case 10:
                    current--;
                    break;
                case 11:
                    current--;
                    break;
                case 12:
                    current--;
                    break;
                case 13:
                    current--;
                    break;
                case 14:
                    current -= 2;
                    break;
                case 15:
                    current -= 2;
                    break;
                case 16:
                    current -= 3;
                    break;
            }
            if (current < 0)
            {
                current = temp;
                return value - 1;
            }
            else
            {
                return value;
            }
        }

        private int DownCalculateCurrent(int value)
        {
            int temp = current;

            switch (value)
            {
                case 8:
                    current++;
                    break;
                case 9:
                    current++;
                    break;
                case 10:
                    current++;
                    break;
                case 11:
                    current++;
                    break;
                case 12:
                    current++;
                    break;
                case 13:
                    current += 2;
                    break;
                case 14:
                    current += 2;
                    break;
                case 15:
                    current += 3;
                    break;
            }
            return value;
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            if (supress == false)
            {
                NumericUpDown n = (NumericUpDown)sender;

                if (n.Value > 16)
                {
                    supress = true;
                    n.Value = 16;
                    supress = false;
                    return;
                }

                if (n.Value < 8)
                {
                    supress = true;
                    n.Value =  8;
                    supress = false;
                    return;
                }

                if (n.Value > before)
                {
                    supress = true;
                    n.Value = UpCalculateCurrent(Convert.ToInt32(n.Value));
                    before = n.Value;
                    supress = false;
                }
                else
                {
                    supress = true;
                    n.Value = DownCalculateCurrent(Convert.ToInt32(n.Value));
                    before = n.Value;
                    supress = false;
                }
                if (current == 0)
                    tCurrent.ForeColor = Color.Red;
                else
                    tCurrent.ForeColor = Color.Black;

                tCurrent.Text = current.ToString();
            }

            //Sets the cost to buy another point in each particular stat
            tCostStr.Text = SetCost(nStr.Value);
            tCostDex.Text = SetCost(nDex.Value);
            tCostCon.Text = SetCost(nCon.Value);
            tCostInt.Text = SetCost(nInt.Value);
            tCostWis.Text = SetCost(nWis.Value);
            tCostCha.Text = SetCost(nCha.Value);
        }

        private string SetCost(decimal stat)
        {
            if (stat < 13)
                return "1";
            else if (stat < 15)
                return "2";
            else if (stat < 16)
                return "3";
            else
                return "Max";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = nStr.Value;
            dex = nDex.Value;
            con = nCon.Value;
            intl = nInt.Value;
            wis = nWis.Value;
            cha = nCha.Value;

            this.Close();
        }
    }
}
