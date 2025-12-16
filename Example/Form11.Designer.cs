namespace Example
{
    partial class Form11
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.RichTextBox rtbTrangThai; // Dùng RichTextBox cho phần "Trạng thái"
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;

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
            // Khởi tạo các controls
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.rtbTrangThai = new System.Windows.Forms.RichTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form10
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 480);
            this.Text = "Quản lý sinh viên";
            this.MaximizeBox = false;

            // lblHoTen (Họ và tên)
            this.lblHoTen.Location = new System.Drawing.Point(20, 20);
            this.lblHoTen.Text = "Họ và tên";
            this.lblHoTen.AutoSize = true;

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(120, 18);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 20);
            this.txtHoTen.Text = "Trần Thị Học Lai";

            // lblNgaySinh (Ngày Sinh)
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 50);
            this.lblNgaySinh.Text = "Ngày Sinh";
            this.lblNgaySinh.AutoSize = true;

            // dtpNgaySinh
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 48);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(170, 20);
            this.dtpNgaySinh.Value = new System.DateTime(1994, 7, 10); // Ví dụ giá trị

            // lblGioiTinh (Giới tính)
            this.lblGioiTinh.Location = new System.Drawing.Point(300, 50);
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.AutoSize = true;

            // rbNam
            this.rbNam.Location = new System.Drawing.Point(300, 75);
            this.rbNam.Name = "rbNam";
            this.rbNam.Text = "Nam";
            this.rbNam.AutoSize = true;
            this.rbNam.TabIndex = 2;

            // rbNu
            this.rbNu.Location = new System.Drawing.Point(355, 75);
            this.rbNu.Name = "rbNu";
            this.rbNu.Text = "Nữ";
            this.rbNu.Checked = true; // Theo ảnh
            this.rbNu.AutoSize = true;
            this.rbNu.TabIndex = 3;

            // lblKhoa (Khoa)
            this.lblKhoa.Location = new System.Drawing.Point(20, 90);
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.AutoSize = true;

            // cmbKhoa
            this.cmbKhoa.Location = new System.Drawing.Point(120, 88);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(270, 21);
            this.cmbKhoa.Items.AddRange(new object[] {
                "Công nghệ thông tin",
                "Quản trị kinh doanh",
                "Kỹ thuật xây dựng"}); // Thêm items mẫu
            this.cmbKhoa.SelectedIndex = 0; // Chọn mặc định "Công nghệ thông tin"

            // lblTrangThai (Trạng thái)
            this.lblTrangThai.Location = new System.Drawing.Point(20, 130);
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.AutoSize = true;

            // rtbTrangThai (Phần hiển thị danh sách sinh viên)
            this.rtbTrangThai.Location = new System.Drawing.Point(20, 155);
            this.rtbTrangThai.Name = "rtbTrangThai";
            this.rtbTrangThai.Size = new System.Drawing.Size(370, 250);
            this.rtbTrangThai.TabIndex = 4;
            // Dữ liệu mẫu ban đầu (như trong ảnh)
            this.rtbTrangThai.Text = "1.Nguyễn Văn Rớt\n-Giới tính: Nam\n-Ngày Sinh: 20/10/1995\n-Khoa: Công nghệ thông tin\n2.Trần Thị Học Lai\n-Giới tính: Nữ\n-Ngày Sinh: 10/07/1994\n-Khoa: Công nghệ thông tin";

            // btnThem (Thêm)
            this.btnThem.Location = new System.Drawing.Point(100, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click); // Gắn sự kiện

            // btnThoat (Thoát)
            this.btnThoat.Location = new System.Drawing.Point(230, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click); // Gắn sự kiện

            // Thêm tất cả controls vào Form
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.rtbTrangThai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}