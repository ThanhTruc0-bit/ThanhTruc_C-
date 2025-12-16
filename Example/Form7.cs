using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedIndex != -1)
            {
                string item = cb_Faculty.SelectedItem.ToString();
                tbDisplay.Text = "Bạn là sinh viên khoa: " + item;
            }
            else
            {
                tbDisplay.Text = "Vui lòng chọn một khoa trước.";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = -1;
            tbDisplay.Text = string.Empty;
        }
    }
}