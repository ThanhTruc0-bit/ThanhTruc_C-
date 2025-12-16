namespace Example
{
    partial class Form10
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpDate; // Khai báo dtpDate
        private System.Windows.Forms.Button btnOK;           // Khai báo btnOK

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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // dtpDate
            this.dtpDate.Location = new System.Drawing.Point(20, 20);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(235, 18);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click); // Gắn sự kiện Click

            // Form10
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 70);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpDate);
            this.Name = "Form10";
            this.ResumeLayout(false);
        }

        #endregion
    }
}