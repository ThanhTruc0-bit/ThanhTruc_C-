namespace Example
{
    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMaNhanVien = new System.Windows.Forms.Label();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.labelTenNhanVien = new System.Windows.Forms.Label();
            this.textBoxTenNhanVien = new System.Windows.Forms.TextBox();
            this.labelAnh3x4 = new System.Windows.Forms.Label();
            this.pblmage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pblmage)).BeginInit();
            this.SuspendLayout();
            //
            // labelMaNhanVien
            //
            this.labelMaNhanVien.AutoSize = true;
            this.labelMaNhanVien.Location = new System.Drawing.Point(20, 30);
            this.labelMaNhanVien.Name = "labelMaNhanVien";
            this.labelMaNhanVien.Size = new System.Drawing.Size(76, 13);
            this.labelMaNhanVien.Text = "Mã nhân viên";
            //
            // textBoxMaNhanVien
            //
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(110, 27);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(180, 20);
            this.textBoxMaNhanVien.Text = "03152482001";
            //
            // labelTenNhanVien
            //
            this.labelTenNhanVien.AutoSize = true;
            this.labelTenNhanVien.Location = new System.Drawing.Point(20, 60);
            this.labelTenNhanVien.Name = "labelTenNhanVien";
            this.labelTenNhanVien.Size = new System.Drawing.Size(80, 13);
            this.labelTenNhanVien.Text = "Tên nhân viên";
            //
            // textBoxTenNhanVien
            //
            this.textBoxTenNhanVien.Location = new System.Drawing.Point(110, 57);
            this.textBoxTenNhanVien.Name = "textBoxTenNhanVien";
            this.textBoxTenNhanVien.Size = new System.Drawing.Size(180, 20);
            this.textBoxTenNhanVien.Text = "Nguyễn Văn Hùng";
            //
            // labelAnh3x4
            //
            this.labelAnh3x4.AutoSize = true;
            this.labelAnh3x4.Location = new System.Drawing.Point(20, 90);
            this.labelAnh3x4.Name = "labelAnh3x4";
            this.labelAnh3x4.Size = new System.Drawing.Size(52, 13);
            this.labelAnh3x4.Text = "Ảnh 3 x 4";
            //
            // pblmage
            //
            this.pblmage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblmage.Location = new System.Drawing.Point(110, 90);
            this.pblmage.Name = "pblmage";
            this.pblmage.Size = new System.Drawing.Size(100, 120); // Kích thước mô phỏng
            this.pblmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblmage.TabStop = false;
            //
            // btFile
            //
            this.btFile.Location = new System.Drawing.Point(215, 90);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 23);
            this.btFile.Text = "Chọn ảnh ...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            //
            // Form14
            //s
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 240); // Kích thước Form mô phỏng
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.pblmage);
            this.Controls.Add(this.labelAnh3x4);
            this.Controls.Add(this.textBoxTenNhanVien);
            this.Controls.Add(this.labelTenNhanVien);
            this.Controls.Add(this.textBoxMaNhanVien);
            this.Controls.Add(this.labelMaNhanVien);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form14";
            this.Text = "Quản lý nhân sự"; // Tiêu đề Form
            ((System.ComponentModel.ISupportInitialize)(this.pblmage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaNhanVien;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label labelTenNhanVien;
        private System.Windows.Forms.TextBox textBoxTenNhanVien;
        private System.Windows.Forms.Label labelAnh3x4;
        private System.Windows.Forms.PictureBox pblmage; // Tên biến như trong hình
        private System.Windows.Forms.Button btFile; // Tên biến như trong hình
    }
}