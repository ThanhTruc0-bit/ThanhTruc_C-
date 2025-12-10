using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Example
{
    public partial class Form5
    {
        private IContainer components = null;
        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3; // Đã thêm
        private Button btPlus;
        private Button btMul;
        private Button btDot; // Đã thêm
        private Button btEquals;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button(); // Khởi tạo
            this.btPlus = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button(); // Khởi tạo
            this.btEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDisplay.Location = new System.Drawing.Point(10, 10);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDisplay.Size = new System.Drawing.Size(260, 47);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.Text = "0";

            // --- Nút số (Hàng 1) ---

            this.bt0.Location = new System.Drawing.Point(10, 60);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(60, 60);
            this.bt0.Text = "0";
            this.bt0.Click += new System.EventHandler(this.bt0_Click);

            this.bt1.Location = new System.Drawing.Point(75, 60);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(60, 60);
            this.bt1.Text = "1";
            this.bt1.Click += new System.EventHandler(this.bt1_Click);

            this.bt2.Location = new System.Drawing.Point(140, 60);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(60, 60);
            this.bt2.Text = "2";
            this.bt2.Click += new System.EventHandler(this.bt2_Click);

            this.bt3.Location = new System.Drawing.Point(205, 60);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(60, 60);
            this.bt3.Text = "3";
            this.bt3.Click += new System.EventHandler(this.bt3_Click); // Gán sự kiện cho nút 3

            // --- Nút phép toán (Hàng 2) ---

            this.btPlus.Location = new System.Drawing.Point(10, 125);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(60, 60);
            this.btPlus.Text = "+";
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);

            this.btMul.Location = new System.Drawing.Point(75, 125);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(60, 60);
            this.btMul.Text = "*";
            this.btMul.Click += new System.EventHandler(this.btMul_Click);

            this.btDot.Location = new System.Drawing.Point(140, 125);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(60, 60);
            this.btDot.Text = ".";
            this.btDot.Click += new System.EventHandler(this.btDot_Click); // Gán sự kiện cho nút .

            this.btEquals.Location = new System.Drawing.Point(205, 125);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(60, 60);
            this.btEquals.Text = "=";
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);

            // --- Form Chính ---

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 200);

            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3); // Thêm vào Controls
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDisplay);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Simple Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}