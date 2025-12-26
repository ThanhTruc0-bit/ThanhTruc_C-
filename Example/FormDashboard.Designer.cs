namespace Example
{
    partial class FormDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard3;

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnDangXuat;

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat3;

        private System.Windows.Forms.DataGridView dgvMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();

            this.btnHome = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();

            this.lblLogo = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();

            this.dgvMain = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();

            // ===== SIDEBAR =====
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(20, 25, 40);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 250;

            // Logo
            this.lblLogo.Text = "HR CLOUD";
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Height = 100;

            // Buttons
            SetupSideBtn(this.btnHome, "🏠  Trang chủ", 120);
            SetupSideBtn(this.btnNhanVien, "👥  Quản lý nhân viên", 180);
            SetupSideBtn(this.btnReport, "📊  Báo cáo", 240);

            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);

            this.btnDangXuat.Text = "🚪  Đăng xuất";
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Height = 55;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;

            this.pnlSidebar.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                btnDangXuat, btnReport, btnNhanVien, btnHome, lblLogo
            });

            // ===== HEADER =====
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;

            this.lblHeader.Text = "Chào mừng bạn quay lại 👋";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(270, 22); // FIX CHE CHỮ

            this.pnlHeader.Controls.Add(this.lblHeader);

            // ===== CARDS =====
            CreateCard(this.pnlCard1, this.lblStat1, "TỔNG NHÂN VIÊN", "10", 280);
            CreateCard(this.pnlCard2, this.lblStat2, "TUYỂN MỚI", "5", 520);
            CreateCard(this.pnlCard3, this.lblStat3, "NGÂN SÁCH", "$45,000", 760);

            // ===== GRID =====
            this.dgvMain.Location = new System.Drawing.Point(280, 240);
            this.dgvMain.Size = new System.Drawing.Size(890, 420);
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeight = 40;

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                pnlCard1, pnlCard2, pnlCard3,
                dgvMain, pnlHeader, pnlSidebar
            });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Text = "HR Dashboard";

            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
        }

        private void SetupSideBtn(System.Windows.Forms.Button btn, string text, int top)
        {
            btn.Text = text;
            btn.Width = 250;
            btn.Height = 55;
            btn.Top = top;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            btn.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        private void CreateCard(System.Windows.Forms.Panel panel, System.Windows.Forms.Label lbl, string title, string value, int left)
        {
            panel.BackColor = System.Drawing.Color.White;
            panel.Size = new System.Drawing.Size(220, 110);
            panel.Location = new System.Drawing.Point(left, 100);

            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lbl.Text = title + "\n" + value;

            panel.Controls.Add(lbl);
        }
    }
}
