using System;
using System.ComponentModel;
using System.Windows.Forms;

// Thêm các thư viện cần thiết khác (System.Drawing, System.Data, v.v. nếu cần)
// using System.Drawing; 
// using System.Data; 

namespace Example
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbYear.Text))
            {
                return;
            }

            int year = int.Parse(tbYear.Text);

            if (year > 2000)
            {
                e.Cancel = true;

                MessageBox.Show("Năm không được lớn hơn 2000.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);

         
                tbYear.SelectAll();
            }
        }
    }
}