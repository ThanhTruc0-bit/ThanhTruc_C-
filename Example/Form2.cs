using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}