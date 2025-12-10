using System;
using System.Windows.Forms;
using System.IO; // Cần thêm thư viện này cho StreamWriter

namespace Example
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút "Cộng" - Nối kết quả
        /// </summary>
        private void btCong_Click(object sender, EventArgs e)
        {
            // Thực hiện tính toán và nối chuỗi như trong hình ảnh code
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x + y;

                // Nối chuỗi vào tbKetQua, có thêm "\r\n" để xuống dòng
                tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + "\r\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào ô 'Số x' và 'Số y'.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút "Nhân" - Nối kết quả
        /// </summary>
        private void btNhan_Click(object sender, EventArgs e)
        {
            // Thực hiện tính toán và nối chuỗi như trong hình ảnh code
            try
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y;

                // Nối chuỗi vào tbKetQua, có thêm "\r\n" để xuống dòng
                tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào ô 'Số x' và 'Số y'.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút "Lưu" - Ghi nội dung của tbKetQua vào file
        /// </summary>
        private void btLuu_Click(object sender, EventArgs e)
        {
            // Logic lưu file như trong hình ảnh code
            try
            {
                // Sử dụng "true" để cho phép nối thêm (append) vào file, không ghi đè
                StreamWriter sw = new StreamWriter("Caculator.txt", true);
                sw.Write(tbKetQua.Text);
                sw.Close();
                MessageBox.Show("Đã lưu kết quả vào file Caculator.txt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút "Thoát"
        /// </summary>
        private void btThoat_Click(object sender, EventArgs e)
        {
            // Logic thoát như trong hình ảnh code
            this.Close();
        }
    }
}