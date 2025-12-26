using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "ThanhTruc" && txtPass.Text == "123")
            {
                this.Hide();
                FormDashboard f = new FormDashboard();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Sai tài khoản hoặc mật khẩu",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(88, 101, 242);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(114, 137, 218);
        }
    }
}
