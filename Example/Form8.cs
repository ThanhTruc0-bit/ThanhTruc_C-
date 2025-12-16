using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form8 : Form
    {
        // Constructor, cần thiết để khởi tạo các control (InitializeComponent())
        public Form8()
        {
            InitializeComponent();
        }

        // Phương thức tạo danh sách dữ liệu (GetData)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            // Khởi tạo và thêm dữ liệu mẫu
            Faculty f1 = new Faculty { Id = "K01", Name = "Công nghệ thông tin", Quantity = 1200 };
            lst.Add(f1);

            Faculty f2 = new Faculty { Id = "K02", Name = "Quản trị kinh doanh", Quantity = 4200 };
            lst.Add(f2);

            // Đã đổi Id thành K03 để đảm bảo tính duy nhất
            Faculty f3 = new Faculty { Id = "K03", Name = "Kế toán tài chính", Quantity = 5200 };
            lst.Add(f3);

            return lst;
        }

        // Xử lý sự kiện Load Form
        private void Form8_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Gán nguồn dữ liệu
            cb_Faculty.DataSource = lst;

            // Thiết lập trường hiển thị trên ComboBox
            cb_Faculty.DisplayMember = "Name";

            // Thiết lập trường giá trị (Value) sẽ được truy xuất
            cb_Faculty.ValueMember = "Id";

            // Chọn mục đầu tiên làm mặc định
            cb_Faculty.SelectedIndex = 0;
        }

        // Xử lý sự kiện khi giá trị (Id) được chọn thay đổi
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra để tránh lỗi null khi form vừa load xong
            if (cb_Faculty.SelectedValue != null)
            {
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
            }
        }

        // Xử lý sự kiện khi nhấn nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedValue != null)
            {
                // Lấy tên khoa đang được hiển thị
                string name = cb_Faculty.Text;
                tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
            }
            else
            {
                tbDisplay.Text = "Vui lòng chọn một khoa.";
            }
        }

        // Xử lý sự kiện khi nhấn nút Clear
        private void btClear_Click(object sender, EventArgs e)
        {
            // Bỏ chọn tất cả
            cb_Faculty.SelectedIndex = -1;
            tbDisplay.Text = string.Empty;
        }
    }
}