namespace Example
{
    partial class FormQL
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.Button btAddNew, btEdit, btDelete;
        private System.Windows.Forms.Label lblId, lblName, lblAge, lblGender;

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
            pbAvatar = new PictureBox();
            btnBrowse = new Button();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeight = 29;
            dgvEmployee.Location = new Point(15, 15);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 45;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(755, 180);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
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
            gbInfo.Controls.Add(pbAvatar);
            gbInfo.Controls.Add(btnBrowse);
            gbInfo.Location = new Point(15, 210);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(560, 215);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin nhân sự";
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(64, 23);
            lblId.TabIndex = 0;
            lblId.Text = "Mã NV:";
            // 
            // tbId
            // 
            tbId.Location = new Point(90, 31);
            tbId.Name = "tbId";
            tbId.Size = new Size(120, 27);
            tbId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Họ tên:";
            // 
            // tbName
            // 
            tbName.Location = new Point(90, 71);
            tbName.Name = "tbName";
            tbName.Size = new Size(220, 27);
            tbName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(20, 115);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(64, 23);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi:";
            // 
            // tbAge
            // 
            tbAge.Location = new Point(90, 112);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(120, 27);
            tbAge.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(20, 153);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 23);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính:";
            // 
            // rbNam
            // 
            rbNam.Checked = true;
            rbNam.Location = new Point(100, 153);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(60, 20);
            rbNam.TabIndex = 7;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            rbNu.Location = new Point(170, 153);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(60, 20);
            rbNu.TabIndex = 8;
            rbNu.Text = "Nữ";
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.White;
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(360, 25);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(160, 145);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 9;
            pbAvatar.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(360, 175);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(160, 30);
            btnBrowse.TabIndex = 10;
            btnBrowse.Text = "Chọn ảnh...";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btAddNew
            // 
            btAddNew.BackColor = Color.LightGreen;
            btAddNew.Location = new Point(590, 220);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(175, 40);
            btAddNew.TabIndex = 2;
            btAddNew.Text = "THÊM MỚI";
            btAddNew.UseVisualStyleBackColor = false;
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.LightBlue;
            btEdit.Location = new Point(590, 275);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(175, 40);
            btEdit.TabIndex = 3;
            btEdit.Text = "SỬA THÔNG TIN";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.LightPink;
            btDelete.Location = new Point(590, 330);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(175, 40);
            btDelete.TabIndex = 4;
            btDelete.Text = "XÓA NHÂN VIÊN";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // FormQL
            // 
            ClientSize = new Size(784, 440);
            Controls.Add(dgvEmployee);
            Controls.Add(gbInfo);
            Controls.Add(btAddNew);
            Controls.Add(btEdit);
            Controls.Add(btDelete);
            Name = "FormQL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên - Thanh Trúc";
            FormClosed += FormQL_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
        }
    }
}