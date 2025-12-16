namespace Example
{
    partial class Form21
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
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600); // Kích thước ví dụ
            this.Name = "Form1";
            this.Text = "Catch Egg"; // Dựa trên tiêu đề cửa sổ trong ảnh
            this.KeyPreview = true; // Cho phép Form nhận sự kiện KeyDown

            // Gắn các sự kiện đã được viết trong Form1.cs
            this.Load += new System.EventHandler(this.Form21_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form21_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}