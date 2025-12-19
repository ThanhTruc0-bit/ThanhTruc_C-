using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            // Thêm cột ảnh trực tiếp vào bảng
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Avatar";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 60;
            dgvEmployee.Columns.Add(imgCol);

            dgvEmployee.Columns.Add("id", "Mã NV");
            dgvEmployee.Columns.Add("name", "Họ Tên");
            dgvEmployee.Columns.Add("age", "Tuổi");
            dgvEmployee.Columns.Add("gender", "Giới Tính");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.png;*.jpeg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbAvatar.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            string gender = rbNam.Checked ? "Nam" : "Nữ";
            dgvEmployee.Rows.Add(pbAvatar.Image, tbId.Text, tbName.Text, tbAge.Text, gender);
            ClearFields();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                int i = dgvEmployee.CurrentRow.Index;
                dgvEmployee.Rows[i].Cells[0].Value = pbAvatar.Image;
                dgvEmployee.Rows[i].Cells[1].Value = tbId.Text;
                dgvEmployee.Rows[i].Cells[2].Value = tbName.Text;
                dgvEmployee.Rows[i].Cells[3].Value = tbAge.Text;
                dgvEmployee.Rows[i].Cells[4].Value = rbNam.Checked ? "Nam" : "Nữ";
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                dgvEmployee.Rows.RemoveAt(dgvEmployee.CurrentRow.Index);
                ClearFields();
            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgvEmployee.Rows[i].Cells[1].Value != null)
            {
                pbAvatar.Image = (Image)dgvEmployee.Rows[i].Cells[0].Value;
                tbId.Text = dgvEmployee.Rows[i].Cells[1].Value?.ToString();
                tbName.Text = dgvEmployee.Rows[i].Cells[2].Value?.ToString();
                tbAge.Text = dgvEmployee.Rows[i].Cells[3].Value?.ToString();
                if (dgvEmployee.Rows[i].Cells[4].Value?.ToString() == "Nam") rbNam.Checked = true; else rbNu.Checked = true;
            }
        }

        private void ClearFields()
        {
            tbId.Clear(); tbName.Clear(); tbAge.Clear();
            pbAvatar.Image = null;
            rbNam.Checked = true;
        }

        private void FormQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Ngăn lỗi Locked file .exe
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}