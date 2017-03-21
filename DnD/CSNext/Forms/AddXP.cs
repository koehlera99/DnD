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


    public partial class AddXP : Form
    {
        private int xp;
        public int XP
        {
            get { return xp; }
        }

        public AddXP()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = 0;
                int x2 = 0;
                int x3 = 0;
                int x4 = 0;
                int x5 = 0;

                if (tXP1.Text != "")
                    x1 = int.Parse(tXP1.Text);
                if (tXP2.Text != "")
                    x2 = int.Parse(tXP2.Text);
                if (tXP3.Text != "")
                    x3 = int.Parse(tXP3.Text);
                if (tXP4.Text != "")
                    x4 = int.Parse(tXP4.Text);
                if (tXP5.Text != "")
                    x5 = int.Parse(tXP5.Text);

                xp = x1 + x2 + x3 + x4 + x5;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void XP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
