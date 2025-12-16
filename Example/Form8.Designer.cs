namespace Example
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(12, 12);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(260, 24);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedValueChanged += new System.EventHandler(this.cb_Faculty_SelectedValueChanged); // Liên kết sự kiện Data Binding

            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 50);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(260, 50);
            this.tbDisplay.TabIndex = 1;

            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(197, 110);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 25);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);

            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(116, 110);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 25);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);

            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form8";
            this.Text = "Form8 Data Binding";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo controls
        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btClear;
    }
}