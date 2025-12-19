namespace Example
{
    partial class Form22
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblScore = new Label();
            pbChicken = new PictureBox();
            pbEgg = new PictureBox();
            pbBasket = new PictureBox();
            tmEgg = new System.Windows.Forms.Timer(components);
            tmChicken = new System.Windows.Forms.Timer(components);
            lblGameOver = new Label();
            ((System.ComponentModel.ISupportInitialize)pbChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEgg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBasket).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Location = new Point(13, 15);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(60, 20);
            lblScore.TabIndex = 4;
            lblScore.Text = "Điểm: 0";
            // 
            // pbChicken
            // 
            pbChicken.BackColor = Color.Transparent;
            pbChicken.Location = new Point(400, 15);
            pbChicken.Margin = new Padding(4, 5, 4, 5);
            pbChicken.Name = "pbChicken";
            pbChicken.Size = new Size(133, 154);
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.TabIndex = 2;
            pbChicken.TabStop = false;
            // 
            // pbEgg
            // 
            pbEgg.BackColor = Color.Transparent;
            pbEgg.Location = new Point(400, 15);
            pbEgg.Margin = new Padding(4, 5, 4, 5);
            pbEgg.Name = "pbEgg";
            pbEgg.Size = new Size(67, 77);
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.TabIndex = 1;
            pbEgg.TabStop = false;
            // 
            // pbBasket
            // 
            pbBasket.BackColor = Color.Transparent;
            pbBasket.Location = new Point(400, 846);
            pbBasket.Margin = new Padding(4, 5, 4, 5);
            pbBasket.Name = "pbBasket";
            pbBasket.Size = new Size(93, 108);
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.TabIndex = 3;
            pbBasket.TabStop = false;
            // 
            // tmEgg
            // 
            tmEgg.Interval = 10;
            // 
            // tmChicken
            // 
            tmChicken.Interval = 10;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Location = new Point(0, 0);
            lblGameOver.Margin = new Padding(4, 0, 4, 0);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(0, 20);
            lblGameOver.TabIndex = 0;
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            lblGameOver.Visible = false;
            // 
            // Form22
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 1055);
            Controls.Add(lblGameOver);
            Controls.Add(pbEgg);
            Controls.Add(pbChicken);
            Controls.Add(pbBasket);
            Controls.Add(lblScore);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form22";
            Text = "Catch Egg";
            Load += Form22_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEgg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBasket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Khai báo các Controls để Form22.cs có thể truy cập
        private System.Windows.Forms.PictureBox pbBasket;
        private System.Windows.Forms.PictureBox pbEgg;
        private System.Windows.Forms.PictureBox pbChicken;
        private System.Windows.Forms.Timer tmEgg;
        private System.Windows.Forms.Timer tmChicken;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
    }
}