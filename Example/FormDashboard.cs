using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class FormDashboard : Form
    {
        private FormQL formQL; // giữ FormQL để lấy dữ liệu

        public FormDashboard()
        {
            InitializeComponent();

            LoadData();

            // Hover UI
            AddHover(btnHome);
            AddHover(btnNhanVien);
            AddHover(btnReport);

            // 🔥 GẮN CLICK (QUAN TRỌNG)
            btnNhanVien.Click += btnNhanVien_Click;
            btnReport.Click += btnReport_Click;
        }

        // ================= HOVER EFFECT =================
        private void AddHover(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(52, 152, 219);
                btn.ForeColor = Color.White;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(160, 174, 192);
            };
        }

        // ================= LOAD DASHBOARD =================
        private void LoadData()
        {
            dgvMain.Columns.Clear();
            dgvMain.Rows.Clear();

            dgvMain.Columns.Add("id", "Mã NV");
            dgvMain.Columns.Add("name", "Tên");
            dgvMain.Columns.Add("dept", "Phòng ban");
            dgvMain.Columns.Add("rate", "Hiệu suất");
        }

        // ================= MỞ FORM NHÂN VIÊN =================
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (formQL == null || formQL.IsDisposed)
                formQL = new FormQL();

            formQL.Show();
            formQL.BringToFront();
        }

        // ================= BÁO CÁO =================
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (formQL == null || formQL.IsDisposed)
            {
                MessageBox.Show(
                    "Vui lòng mở Quản Lý Nhân Viên trước!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 👉 TRUYỀN DATAGRIDVIEW SANG FORMREPORT
            FormReport report = new FormReport(formQL.EmployeeGrid);
            report.Show();
        }


       
    }
}
