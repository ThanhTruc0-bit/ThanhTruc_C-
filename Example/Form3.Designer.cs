using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Form3
    {
        // Khai báo các Control
        private IContainer components = null;
        private TextBox tbYear;
        private TextBox tbPhoneNumber;
        private Label lblYear;
        private Label lblPhoneNumber;

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
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(120, 20);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(200, 27);
            this.tbYear.TabIndex = 0;
            // Gán các sự kiện
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            this.tbYear.Validating += new System.ComponentModel.CancelEventHandler(this.tbYear_Validating);

            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(120, 55);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(200, 27);
            this.tbPhoneNumber.TabIndex = 1;
            // Gán sự kiện KeyPress
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);

            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(20, 23);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.Text = "Year";
            this.lblYear.TabIndex = 2;

            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 58);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.TabIndex = 3;

            // 
            // Form3 (Form Chính)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 100);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbYear);
            this.Name = "Form3";
            this.Text = "Form3"; // Đặt tên Form theo ảnh
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}