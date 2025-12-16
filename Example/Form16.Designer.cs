namespace Example
{
    partial class Form16
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(776, 250);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 280);
            this.lblId.Name = "lblId";
            this.lblId.Text = "Mã:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(30, 310);
            this.lblTen.Name = "lblTen";
            this.lblTen.Text = "Tên:";
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(30, 340);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Text = "Tuổi:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(70, 277);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(200, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(70, 307);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(70, 337);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 20);
            this.tbAge.TabIndex = 3;
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.Location = new System.Drawing.Point(70, 363);
            this.ckGender.Name = "ckGender";
            this.ckGender.Text = "Nam";
            this.ckGender.TabIndex = 4;
            this.ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(450, 400);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Text = "Thêm";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(550, 400);
            this.btDelete.Name = "btDelete";
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(650, 400);
            this.btExit.Name = "btExit";
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các Controls
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExit;

    }
}