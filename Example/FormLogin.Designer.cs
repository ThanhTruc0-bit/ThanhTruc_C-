namespace Example
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlBackground;
        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSub;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnClose;
        private Label lblIcon;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlBackground = new Panel();
            pnlCard = new Panel();
            lblIcon = new Label();
            lblTitle = new Label();
            lblSub = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();

            // ================= FORM =================
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(900, 550);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            // ================= BACKGROUND =================
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.BackColor = Color.FromArgb(245, 247, 255);
            Controls.Add(pnlBackground);

            // ================= CARD =================
            pnlCard.Size = new Size(420, 480);
            pnlCard.BackColor = Color.White;
            pnlCard.Location = new Point(
                (ClientSize.Width - pnlCard.Width) / 2,
                (ClientSize.Height - pnlCard.Height) / 2);
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlBackground.Controls.Add(pnlCard);

            // ================= CLOSE =================
            btnClose.Text = "✕";
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.Gray;
            btnClose.Size = new Size(40, 40);
            btnClose.Location = new Point(370, 10);
            btnClose.Click += btnClose_Click;
            pnlCard.Controls.Add(btnClose);

            // ================= ICON =================
            lblIcon.Text = "🔐";
            lblIcon.Font = new Font("Segoe UI Emoji", 40F);
            lblIcon.AutoSize = true;
            lblIcon.Location = new Point(175, 40);
            pnlCard.Controls.Add(lblIcon);

            // ================= TITLE =================
            lblTitle.Text = "Welcome Back";
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(95, 120);
            pnlCard.Controls.Add(lblTitle);

            lblSub.Text = "Login to your account";
            lblSub.Font = new Font("Segoe UI", 10F);
            lblSub.ForeColor = Color.Gray;
            lblSub.AutoSize = true;
            lblSub.Location = new Point(120, 165);
            pnlCard.Controls.Add(lblSub);

            // ================= USER =================
            lblUser.Text = "Username";
            lblUser.Location = new Point(70, 210);
            lblUser.AutoSize = true;
            pnlCard.Controls.Add(lblUser);

            txtUser.Font = new Font("Segoe UI", 11F);
            txtUser.Size = new Size(280, 32);
            txtUser.Location = new Point(70, 235);
            pnlCard.Controls.Add(txtUser);

            // ================= PASS =================
            lblPass.Text = "Password";
            lblPass.Location = new Point(70, 285);
            lblPass.AutoSize = true;
            pnlCard.Controls.Add(lblPass);

            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Size = new Size(280, 32);
            txtPass.Location = new Point(70, 310);
            txtPass.UseSystemPasswordChar = true;
            pnlCard.Controls.Add(txtPass);

            // ================= LOGIN =================
            btnLogin.Text = "LOGIN";
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.Size = new Size(280, 45);
            btnLogin.Location = new Point(70, 370);
            btnLogin.BackColor = Color.FromArgb(114, 137, 218);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            pnlCard.Controls.Add(btnLogin);
        }
    }
}
