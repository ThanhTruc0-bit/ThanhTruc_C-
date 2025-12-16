// File: Form13.Designer.cs

namespace Example
{
    partial class Form13
    {
        // Khai báo các Controls (ListBox, Button, Label)
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btRemove; // Nút Xóa (<)
        private System.Windows.Forms.Label lblSongList;
        private System.Windows.Forms.Label lblFavoriteList;

        /// <summary>
        /// Phương thức cần thiết để hỗ trợ Designer - không được sửa đổi
        /// nội dung của phương thức này bằng trình chỉnh sửa mã.
        /// </summary>
        private void InitializeComponent()
        {
            // 1. Khởi tạo Controls
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lblSongList = new System.Windows.Forms.Label();
            this.lblFavoriteList = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 2. Thiết lập lbSong (Danh sách bài hát)
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Location = new System.Drawing.Point(20, 40);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(200, 200);
            this.lbSong.TabIndex = 0;

            // 3. Thiết lập lblSongList (Label Danh sách bài hát)
            this.lblSongList.AutoSize = true;
            this.lblSongList.Location = new System.Drawing.Point(20, 15);
            this.lblSongList.Name = "lblSongList";
            this.lblSongList.Size = new System.Drawing.Size(91, 13);
            this.lblSongList.Text = "Danh sách bài hát";

            // 4. Thiết lập btSelect (Nút >)
            this.btSelect.Location = new System.Drawing.Point(240, 100);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(50, 23);
            this.btSelect.TabIndex = 2;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click); // Gán sự kiện Click

            // 5. Thiết lập btRemove (Nút <)
            this.btRemove.Location = new System.Drawing.Point(240, 140);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(50, 23);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "<";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click); // Gán sự kiện Click

            // 6. Thiết lập lbFavorite (Danh sách yêu thích)
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.Location = new System.Drawing.Point(310, 40);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(200, 200);
            this.lbFavorite.TabIndex = 4;

            // 7. Thiết lập lblFavoriteList (Label Danh sách bài hát yêu thích)
            this.lblFavoriteList.AutoSize = true;
            this.lblFavoriteList.Location = new System.Drawing.Point(310, 15);
            this.lblFavoriteList.Name = "lblFavoriteList";
            this.lblFavoriteList.Size = new System.Drawing.Size(126, 13);
            this.lblFavoriteList.Text = "Danh sách bài hát ưa thích";

            // 8. Thiết lập Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 270);

            // Thêm tất cả Controls vào Form
            this.Controls.Add(this.lblFavoriteList);
            this.Controls.Add(this.lblSongList);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.lbSong);
            this.Name = "Form1";
            this.Text = "Music";
            this.Load += new System.EventHandler(this.Form1_Load); // Gán sự kiện Form Load
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}