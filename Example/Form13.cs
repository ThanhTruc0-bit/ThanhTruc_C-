// File: Form13.cs

using System;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Example // Giả sử tên project của bạn là Example
{
    // Đảm bảo Form1 thừa kế từ System.Windows.Forms.Form
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        // --- PHẦN 1: TẠO DỮ LIỆU ---

        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            // Dữ liệu mẫu (mở rộng để khớp với giao diện)

            Song s1 = new Song { Id = 53418, Name = "Giấc mơ cha pi", Author = "Trần Tiến" };
            lst.Add(s1);

            Song s2 = new Song { Id = 52616, Name = "Đôi mắt Pleiku", Author = "Nguyễn Cường" };
            lst.Add(s2);

            Song s3 = new Song { Id = 51172, Name = "Em muốn sống bên anh trọn đời", Author = "Nguyễn Cường" };
            lst.Add(s3);

            Song s4 = new Song { Id = 50000, Name = "H'Zen Lên Rẫy", Author = "Nguyễn Cường" };
            lst.Add(s4);

            Song s5 = new Song { Id = 50001, Name = "Còn Thương Nhau Thì Về Buôn Mê Thuột", Author = "Nguyễn Cường" };
            lst.Add(s5);

            Song s6 = new Song { Id = 50002, Name = "Lý Cà Phê Ban Mê", Author = "Nguyễn Cường" };
            lst.Add(s6);

            Song s7 = new Song { Id = 50003, Name = "Đi tìm lời ru mặt trời", Author = "Nguyễn Cường" };
            lst.Add(s7);

            return lst;
        }

        // --- PHẦN 2: SỰ KIỆN FORM LOAD ---

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Gán danh sách bài hát (lst) làm nguồn dữ liệu cho ListBox trái (lbSong)
            this.lbSong.DataSource = lst;

            // Chỉ hiển thị thuộc tính Name của đối tượng Song trong ListBox
            this.lbSong.DisplayMember = "Name";
            this.lbSong.ValueMember = "Id"; // Có thể thêm ValueMember nếu cần

            this.Text = "Music"; // Đặt tiêu đề Form
        }

        // --- PHẦN 3: SỰ KIỆN NÚT CHỌN ( > ) ---

        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn không
            if (this.lbSong.SelectedItem != null)
            {
                // Ép kiểu mục được chọn thành đối tượng Song
                Song song = (Song)this.lbSong.SelectedItem;

                // Lấy thông tin
                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;

                // Chuỗi định dạng: ID - Tên - Tác giả
                string formattedSong = $"{id} - {name} - {author}";

                // Thêm vào ListBox yêu thích (lbFavorite)
                this.lbFavorite.Items.Add(formattedSong);
            }
        }

        // --- PHẦN BỔ SUNG: NÚT XÓA ( < ) ---

        private void btRemove_Click(object sender, EventArgs e)
        {
            // Xóa mục được chọn khỏi ListBox yêu thích
            if (this.lbFavorite.SelectedItem != null)
            {
                this.lbFavorite.Items.Remove(this.lbFavorite.SelectedItem);
            }
        }
    }
}