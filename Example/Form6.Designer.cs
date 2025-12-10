using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Example
{
    public partial class Form6
    {
        private IContainer components = null;

        // Khai báo TextBox
        private TextBox txtDisplay;

        // Khai báo các nút theo hình ảnh My Calculator
        private Button btMC;
        private Button btMR;
        private Button btMS;
        private Button btMPlus;
        private Button btMMinus;
        private Button btBack; // Nút mũi tên ←
        private Button btCE;
        private Button btC;
        private Button btSign; // Nút ±
        private Button btSqrt; // Nút √
        private Button btPercent; // Nút %
        private Button btReciprocal; // Nút 1/x

        private Button btDivide;
        private Button btMul;
        private Button btMinus;
        private Button btPlus;
        private Button btEquals;
        private Button btDot;

        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button bt4;
        private Button bt5;
        private Button bt6;
        private Button bt7;
        private Button bt8;
        private Button bt9;

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
            // --- Khởi tạo Controls ---
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btMC = new System.Windows.Forms.Button();
            this.btMR = new System.Windows.Forms.Button();
            this.btMS = new System.Windows.Forms.Button();
            this.btMPlus = new System.Windows.Forms.Button();
            this.btMMinus = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btSign = new System.Windows.Forms.Button();
            this.btSqrt = new System.Windows.Forms.Button();
            this.btPercent = new System.Windows.Forms.Button();
            this.btReciprocal = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();

            // --- Thiết lập TextBox ---
            this.txtDisplay.Location = new System.Drawing.Point(10, 10);
            this.txtDisplay.Size = new System.Drawing.Size(330, 40);
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;
            this.txtDisplay.ReadOnly = true;

            // --- Thiết lập vị trí và Text cho các nút (Kích thước xấp xỉ 60x40, cách nhau 5px) ---

            // Hàng 1 (MC, MR, MS, M+, M-)
            this.btMC.Location = new System.Drawing.Point(10, 60); this.btMC.Text = "MC"; this.btMC.Size = new System.Drawing.Size(60, 40);
            this.btMR.Location = new System.Drawing.Point(75, 60); this.btMR.Text = "MR"; this.btMR.Size = new System.Drawing.Size(60, 40);
            this.btMS.Location = new System.Drawing.Point(140, 60); this.btMS.Text = "MS"; this.btMS.Size = new System.Drawing.Size(60, 40);
            this.btMPlus.Location = new System.Drawing.Point(205, 60); this.btMPlus.Text = "M+"; this.btMPlus.Size = new System.Drawing.Size(60, 40);
            this.btMMinus.Location = new System.Drawing.Point(270, 60); this.btMMinus.Text = "M-"; this.btMMinus.Size = new System.Drawing.Size(60, 40);

            // Hàng 2 (←, CE, C, ±, √)
            this.btBack.Location = new System.Drawing.Point(10, 105); this.btBack.Text = "←"; this.btBack.Size = new System.Drawing.Size(60, 40);
            this.btCE.Location = new System.Drawing.Point(75, 105); this.btCE.Text = "CE"; this.btCE.Size = new System.Drawing.Size(60, 40);
            this.btC.Location = new System.Drawing.Point(140, 105); this.btC.Text = "C"; this.btC.Size = new System.Drawing.Size(60, 40);
            this.btSign.Location = new System.Drawing.Point(205, 105); this.btSign.Text = "±"; this.btSign.Size = new System.Drawing.Size(60, 40);
            this.btSqrt.Location = new System.Drawing.Point(270, 105); this.btSqrt.Text = "√"; this.btSqrt.Size = new System.Drawing.Size(60, 40);

            // Hàng 3 (7, 8, 9, /, %)
            this.bt7.Location = new System.Drawing.Point(10, 150); this.bt7.Text = "7"; this.bt7.Size = new System.Drawing.Size(60, 40);
            this.bt8.Location = new System.Drawing.Point(75, 150); this.bt8.Text = "8"; this.bt8.Size = new System.Drawing.Size(60, 40);
            this.bt9.Location = new System.Drawing.Point(140, 150); this.bt9.Text = "9"; this.bt9.Size = new System.Drawing.Size(60, 40);
            this.btDivide.Location = new System.Drawing.Point(205, 150); this.btDivide.Text = "/"; this.btDivide.Size = new System.Drawing.Size(60, 40);
            this.btPercent.Location = new System.Drawing.Point(270, 150); this.btPercent.Text = "%"; this.btPercent.Size = new System.Drawing.Size(60, 40);

            // Hàng 4 (4, 5, 6, *, 1/x)
            this.bt4.Location = new System.Drawing.Point(10, 195); this.bt4.Text = "4"; this.bt4.Size = new System.Drawing.Size(60, 40);
            this.bt5.Location = new System.Drawing.Point(75, 195); this.bt5.Text = "5"; this.bt5.Size = new System.Drawing.Size(60, 40);
            this.bt6.Location = new System.Drawing.Point(140, 195); this.bt6.Text = "6"; this.bt6.Size = new System.Drawing.Size(60, 40);
            this.btMul.Location = new System.Drawing.Point(205, 195); this.btMul.Text = "*"; this.btMul.Size = new System.Drawing.Size(60, 40);
            this.btReciprocal.Location = new System.Drawing.Point(270, 195); this.btReciprocal.Text = "1/x"; this.btReciprocal.Size = new System.Drawing.Size(60, 40);

            // Hàng 5 (1, 2, 3, -, =)
            this.bt1.Location = new System.Drawing.Point(10, 240); this.bt1.Text = "1"; this.bt1.Size = new System.Drawing.Size(60, 40);
            this.bt2.Location = new System.Drawing.Point(75, 240); this.bt2.Text = "2"; this.bt2.Size = new System.Drawing.Size(60, 40);
            this.bt3.Location = new System.Drawing.Point(140, 240); this.bt3.Text = "3"; this.bt3.Size = new System.Drawing.Size(60, 40);
            this.btMinus.Location = new System.Drawing.Point(205, 240); this.btMinus.Text = "-"; this.btMinus.Size = new System.Drawing.Size(60, 40);
            this.btEquals.Location = new System.Drawing.Point(270, 240); this.btEquals.Text = "="; this.btEquals.Size = new System.Drawing.Size(60, 85); // Kéo dài 2 hàng

            // Hàng 6 (0, ., +)
            this.bt0.Location = new System.Drawing.Point(10, 285); this.bt0.Text = "0"; this.bt0.Size = new System.Drawing.Size(125, 40); // Rộng gấp đôi
            this.btDot.Location = new System.Drawing.Point(140, 285); this.btDot.Text = "."; this.btDot.Size = new System.Drawing.Size(60, 40);
            this.btPlus.Location = new System.Drawing.Point(205, 285); this.btPlus.Text = "+"; this.btPlus.Size = new System.Drawing.Size(60, 40);


            // --- Gán sự kiện chung Button_Click cho TẤT CẢ các nút ---
            this.btMC.Click += new System.EventHandler(this.Button_Click);
            this.btMR.Click += new System.EventHandler(this.Button_Click);
            this.btMS.Click += new System.EventHandler(this.Button_Click);
            this.btMPlus.Click += new System.EventHandler(this.Button_Click);
            this.btMMinus.Click += new System.EventHandler(this.Button_Click);
            this.btBack.Click += new System.EventHandler(this.Button_Click);
            this.btCE.Click += new System.EventHandler(this.Button_Click);
            this.btC.Click += new System.EventHandler(this.Button_Click);
            this.btSign.Click += new System.EventHandler(this.Button_Click);
            this.btSqrt.Click += new System.EventHandler(this.Button_Click);
            this.btPercent.Click += new System.EventHandler(this.Button_Click);
            this.btReciprocal.Click += new System.EventHandler(this.Button_Click);
            this.btDivide.Click += new System.EventHandler(this.Button_Click);
            this.btMul.Click += new System.EventHandler(this.Button_Click);
            this.btMinus.Click += new System.EventHandler(this.Button_Click);
            this.btPlus.Click += new System.EventHandler(this.Button_Click);
            this.btEquals.Click += new System.EventHandler(this.Button_Click);
            this.btDot.Click += new System.EventHandler(this.Button_Click);
            this.bt0.Click += new System.EventHandler(this.Button_Click);
            this.bt1.Click += new System.EventHandler(this.Button_Click);
            this.bt2.Click += new System.EventHandler(this.Button_Click);
            this.bt3.Click += new System.EventHandler(this.Button_Click);
            this.bt4.Click += new System.EventHandler(this.Button_Click);
            this.bt5.Click += new System.EventHandler(this.Button_Click);
            this.bt6.Click += new System.EventHandler(this.Button_Click);
            this.bt7.Click += new System.EventHandler(this.Button_Click);
            this.bt8.Click += new System.EventHandler(this.Button_Click);
            this.bt9.Click += new System.EventHandler(this.Button_Click);

            // --- Thiết lập Form Chính ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 335); // Kích thước phù hợp với Controls
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form6"; // Tên Form
            this.Text = "My Calculator";
            this.MaximizeBox = false;

            // Thêm tất cả Controls vào Form
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btMC); this.Controls.Add(this.btMR); this.Controls.Add(this.btMS); this.Controls.Add(this.btMPlus); this.Controls.Add(this.btMMinus);
            this.Controls.Add(this.btBack); this.Controls.Add(this.btCE); this.Controls.Add(this.btC); this.Controls.Add(this.btSign); this.Controls.Add(this.btSqrt);
            this.Controls.Add(this.bt7); this.Controls.Add(this.bt8); this.Controls.Add(this.bt9); this.Controls.Add(this.btDivide); this.Controls.Add(this.btPercent);
            this.Controls.Add(this.bt4); this.Controls.Add(this.bt5); this.Controls.Add(this.bt6); this.Controls.Add(this.btMul); this.Controls.Add(this.btReciprocal);
            this.Controls.Add(this.bt1); this.Controls.Add(this.bt2); this.Controls.Add(this.bt3); this.Controls.Add(this.btMinus); this.Controls.Add(this.btEquals);
            this.Controls.Add(this.bt0); this.Controls.Add(this.btDot); this.Controls.Add(this.btPlus);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}