namespace Example
{
    partial class FormQL
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge, tbPhone;
        private System.Windows.Forms.RadioButton rbNam, rbNu;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btAddNew, btEdit, btDelete;

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btChooseImage;

        private System.Windows.Forms.Label lblId, lblName, lblAge, lblGender, lblPhone, lblBirth, lblPosition;

        private void InitializeComponent()
        {
            dgvEmployee = new DataGridView();
            gbInfo = new GroupBox();
            lblId = new Label();
            tbId = new TextBox();
            lblName = new Label();
            tbName = new TextBox();
            lblAge = new Label();
            tbAge = new TextBox();
            lblGender = new Label();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            lblPhone = new Label();
            tbPhone = new TextBox();
            lblBirth = new Label();
            dtBirth = new DateTimePicker();
            lblPosition = new Label();
            cbPosition = new ComboBox();
            picAvatar = new PictureBox();
            btChooseImage = new Button();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeight = 29;
            dgvEmployee.Location = new Point(20, 20);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1050, 200);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblId);
            gbInfo.Controls.Add(tbId);
            gbInfo.Controls.Add(lblName);
            gbInfo.Controls.Add(tbName);
            gbInfo.Controls.Add(lblAge);
            gbInfo.Controls.Add(tbAge);
            gbInfo.Controls.Add(lblGender);
            gbInfo.Controls.Add(rbNam);
            gbInfo.Controls.Add(rbNu);
            gbInfo.Controls.Add(lblPhone);
            gbInfo.Controls.Add(tbPhone);
            gbInfo.Controls.Add(lblBirth);
            gbInfo.Controls.Add(dtBirth);
            gbInfo.Controls.Add(lblPosition);
            gbInfo.Controls.Add(cbPosition);
            gbInfo.Controls.Add(picAvatar);
            gbInfo.Controls.Add(btChooseImage);
            gbInfo.Location = new Point(20, 240);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(800, 260);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = " ";
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(64, 23);
            lblId.TabIndex = 0;
            lblId.Text = "Mã NV";
            // 
            // tbId
            // 
            tbId.Location = new Point(90, 37);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 27);
            tbId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Họ tên";
            // 
            // tbName
            // 
            tbName.Location = new Point(90, 77);
            tbName.Name = "tbName";
            tbName.Size = new Size(174, 27);
            tbName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 120);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(64, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi";
            // 
            // tbAge
            // 
            tbAge.Location = new Point(90, 117);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 27);
            tbAge.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(20, 160);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(75, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính";
            // 
            // rbNam
            // 
            rbNam.Location = new Point(101, 160);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(89, 24);
            rbNam.TabIndex = 7;
            rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            rbNu.Location = new Point(196, 160);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(104, 24);
            rbNu.TabIndex = 8;
            rbNu.Text = "Nữ";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(289, 40);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 23);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "SĐT";
            lblPhone.Click += lblPhone_Click;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(370, 37);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(131, 27);
            tbPhone.TabIndex = 10;
            // 
            // lblBirth
            // 
            lblBirth.Location = new Point(289, 81);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(75, 23);
            lblBirth.TabIndex = 11;
            lblBirth.Text = "Ngày sinh";
            lblBirth.Click += lblBirth_Click;
            // 
            // dtBirth
            // 
            dtBirth.Location = new Point(370, 80);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(200, 27);
            dtBirth.TabIndex = 12;
            dtBirth.ValueChanged += dtBirth_ValueChanged;
            // 
            // lblPosition
            // 
            lblPosition.Location = new Point(289, 120);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(75, 23);
            lblPosition.TabIndex = 13;
            lblPosition.Text = "Chức vụ";
            // 
            // cbPosition
            // 
            cbPosition.Location = new Point(370, 117);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(121, 28);
            cbPosition.TabIndex = 14;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(613, 23);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(140, 140);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 15;
            picAvatar.TabStop = false;
            picAvatar.Click += picAvatar_Click;
            // 
            // btChooseImage
            // 
            btChooseImage.Location = new Point(648, 169);
            btChooseImage.Name = "btChooseImage";
            btChooseImage.Size = new Size(75, 28);
            btChooseImage.TabIndex = 16;
            btChooseImage.Text = "Chọn ảnh";
            btChooseImage.Click += btChooseImage_Click;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(853, 260);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(131, 43);
            btAddNew.TabIndex = 2;
            btAddNew.Text = "THÊM";
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(853, 320);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(131, 46);
            btEdit.TabIndex = 3;
            btEdit.Text = "SỬA";
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(853, 381);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(131, 43);
            btDelete.TabIndex = 4;
            btDelete.Text = "XÓA";
            btDelete.Click += btDelete_Click;
            // 
            // FormQL
            // 
            ClientSize = new Size(1100, 550);
            Controls.Add(dgvEmployee);
            Controls.Add(gbInfo);
            Controls.Add(btAddNew);
            Controls.Add(btEdit);
            Controls.Add(btDelete);
            Name = "FormQL";
            Text = "Quản Lý Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }
    }
}
