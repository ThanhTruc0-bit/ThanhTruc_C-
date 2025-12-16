using System;
using System.Windows.Forms;
using System.Text;

namespace Example
{
    public partial class Form11 : Form
    {
        private int studentCount = 2; // Bắt đầu từ 2 (theo dữ liệu mẫu)

        public Form11()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi nhấn nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tăng số lượng sinh viên
            studentCount++;

            // Lấy thông tin từ các controls
            string hoTen = txtHoTen.Text;
            string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
            string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
            string khoa = cmbKhoa.SelectedItem != null ? cmbKhoa.SelectedItem.ToString() : "Chưa chọn khoa";

            // Xây dựng chuỗi thông tin sinh viên mới
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(); // Thêm dòng trống cho sinh viên mới
            sb.AppendLine($"{studentCount}.{hoTen}");
            sb.AppendLine($"-Giới tính: {gioiTinh}");
            sb.AppendLine($"-Ngày Sinh: {ngaySinh}");
            sb.AppendLine($"-Khoa: {khoa}");

            // Thêm vào RichTextBox (Trạng thái)
            rtbTrangThai.AppendText(sb.ToString());

            // Thông báo
            MessageBox.Show($"Đã thêm sinh viên {hoTen} vào danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Xóa trường nhập liệu (tùy chọn)
            txtHoTen.Clear();
            rbNam.Checked = true; // Mặc định lại là Nam
            dtpNgaySinh.Value = DateTime.Now; // Mặc định lại ngày hiện tại
            cmbKhoa.SelectedIndex = 0;
        }

        // Xử lý sự kiện khi nhấn nút "Thoát"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng ứng dụng
        }
    }
}