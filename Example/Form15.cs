using System;
using System.Collections;
// Cần thiết cho logic trong code
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example
{
    // Dùng partial để chia lớp này với Form15.Designer.cs
    public partial class Form15 : Form
    {
        // Khai báo biến List
        ArrayList lstEm;

        // Constructor
        public Form15()
        {
            InitializeComponent(); // Gọi phương thức khởi tạo các control (được định nghĩa trong file Designer)
            lstEm = new ArrayList();
        }

        // Sự kiện Form Load
        private void Form15_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu mẫu (dựa trên ảnh giao diện)
            if (dgvEmployee.Rows.Count == 0)
            {
                dgvEmployee.Rows.Add("53418", "Trần Tiến", "20", true);
                dgvEmployee.Rows.Add("53416", "Nguyễn Cường", "25", false);
                dgvEmployee.Rows.Add("53417", "Nguyễn Hảo", "23", true);
            }
        }

        // Sự kiện Click của nút "Thêm" (btAddNew)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                // Thêm một hàng mới vào DataGridView
                dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);

                // Reset Input (Optional)
                tbId.Clear();
                tbName.Clear();
                tbAge.Clear();
                ckGender.Checked = false;
                tbId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện Click của nút "Xóa" (btDelete)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;

                // Đảm bảo không xóa hàng mới (New Row)
                if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dgvEmployee.Rows.RemoveAt(idx);
                        // Reset Input (Optional)
                        tbId.Clear();
                        tbName.Clear();
                        tbAge.Clear();
                        ckGender.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện khi con trỏ vào một hàng của DataGridView (dgvEmployee_RowEnter)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Đảm bảo hàng được chọn không phải là hàng trống cuối cùng
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString();

                object genderValue = dgvEmployee.Rows[idx].Cells[3].Value;
                if (genderValue != null && genderValue != DBNull.Value)
                {
                    if (bool.TryParse(genderValue.ToString(), out bool isMale))
                    {
                        ckGender.Checked = isMale;
                    }
                    else
                    {
                        // Xử lý nếu giá trị không phải là bool rõ ràng
                        ckGender.Checked = genderValue.ToString().Equals("True", StringComparison.OrdinalIgnoreCase) ||
                                           genderValue.ToString() == "1";
                    }
                }
                else
                {
                    ckGender.Checked = false;
                }
            }
            else
            {
                // Xóa dữ liệu hiển thị nếu chọn hàng trống
                tbId.Clear();
                tbName.Clear();
                tbAge.Clear();
                ckGender.Checked = false;
            }
        }

        // Sự kiện Click của nút "Thoát" (btExit) - Giả định
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}