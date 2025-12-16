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
            this.components = new System.ComponentModel.Container();
            // Khai báo các Controls
            this.lblScore = new System.Windows.Forms.Label();
            this.pbChicken = new System.Windows.Forms.PictureBox();
            this.pbEgg = new System.Windows.Forms.PictureBox();
            this.pbBasket = new System.Windows.Forms.PictureBox();
            this.tmEgg = new System.Windows.Forms.Timer(this.components);
            this.tmChicken = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasket)).BeginInit();
            this.SuspendLayout();

            // 
            // lblScore 
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(10, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Text = "Điểm: 0";
            this.lblScore.BackColor = System.Drawing.Color.Transparent;

            // 
            // pbChicken 
            // 
            this.pbChicken.Location = new System.Drawing.Point(300, 10);
            this.pbChicken.Name = "pbChicken";
            this.pbChicken.Size = new System.Drawing.Size(100, 100);
            this.pbChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChicken.BackColor = System.Drawing.Color.Transparent;

            // 
            // pbEgg 
            // 
            this.pbEgg.Location = new System.Drawing.Point(300, 10);
            this.pbEgg.Name = "pbEgg";
            this.pbEgg.Size = new System.Drawing.Size(50, 50);
            this.pbEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEgg.BackColor = System.Drawing.Color.Transparent;

            // 
            // pbBasket 
            // 
            this.pbBasket.Location = new System.Drawing.Point(300, 550);
            this.pbBasket.Name = "pbBasket";
            this.pbBasket.Size = new System.Drawing.Size(70, 70);
            this.pbBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBasket.BackColor = System.Drawing.Color.Transparent;

            // 
            // tmEgg 
            // 
            this.tmEgg.Interval = 10;

            // 
            // tmChicken 
            // 
            this.tmChicken.Interval = 10;

            // 
            // lblGameOver 
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Visible = false;
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // Quan trọng cho căn giữa

            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pbEgg);
            this.Controls.Add(this.pbChicken);
            this.Controls.Add(this.pbBasket);
            this.Controls.Add(this.lblScore);
            this.Name = "Form22";
            this.Text = "Catch Egg";

            ((System.ComponentModel.ISupportInitialize)(this.pbChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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