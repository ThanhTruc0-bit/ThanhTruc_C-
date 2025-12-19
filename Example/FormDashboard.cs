using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            LoadEmployeeData();

            // Hiệu ứng Hover chuyên nghiệp
            AddHoverEffect(btnHome);
            AddHoverEffect(btnNhanVien);
            AddHoverEffect(btnReport);
        }

        private void AddHoverEffect(Button btn)
        {
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(45, 55, 72);
                btn.ForeColor = Color.White;
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(160, 174, 192);
            };
        }

        private void LoadEmployeeData()
        {
            dgvMain.Columns.Add("id", "Mã NV");
            dgvMain.Columns.Add("name", "Tên Nhân Viên");
            dgvMain.Columns.Add("dept", "Phòng Ban");
            dgvMain.Columns.Add("perf", "Hiệu Suất");

            dgvMain.Rows.Add("NV001", "Thanh Trúc", "Công nghệ thông tin", "98%");
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            // Kết nối sang bản Form quản lý chi tiết
            FormQL formDetail = new FormQL();
            formDetail.Show();
        }
    }
}