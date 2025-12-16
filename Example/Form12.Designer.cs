namespace Example
{
    partial class Form12
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
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 16;
            this.lbSong.Location = new System.Drawing.Point(20, 20);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(250, 300);
            this.lbSong.TabIndex = 0;
            // Dữ liệu ban đầu (như trong ảnh)
            this.lbSong.Items.AddRange(new object[] {
                "Giấc mơ Chapi",
                "Đôi Mắt Pleiku",
                "Em Muốn Sống Bên Anh Trọn Đời",
                "H\'Zen Lên Rẫy",
                "Cỏn Thương Nhau Thì Về Buồn Mê Thuật",
                "Lý Cà Phê Ban Mê",
                "Đi tìm lời ru mặt trời"
            });
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 16;
            this.lbFavorite.Location = new System.Drawing.Point(380, 20);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(250, 300);
            this.lbFavorite.TabIndex = 1;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(290, 80);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 30);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            // 
            // btDeselect
            // 
            this.btDeselect.Location = new System.Drawing.Point(290, 130);
            this.btDeselect.Name = "btDeselect";
            this.btDeselect.Size = new System.Drawing.Size(75, 30);
            this.btDeselect.TabIndex = 3;
            this.btDeselect.Text = "<";
            this.btDeselect.UseVisualStyleBackColor = true;
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(290, 30);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(75, 30);
            this.btSelectAll.TabIndex = 4;
            this.btSelectAll.Text = ">>";
            this.btSelectAll.UseVisualStyleBackColor = true;
            // 
            // btDeselectAll
            // 
            this.btDeselectAll.Location = new System.Drawing.Point(290, 180);
            this.btDeselectAll.Name = "btDeselectAll";
            this.btDeselectAll.Size = new System.Drawing.Size(75, 30);
            this.btDeselectAll.TabIndex = 5;
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            this.ClientSize = new System.Drawing.Size(650, 340);
            this.Controls.Add(this.btDeselectAll);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Form12";
            this.Text = "Music - Form12";
            this.ResumeLayout(false);

        }

        #endregion

        // Khai báo các Controls (private fields)
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselectAll;
    }
}