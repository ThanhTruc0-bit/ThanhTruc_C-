using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Form4
    {
        // Khai báo các Controls
        private System.ComponentModel.IContainer components = null;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
        private Button btLuu; // Thêm nút Lưu
        private Label lblSoX;
        private Label lblSoY;
        private Label lblKetQua;

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
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button(); // Khởi tạo nút Lưu
            this.lblSoX = new System.Windows.Forms.Label();
            this.lblSoY = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblSoX
            // 
            this.lblSoX.AutoSize = true;
            this.lblSoX.Location = new System.Drawing.Point(20, 25);
            this.lblSoX.Name = "lblSoX";
            this.lblSoX.Size = new System.Drawing.Size(46, 20);
            this.lblSoX.Text = "Số x";

            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(100, 22);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(200, 27);
            this.tbSoX.TabIndex = 0;

            // 
            // lblSoY
            // 
            this.lblSoY.AutoSize = true;
            this.lblSoY.Location = new System.Drawing.Point(20, 60);
            this.lblSoY.Name = "lblSoY";
            this.lblSoY.Size = new System.Drawing.Size(46, 20);
            this.lblSoY.Text = "Số y";

            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(100, 57);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(200, 27);
            this.tbSoY.TabIndex = 1;

            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(20, 95);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(65, 20);
            this.lblKetQua.Text = "Kết quả";

            // 
            // tbKetQua
            // 
            this.tbKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right))); // Thuộc tính Anchor theo ảnh
            this.tbKetQua.Location = new System.Drawing.Point(100, 92);
            this.tbKetQua.Multiline = true; // Cho phép nhiều dòng
            this.tbKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Thêm thanh cuộn
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.ReadOnly = true;
            this.tbKetQua.Size = new System.Drawing.Size(200, 150); // Chiều cao lớn hơn để hiển thị nhiều dòng
            this.tbKetQua.TabIndex = 2;

            // 
            // btLuu (Nút Lưu)
            // 
            this.btLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLuu.Location = new System.Drawing.Point(20, 260); // Đặt ở dưới, bên trái
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(60, 35);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);

            // 
            // btCong
            // 
            this.btCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCong.Location = new System.Drawing.Point(100, 260);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(60, 35);
            this.btCong.TabIndex = 4;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);

            // 
            // btNhan
            // 
            this.btNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btNhan.Location = new System.Drawing.Point(170, 260);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(60, 35);
            this.btNhan.TabIndex = 5;
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);

            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))); // Thuộc tính Anchor theo ảnh
            this.btThoat.Location = new System.Drawing.Point(240, 260);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(60, 35);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);

            // 
            // Form4 (Form Chính)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 310); // Điều chỉnh kích thước Form

            // Thuộc tính Form (Theo hình ảnh)
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Thuộc tính FormBorderStyle theo ảnh
            this.MaximizeBox = false; // Thuộc tính MaximizeBox theo ảnh
            this.MinimizeBox = false; // Thuộc tính MinimizeBox theo ảnh
            this.StartPosition = FormStartPosition.CenterScreen; // Thuộc tính StartPosition theo ảnh
            this.Text = "Caculator"; // Tiêu đề Form theo ảnh
            this.Name = "Form4"; // Đổi tên Form thành Form4

            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblSoY);
            this.Controls.Add(this.lblSoX);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btLuu); // Thêm nút Lưu vào Form
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}