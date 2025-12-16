using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer; 

namespace Example
{
    // Đảm bảo Form20 thừa kế từ Form
    public partial class Form20 : Form
    {
        // =========================================================
        // 1. KHAI BÁO BIẾN THÀNH VIÊN
        // =========================================================
        PictureBox pbEgg = new PictureBox();
        Timer tmEgg = new Timer();

        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 3; // Tốc độ rơi

        // =========================================================
        // 2. HÀM KHỞI TẠO (Constructor)
        // =========================================================
        public Form20()
        {
            InitializeComponent();
        }

        // =========================================================
        // 3. HÀM XỬ LÝ SỰ KIỆN FORM_LOAD (Đã sửa tên hàm thành Form20_Load)
        // =========================================================
        private void Form20_Load(object sender, EventArgs e)
        {
            // Thiết lập Timer
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            // Thiết lập PictureBox cho trứng (pbEgg)
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;

            // Thêm PictureBox vào Form
            this.Controls.Add(pbEgg);

            // Tải hình ảnh quả trứng ban đầu
            pbEgg.Image = Image.FromFile(@"images/egg_gold.png");
        }

        void tmEgg_Tick(object sender, EventArgs e)
        {
            // Cập nhật tọa độ Y (trứng rơi)
            yEgg += yDelta;

            // Kiểm tra va chạm với cạnh dưới của Form (chạm đất)
            // Điều kiện: yEgg > (Chiều cao Form - Chiều cao PictureBox) HOẶC yEgg <= 0
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                // Nếu chạm đất, đổi hình ảnh sang trứng vỡ
                // Đã sửa lỗi chính tả từ .jpn thành .png
                pbEgg.Image = Image.FromFile(@"images/egg_gold_broken.jpg");
                // Có thể thêm tmEgg.Stop() ở đây để dừng vòng chơi
            }

            // Cập nhật vị trí mới cho PictureBox
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}