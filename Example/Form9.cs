using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            tbDiscount.Enabled = ckDiscount.Checked;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            
            if (rbMale.Checked == true)
            {
                msg += "Ông ";
            }
            else if (rbFemale.Checked == true) 
            {
                msg += "Bà ";
            }

            if (ckDiscount.Checked == true)
            {
                disc = 5;

            }

            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";

        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
            {
                tbDiscount.Enabled = true;
            }
            else
            {
                tbDiscount.Enabled = false;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}