using System;
using System.Windows.Forms;

namespace Example
{
    // Lớp Form10 phải là partial để kết hợp với Form10.Designer.cs
    public partial class Form10 : Form
    {
        // Constructor
        public Form10()
        {
            // Gọi phương thức khởi tạo các controls (từ Form10.Designer.cs)
            InitializeComponent();
            this.Text = "Form10 - Click OK hoặc thay đổi ngày"; // Thiết lập tiêu đề ban đầu
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Đặt tiêu đề của Form (this.Text) thành ngày được chọn ở định dạng Long
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // --- HÀM XỬ LÝ SỰ KIỆN THAY ĐỔI GIÁ TRỊ (dtpDate_ValueChanged) ---
        // Hàm này được gọi khi giá trị ngày trên DateTimePicker thay đổi.
        // Logic được lấy từ hình ảnh: Hiển thị ngày ở định dạng Short.
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Đặt tiêu đề của Form (this.Text) thành ngày được chọn ở định dạng Short
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}