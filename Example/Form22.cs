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

        // Basket
        int xBasket, yBasket;
        int xDeltaBasket = 30;

        // Chicken
        int xChicken, yChicken;
        int xDeltaChicken = 5;

        // Egg
        int xEgg, yEgg;
        int yDeltaEgg = 3;

        public Form22()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.KeyPreview = true;

            this.Load += Form22_Load;
            this.KeyDown += Form22_KeyDown;

            tmEgg.Tick += tmEgg_Tick;
            tmChicken.Tick += tmChiken_Tick;
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;

            // Vị trí ban đầu
            xBasket = pbBasket.Left;
            yBasket = pbBasket.Top;
            xChicken = pbChicken.Left;
            yChicken = pbChicken.Top;
            xEgg = pbEgg.Left;
            yEgg = pbEgg.Top;

            // Background
            try
            {
                string bg = Path.Combine(dir, @"images\background.png");
                if (File.Exists(bg))
                {
                    BackgroundImage = Image.FromFile(bg);
                    BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch { }

            // Images
            pbBasket.Image = LoadImageSafe(Path.Combine(dir, @"images\basket.png"));
            pbEgg.Image = LoadImageSafe(Path.Combine(dir, @"images\egg_gold.png"));
            pbChicken.Image = LoadImageSafe(Path.Combine(dir, @"images\chicken.png"));

            // Score label
            lblScore.Text = "Điểm: 0";
            lblScore.Font = new Font("Arial", 18, FontStyle.Bold);
            lblScore.ForeColor = Color.Yellow;
            lblScore.BackColor = Color.FromArgb(150, 0, 0, 0);
            lblScore.Padding = new Padding(5);
            lblScore.BringToFront();

            // Sounds (WAV only)
            string catchWav = Path.Combine(dir, @"images\catch_sound.wav");
            string breakWav = Path.Combine(dir, @"images\break_sound.wav");

            if (File.Exists(catchWav)) catchPlayer.SoundLocation = catchWav;
            if (File.Exists(breakWav)) breakPlayer.SoundLocation = breakWav;

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
                if (e.KeyCode == Keys.Left && xBasket > 0)
                    xBasket -= xDeltaBasket;

                if (e.KeyCode == Keys.Right &&
                    xBasket < ClientSize.Width - pbBasket.Width)
                    xBasket += xDeltaBasket;

                pbBasket.Location = new Point(xBasket, yBasket);
            }
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            if (isGameOver) return;

            string dir = AppDomain.CurrentDomain.BaseDirectory;
            yEgg += yDeltaEgg;

            // Bắt trứng
            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score += 10;
                lblScore.Text = "Điểm: " + score;
                try { catchPlayer.Play(); } catch { }

                yEgg = 30;
                xEgg = pbChicken.Left;
                pbEgg.Image = LoadImageSafe(Path.Combine(dir, @"images\egg_gold.png"));
                pbEgg.Location = new Point(xEgg, yEgg);
                return;
            }

            // Trứng vỡ
            if (yEgg >= ClientSize.Height - pbEgg.Height)
            {
                // Dừng timer
                tmEgg.Stop();
                tmChicken.Stop();

                // Cố định trứng dưới đất
                yEgg = ClientSize.Height - pbEgg.Height;
                pbEgg.Location = new Point(xEgg, yEgg);

                // Đổi ảnh vỡ
                pbEgg.Image = LoadImageSafe(
                    Path.Combine(dir, @"images\egg_gold_broken.jpg")
                );
                pbEgg.BringToFront();
                pbEgg.Refresh();
                Refresh();

                // Âm thanh
                try { breakPlayer.Play(); } catch { }

                // Chờ để thấy trứng vỡ
                Application.DoEvents();
                System.Threading.Thread.Sleep(400);

                // Game over
                isGameOver = true;

                lblGameOver.Text =
                    "--- GAME OVER ---\n\n" +
                    "⭐ ĐIỂM: " + score + " ⭐\n\n" +
                    "Nhấn SPACE để chơi lại";

                lblGameOver.Font = new Font("Arial", 36, FontStyle.Bold);
                lblGameOver.ForeColor = Color.White;
                lblGameOver.BackColor = Color.FromArgb(180, 0, 0, 0);
                lblGameOver.Padding = new Padding(20);

                lblGameOver.Size = lblGameOver.PreferredSize;
                lblGameOver.Location = new Point(
                    (ClientSize.Width - lblGameOver.Width) / 2,
                    (ClientSize.Height - lblGameOver.Height) / 2
                );

                lblGameOver.Visible = true;
                lblGameOver.BringToFront();
                return;
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void tmChiken_Tick(object sender, EventArgs e)
        {
            if (isGameOver) return;

            xChicken += xDeltaChicken;

            if (xChicken <= 0 ||
                xChicken >= ClientSize.Width - pbChicken.Width)
            {
                xDeltaChicken = -xDeltaChicken;
            }

            pbChicken.Location = new Point(xChicken, yChicken);
        }

        private Image LoadImageSafe(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(fs);
            }
        }

        private void Form22_Load_1(object sender, EventArgs e)
        {

        }
    }
}
