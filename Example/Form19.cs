using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace Example
{
    public partial class Form19 : Form
    {
        // Khai báo các biến thành viên (dựa trên hình ảnh 2)
        PictureBox pb = new PictureBox();
        Timer tmGame = new Timer();
        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDelta = 5;

        public Form19()
        {
            InitializeComponent();
        }

        // Sự kiện Load của Form (dựa trên hình ảnh 1)
        private void Form19_Load(object sender, EventArgs e)
        {
            // Thiết lập Timer
            tmGame.Interval = 10;
            tmGame.Tick += tmGame_Tick;
            tmGame.Start();

            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(xBall, yBall);
            this.Controls.Add(pb);

            pb.ImageLocation = @"d:\ball.png";
        }

        void tmGame_Tick(object sender, EventArgs e)
        {
            xBall += xDelta;
            yBall += yDelta;

            if ((xBall > this.ClientSize.Width - pb.Width) || (xBall < 0))
            {
                xDelta = -xDelta;
            }

            if ((yBall > this.ClientSize.Height - pb.Height) || (yBall < 0))
            {
                yDelta = -yDelta;
            }

            pb.Location = new Point(xBall, yBall);
        }
    }
}