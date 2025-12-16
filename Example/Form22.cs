using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Example
{


    public partial class Form22 : Form
    {
        int score = 0;
        bool isGameOver = false;

        SoundPlayer catchPlayer = new SoundPlayer();
        SoundPlayer breakPlayer = new SoundPlayer();

        // Khai báo biến vị trí và tốc độ
        int xBasket;
        int yBasket;
        int xDeltaBasket = 30;

        int xChicken;
        int yChicken;
        int xDeltaChicken = 5;

        int xEgg;
        int yEgg;
        int yDeltaEgg = 3;

        public Form22()
        {
            // Tự động tạo và thiết lập Controls
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form22_KeyDown);
            this.Load += new EventHandler(Form22_Load);

            // Bổ sung kết nối sự kiện Tick cho Timer (Đảm bảo chạy)
            this.tmEgg.Tick += new System.EventHandler(this.tmEgg_Tick);
            this.tmChicken.Tick += new System.EventHandler(this.tmChiken_Tick);
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Lấy vị trí ban đầu từ Designer Controls
            xBasket = pbBasket.Location.X;
            yBasket = pbBasket.Location.Y;
            xChicken = pbChicken.Location.X;
            yChicken = pbChicken.Location.Y;
            xEgg = pbEgg.Location.X;
            yEgg = pbEgg.Location.Y;

            // --- TẢI HÌNH NỀN ---
            try
            {
                string backgroundPath = Path.Combine(currentDirectory, @"images\background.png");
                if (!File.Exists(backgroundPath))
                {
                    backgroundPath = Path.Combine(currentDirectory, @"images\background.jpg");
                }

                if (File.Exists(backgroundPath))
                {
                    this.BackgroundImage = Image.FromFile(backgroundPath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    this.BackColor = Color.LightSkyBlue;
                }
            }
            catch (Exception) { this.BackColor = Color.LightSkyBlue; }

            // --- TẢI HÌNH ẢNH CONTROLS ---
            try
            {
                pbBasket.Image = Image.FromFile(Path.Combine(currentDirectory, @"images\basket.png"));
                pbEgg.Image = Image.FromFile(Path.Combine(currentDirectory, @"images\egg_gold.png"));
                pbChicken.Image = Image.FromFile(Path.Combine(currentDirectory, @"images\chicken.png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hình ảnh. Đảm bảo file trong thư mục images: " + ex.Message, "Lỗi Tài nguyên");
            }

            // --- THIẾT KẾ ĐIỂM SỐ ---
            lblScore.Text = "Điểm: 0";
            lblScore.Font = new Font("Arial", 18, FontStyle.Bold);
            lblScore.ForeColor = Color.Yellow;
            lblScore.BackColor = Color.FromArgb(150, 0, 0, 0);
            lblScore.Padding = new Padding(5);
            lblScore.BringToFront();

            // --- TẢI TỆP ÂM THANH (SỬA LỖI ĐỊNH DẠNG: Chỉ SoundPlayer hỗ trợ .WAV) ---
            try
            {
                string catchWav = Path.Combine(currentDirectory, @"images\catch_sound.wav");
                string breakWav = Path.Combine(currentDirectory, @"images\break_sound.wav");

                if (File.Exists(catchWav)) catchPlayer.SoundLocation = catchWav;
                if (File.Exists(breakWav)) breakPlayer.SoundLocation = breakWav;

                // Nếu bạn chỉ có MP3, hãy thông báo:
                if (!File.Exists(catchWav) && File.Exists(Path.Combine(currentDirectory, @"images\catch_sound.mp3")))
                {
                    MessageBox.Show("Cảnh báo: Tệp âm thanh MP3 không được hỗ trợ bởi SoundPlayer. Vui lòng chuyển sang định dạng WAV.", "Lỗi Âm thanh");
                }
            }
            catch (Exception) { }

            // --- Khởi động Timer ---
            tmEgg.Start();
            tmChicken.Start();
        }

        private void Form22_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver && e.KeyCode == Keys.Space)
            {
                Application.Restart();
                return;
            }

            if (!isGameOver)
            {
                // Phím phải
                if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
                {
                    xBasket += xDeltaBasket;
                }
                // Phím trái
                if (e.KeyValue == 37 && xBasket > 0)
                {
                    xBasket -= xDeltaBasket;
                }
                pbBasket.Location = new Point(xBasket, yBasket);
            }
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                return;
            }

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            yEgg += yDeltaEgg;

            // LOGIC BẮT ĐƯỢC TRỨNG
            Rectangle unionRect = Rectangle.Intersect(pbEgg.Bounds, pbBasket.Bounds);
            if (unionRect.IsEmpty == false)
            {
                score += 10;
                lblScore.Text = "Điểm: " + score.ToString();
                try { catchPlayer.Play(); } catch { }

                yEgg = 30;
                xEgg = pbChicken.Location.X;
                pbEgg.Location = new Point(xEgg, yEgg);

                pbEgg.Image = Image.FromFile(Path.Combine(currentDirectory, @"images\egg_gold.png"));
            }

            // LOGIC TRỨNG VỠ (KẾT THÚC TRÒ CHƠI)
            else if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                isGameOver = true;
                tmEgg.Stop();
                tmChicken.Stop();

                try { breakPlayer.Play(); } catch { }
                pbEgg.Image = Image.FromFile(Path.Combine(currentDirectory, @"images\egg_gold_broken.jpg"));

                // HIỂN THỊ THÔNG BÁO END GAME
                lblGameOver.Text = "--- GAME OVER ---\n\n" +
                                   "⭐ ĐIỂM CUỐI: " + score + " ⭐\n\n" +
                                   "Nhấn SPACE để chơi lại";

                lblGameOver.Font = new Font("Arial", 36, FontStyle.Bold);
                lblGameOver.ForeColor = Color.White;
                lblGameOver.BackColor = Color.FromArgb(180, 0, 0, 0);
                lblGameOver.Padding = new Padding(20);

                lblGameOver.Size = lblGameOver.PreferredSize;
                lblGameOver.Location = new Point((this.ClientSize.Width - lblGameOver.Width) / 2,
                                                 (this.ClientSize.Height - lblGameOver.Height) / 2);
                lblGameOver.Visible = true;
                lblGameOver.BringToFront();
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void tmChiken_Tick(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                tmChicken.Stop();
                return;
            }

            xChicken += xDeltaChicken;

            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken = -xDeltaChicken;
            }

            pbChicken.Location = new Point(xChicken, yChicken);
        }
    }
}