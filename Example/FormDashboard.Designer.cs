namespace Example
{
    partial class FormDashboard
    {
        private System.Windows.Forms.Panel pnlSidebar, pnlHeader, pnlCard1, pnlCard2, pnlCard3;
        private System.Windows.Forms.Button btnNhanVien, btnDangXuat, btnHome, btnReport;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblHeader, lblLogo, lblStat1, lblStat2, lblStat3;

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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Sidebar: Màu xanh Navy đậm (Deep Dark)
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(28, 35, 49);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(250, 700);
            this.pnlSidebar.Controls.AddRange(new System.Windows.Forms.Control[] { lblLogo, btnHome, btnNhanVien, btnReport, btnDangXuat });

            this.lblLogo.Text = "💎 HR CLOUD";
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Size = new System.Drawing.Size(250, 100);

            // Menu Buttons: Bo góc nhẹ và có biểu tượng văn bản
            SetupSideBtn(btnHome, "    🏠   Bảng điều khiển", 120);
            SetupSideBtn(btnNhanVien, "    👥   Nhân sự hệ thống", 180);
            SetupSideBtn(btnReport, "    📊   Báo cáo thống kê", 240);
            btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);

            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Text = "🚪 THOÁT HỆ THỐNG";
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Height = 55;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.Click += (s, e) => this.Close();

            // Header: Trắng sạch sẽ với bóng đổ giả
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1200, 70);
            this.lblHeader.Text = "Chào mừng trở lại, Thanh Trúc!";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 15F);
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(30, 20);
            this.lblHeader.Size = new System.Drawing.Size(500, 35);
            this.pnlHeader.Controls.Add(lblHeader);

            // Thẻ Card Thống kê (Web Dashboard Style)
            CreateCard(pnlCard1, lblStat1, "TỔNG NHÂN VIÊN", "10", System.Drawing.Color.FromArgb(52, 152, 219), 280);
            CreateCard(pnlCard2, lblStat2, "TUYỂN DỤNG MỚI", "5", System.Drawing.Color.FromArgb(155, 89, 182), 520);
            CreateCard(pnlCard3, lblStat3, "NGÂN SÁCH LƯƠNG", "$45,000", System.Drawing.Color.FromArgb(46, 204, 113), 760);

            // Bảng DataGridView: Tối giản hoàn toàn
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.Location = new System.Drawing.Point(280, 240);
            this.dgvMain.Size = new System.Drawing.Size(890, 420);
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.GridColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.dgvMain.ColumnHeadersHeight = 45;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form Settings
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { pnlCard1, pnlCard2, pnlCard3, dgvMain, pnlHeader, pnlSidebar });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "HR Cloud Dashboard Management";
        }

        private void SetupSideBtn(System.Windows.Forms.Button btn, string text, int y)
        {
            btn.Text = text;
            btn.Size = new System.Drawing.Size(250, 55);
            btn.Location = new System.Drawing.Point(0, y);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = System.Drawing.Color.FromArgb(160, 174, 192);
            btn.Font = new System.Drawing.Font("Segoe UI", 11F);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void CreateCard(System.Windows.Forms.Panel p, System.Windows.Forms.Label l, string title, string val, System.Drawing.Color c, int x)
        {
            p.BackColor = System.Drawing.Color.White;
            p.Location = new System.Drawing.Point(x, 100);
            p.Size = new System.Drawing.Size(220, 110);
            l.Text = title + "\n" + val;
            l.Dock = System.Windows.Forms.DockStyle.Fill;
            l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            l.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            l.ForeColor = c;
            p.Controls.Add(l);
        }
    }
}