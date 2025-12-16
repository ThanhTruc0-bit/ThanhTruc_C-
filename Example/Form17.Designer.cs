namespace Example
{
    partial class Form17
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
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLeft
            // 
            this.btLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft.Location = new System.Drawing.Point(120, 250); // Vị trí giả định
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(40, 30);
            this.btLeft.TabIndex = 0;
            this.btLeft.Text = "<";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight.Location = new System.Drawing.Point(165, 250); // Vị trí giả định
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(40, 30);
            this.btRight.TabIndex = 1;
            this.btRight.Text = ">";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(230, 250); // Vị trí giả định
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(75, 30);
            this.btFile.TabIndex = 2;
            this.btFile.Text = "File...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311); // Kích thước giả định
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.MaximizeBox = false;
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btFile;
    }
}