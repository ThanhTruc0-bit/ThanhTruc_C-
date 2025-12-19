namespace Example
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlBlue;
        private System.Windows.Forms.TextBox txtUser, txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitle, lblUser, lblPass, lblLogo;

        private void InitializeComponent()
        {
            pnlBlue = new Panel();
            lblLogo = new Label();
            lblTitle = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblUser = new Label();
            lblPass = new Label();
            pnlBlue.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBlue
            // 
            pnlBlue.BackColor = Color.FromArgb(41, 128, 185);
            pnlBlue.Controls.Add(lblLogo);
            pnlBlue.Dock = DockStyle.Left;
            pnlBlue.Location = new Point(0, 0);
            pnlBlue.Name = "pnlBlue";
            pnlBlue.Size = new Size(300, 450);
            pnlBlue.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(300, 450);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "WELCOME\nHR SYSTEM";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(350, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "LOGIN";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(350, 160);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(320, 34);
            txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(350, 235);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(320, 34);
            txtPass.TabIndex = 5;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(350, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 50);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN NOW";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(350, 135);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 23);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.Location = new Point(350, 210);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 23);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // FormLogin
            // 
            ClientSize = new Size(730, 450);
            Controls.Add(pnlBlue);
            Controls.Add(lblTitle);
            Controls.Add(lblUser);
            Controls.Add(txtUser);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogin_Load;
            pnlBlue.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}