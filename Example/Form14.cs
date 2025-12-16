using System;
using System.Windows.Forms;
using System.Drawing;

namespace Example
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        // CHỈ CÓ MỘT ĐỊNH NGHĨA CHO HÀM XỬ LÝ SỰ KIỆN NÀY
        private void btFile_Click(object sender, EventArgs e)
        {
            // Đảm bảo ảnh hiển thị được co dãn trong PictureBox
            pblmage.SizeMode = PictureBoxSizeMode.StretchImage;

            // Khởi tạo và thiết lập OpenFileDialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";

            // Hiển thị hộp thoại và kiểm tra kết quả
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn file đã chọn
                pblmage.ImageLocation = dlg.FileName;
            }
        }
    }
}