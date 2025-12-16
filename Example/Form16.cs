using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

// Tên file: Form1.cs
namespace Example
{
    public partial class Form16 : Form
    {
        // Khai báo List để lưu trữ danh sách nhân viên
        List<Employee> lst = new List<Employee>();

        public Form16()
        {
            InitializeComponent();
            // Thiết lập cột cho DataGridView (Quan trọng để hiển thị dữ liệu)
            // Cần có 4 cột: Mã nhân viên, Tên nhân viên, Tuổi, Giới tính (Nam)
            // (Đoạn này thường được cấu hình trong Designer, nhưng tôi thêm vào đây)
            // Bạn có thể dùng Bound Column Properties như ảnh bạn gửi.

            // Cấu hình cột thủ công để phù hợp với hiển thị trong ảnh
            dgvEmployee.ColumnCount = 4;
            dgvEmployee.Columns[0].Name = "Mã nhân viên";
            dgvEmployee.Columns[0].DataPropertyName = "Id"; // Dùng khi DataBinding
            dgvEmployee.Columns[1].Name = "Tên nhân viên";
            dgvEmployee.Columns[1].DataPropertyName = "Name";
            dgvEmployee.Columns[2].Name = "Tuổi";
            dgvEmployee.Columns[2].DataPropertyName = "Age";
            dgvEmployee.Columns[3].Name = "Giới tính (Nam)";
            dgvEmployee.Columns[3].DataPropertyName = "Gender";

            // Chuyển cột cuối cùng thành CheckBoxColumn để giống với ảnh
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "Giới tính (Nam)";
            checkColumn.DataPropertyName = "Gender";
            dgvEmployee.Columns.RemoveAt(3); // Xóa cột Text Box cũ
            dgvEmployee.Columns.Add(checkColumn); // Thêm cột Check Box mới vào cuối
        }

        // Hàm tạo dữ liệu mẫu
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiên";
            em.Age = 20;
            em.Gender = true; // Nam
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            em.Gender = false; // Nữ/Khác
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hảo";
            em.Age = 23;
            em.Gender = true; // Nam
            lst.Add(em);

            return lst;
        }

        // Sự kiện xảy ra khi Form được tải (Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();

            // Duyệt qua danh sách và thêm từng nhân viên vào DataGridView
            foreach (Employee em in lst)
            {
                // Thêm dữ liệu vào các ô theo thứ tự đã định nghĩa (Id, Name, Age, Gender)
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // Xử lý sự kiện khi nhấn nút "Thêm" (btAddNew)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // 1. Tạo đối tượng Employee mới từ dữ liệu nhập vào
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;

            // Xử lý chuyển đổi Age từ Text sang Int (nên có kiểm tra lỗi)
            if (int.TryParse(tbAge.Text, out int age))
            {
                em.Age = age;
            }
            else
            {
                MessageBox.Show("Tuổi phải là một số nguyên hợp lệ.");
                return;
            }

            em.Gender = ckGender.Checked;

            // 2. Thêm vào List (lst)
            lst.Add(em);

            // 3. Thêm vào DataGridView (dgvEmployee)
            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);

            // (Thường thì sẽ xóa trắng các TextBox sau khi thêm)
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            ckGender.Checked = false;
        }

        // Xử lý sự kiện khi nhấn nút "Xóa" (btDelete)
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Lấy chỉ mục (index) của hàng đang được chọn
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1) // Tránh hàng trống cuối cùng
                {
                    // 1. Xóa khỏi List (lst)
                    lst.RemoveAt(idx);

                    // 2. Xóa khỏi DataGridView (dgvEmployee)
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        // Xử lý sự kiện khi nhấn nút "Thoát" (btExit)
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lý sự kiện khi con trỏ chuột vào một hàng trong DataGridView (để hiển thị chi tiết)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Đảm bảo không phải là hàng trống cuối cùng (new row)
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                // Lấy giá trị từ các ô và gán vào TextBox/CheckBox tương ứng
                // Cell[0]: Id, Cell[1]: Name, Cell[2]: Age, Cell[3]: Gender (bool)
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Chuyển giá trị Giới tính từ string/object sang bool để gán cho CheckBox
                // Lưu ý: Value của DataGridViewCheckBoxColumn có thể là bool hoặc null/DBNull
                object genderValue = dgvEmployee.Rows[idx].Cells[3].Value;

                if (genderValue != null && genderValue != DBNull.Value)
                {
                    // Sử dụng bool.TryParse an toàn hơn
                    bool isMale;
                    if (bool.TryParse(genderValue.ToString(), out isMale))
                    {
                        ckGender.Checked = isMale;
                    }
                    else
                    {
                        // Xử lý trường hợp không phải True/False (Nếu cần)
                        ckGender.Checked = false;
                    }
                }
                else
                {
                    ckGender.Checked = false;
                }
            }
        }
    }
}