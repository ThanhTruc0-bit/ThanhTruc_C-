using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Form17 : Form
    {
        // Khai báo PictureBox được tạo động (pb) và tọa độ (x, y)
        // Lưu ý: Tọa độ x, y sẽ là góc trên bên trái của PictureBox.
        PictureBox pb = new PictureBox();
        int x = 0;
        int y = 0;

        public Form17()
        {
            InitializeComponent();

            // Cài đặt ban đầu cho Form: Đặt vị trí ban đầu của x, y 
            // để PictureBox không bị ẩn ở góc (0,0) nếu Form có tiêu đề.
            // Ví dụ: Bắt đầu ở (50, 50)
            x = 50;
            y = 50;
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút "File..." (btFile)
        /// Mở hộp thoại OpenFileDialog để chọn ảnh và hiển thị lên Form.
        /// </summary>
        private void btFile_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập bộ lọc chỉ cho phép chọn các loại file ảnh phổ biến
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            // Hiển thị hộp thoại. Nếu người dùng chọn file và nhấn OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Thiết lập thuộc tính cho PictureBox pb
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(100, 100);
                pb.Location = new Point(x, y);

                // Tải ảnh từ đường dẫn đã chọn
                pb.ImageLocation = openFileDialog.FileName;

                // Thêm PictureBox pb vào Controls của Form, chỉ thêm nếu nó chưa tồn tại
                if (!this.Controls.Contains(pb))
                {
                    this.Controls.Add(pb);
                }

                // Đảm bảo PictureBox hiển thị trên cùng (quan trọng nếu có các control khác)
                pb.BringToFront();
            }
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút "<" (btLeft)
        /// Giảm giá trị x (di chuyển sang trái 10 pixel)
        /// </summary>
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        /// <summary>
        /// Xử lý sự kiện Click cho nút ">" (btRight)
        /// Tăng giá trị x (di chuyển sang phải 10 pixel)
        /// </summary>
        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }
    }
}