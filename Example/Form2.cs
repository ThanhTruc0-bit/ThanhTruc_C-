using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Text = "Article for Button";
            this.Size = new Size(500, 500);
        }
    }
}