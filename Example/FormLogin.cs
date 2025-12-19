using System;
using System.Windows.Forms;

namespace Example
{
    public partial class FormLogin : Form
    {
        public FormLogin() { InitializeComponent(); }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "ThanhTruc" && txtPass.Text == "123")
            {
                this.Hide();
                FormDashboard ds = new FormDashboard();
                ds.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Sai tài khoản!"); }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}