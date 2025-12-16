namespace Example
{
    partial class Form9 
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

        private void InitializeComponent()
        {
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
       
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(260, 22);
            this.tbName.TabIndex = 0;
            this.tbName.Text = "Nguyễn Văn A";
          
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
           
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(100, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(46, 20);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
         
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(20, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
          
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Checked = true;
            this.ckDiscount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDiscount.Location = new System.Drawing.Point(12, 100);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(89, 20);
            this.ckDiscount.TabIndex = 2;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;
            this.ckDiscount.CheckedChanged += new System.EventHandler(this.ckDiscount_CheckedChanged);
          
            this.tbDiscount.Location = new System.Drawing.Point(107, 98);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(165, 22);
            this.tbDiscount.TabIndex = 3;
            this.tbDiscount.Text = "7"; // Giá trị 7%
        
            this.tbResult.Location = new System.Drawing.Point(12, 130);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(260, 60);
            this.tbResult.TabIndex = 4;
      
            this.btRun.Location = new System.Drawing.Point(117, 205);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 29);
            this.btRun.TabIndex = 5;
            this.btRun.Text = "Tính tiền";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
        
            this.btExit.Location = new System.Drawing.Point(197, 205);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 29);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
     
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbName);
            this.Name = "Form9"; 
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load); 
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btExit;
    }
}