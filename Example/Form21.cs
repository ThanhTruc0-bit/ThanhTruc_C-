using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    // Đây là class Form1 dựa trên các đoạn code trong ảnh
    public partial class Form21 : Form
    {
        // Khai báo biến toàn cục
        PictureBox pbBasket = new PictureBox();
        int xBasket = 300;
        int yBasket = 500;
        int xDelta = 30;

        // Hàm khởi tạo của Form
        public Form21()
        {
            InitializeComponent();
        }

        // Sự kiện Load của Form
        private void Form21_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);

            // Dòng này dựa trên code gốc trong ảnh, tôi đặt lại vị trí
            pbBasket.Location = new Point(xBasket, yBasket);

            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);

            // Tải hình ảnh rổ
            // Lưu ý: Đường dẫn tương đối `../Images/basket.png` trong code gốc có thể gây lỗi
            // Nếu bạn gặp lỗi FileNotFoundException, hãy kiểm tra lại đường dẫn.
            pbBasket.Image = Image.FromFile(@"images/basket.png");
        }

        // Sự kiện KeyDown của Form (Xử lý di chuyển rổ)
        private void Form21_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím mũi tên phải (KeyCode 39)
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDelta;

            // Phím mũi tên trái (KeyCode 37)
            if (e.KeyValue == 37 && xBasket > 0)
                xBasket -= xDelta;

            // Cập nhật vị trí mới của rổ
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}