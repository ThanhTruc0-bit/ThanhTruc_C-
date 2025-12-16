// Tên file: Form15.Designer.cs

namespace Example
{
    partial class Form15
    {
        // Khai báo các Controls (private fields)
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaNV,
                this.colTenNV,
                this.colTuoi,
                this.colGioiTinh});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(560, 250);
            this.dgvEmployee.TabIndex = 0;
            // Gán sự kiện RowEnter
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 120;
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "Tên nhân viên";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Width = 180;
            // 
            // colTuoi
            // 
            this.colTuoi.HeaderText = "Tuổi";
            this.colTuoi.Name = "colTuoi";
            this.colTuoi.Width = 80;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới tính (Nam)";
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(90, 300);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(90, 330);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(90, 360);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 3;
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(90, 390);
            this.ckGender.Name = "ckGender";
            this.ckGender.Text = "Nam";
            this.ckGender.Size = new System.Drawing.Size(50, 17);
            this.ckGender.TabIndex = 4;
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(340, 420);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 5;
            this.btAddNew.UseVisualStyleBackColor = true;
            // Gán sự kiện Click
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(425, 420);
            this.btDelete.Name = "btDelete";
            this.btDelete.Text = "Xóa";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.UseVisualStyleBackColor = true;
            // Gán sự kiện Click
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(510, 420);
            this.btExit.Name = "btExit";
            this.btExit.Text = "Thoát";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 7;
            this.btExit.UseVisualStyleBackColor = true;
            // Gán sự kiện Click (giả định)
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 303);
            this.label1.Text = "Mã";
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 333);
            this.label2.Text = "Tên";
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 363);
            this.label3.Text = "Tuổi";
            this.label3.Name = "label3";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form15";
            this.Text = "Form1";
            // Gán sự kiện Load
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}