using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class FormQL : Form
    {
        private Image avatarImage = null;

        // ===== PUBLIC PROPERTY để Dashboard / Report truy cập =====
        public DataGridView EmployeeGrid
        {
            get { return dgvEmployee; }
        }

        public FormQL()
        {
            InitializeComponent();

            InitComboBox();
            InitGrid();
            InitValidation();
            InitButtonStyle();
            InitGridUI();   // UI highlight cho DataGridView
            InitFormUI();   // UI tổng thể
        }

        // ================= COMBOBOX =================
        private void InitComboBox()
        {
            cbPosition.Items.AddRange(new string[]
            {
                "Nhân viên",
                "Trưởng phòng",
                "Quản lý",
                "Giám đốc"
            });
            cbPosition.SelectedIndex = 0;
        }

        // ================= GRID =================
        private void InitGrid()
        {
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.MultiSelect = false;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmployee.Columns.Clear();
            dgvEmployee.Columns.Add("manv", "Mã NV");
            dgvEmployee.Columns.Add("hoten", "Họ tên");
            dgvEmployee.Columns.Add("tuoi", "Tuổi");
            dgvEmployee.Columns.Add("gioitinh", "Giới tính");
            dgvEmployee.Columns.Add("sdt", "SĐT");
            dgvEmployee.Columns.Add("ngaysinh", "Ngày sinh");
            dgvEmployee.Columns.Add("chucvu", "Chức vụ");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "anh";
            imgCol.HeaderText = "Ảnh";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEmployee.Columns.Add(imgCol);
        }

        // ================= GRID UI HIGHLIGHT =================
        private void InitGridUI()
        {
            dgvEmployee.BorderStyle = BorderStyle.None;
            dgvEmployee.RowTemplate.Height = 40;

            dgvEmployee.EnableHeadersVisualStyles = false;
            dgvEmployee.ColumnHeadersHeight = 42;
            dgvEmployee.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(33, 150, 243);
            dgvEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmployee.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvEmployee.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
            dgvEmployee.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 152, 219);
            dgvEmployee.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvEmployee.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 247, 250);
        }

        // ================= VALIDATION =================
        private void InitValidation()
        {
            tbPhone.KeyPress += OnlyNumber;
            tbAge.KeyPress += OnlyNumber;
            tbName.KeyPress += OnlyText;
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void OnlyText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetter(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // ================= AVATAR =================
        private void btChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    avatarImage = Image.FromFile(ofd.FileName);
                    picAvatar.Image = avatarImage;
                }
            }
        }

        // ================= ADD =================
        private void btAddNew_Click(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Add(
                tbId.Text,
                tbName.Text,
                tbAge.Text,
                rbNam.Checked ? "Nam" : "Nữ",
                tbPhone.Text,
                dtBirth.Value.ToShortDateString(),
                cbPosition.Text,
                avatarImage
            );
            ClearFields();
        }

        // ================= SELECT =================
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvEmployee.Rows[e.RowIndex];

            tbId.Text = r.Cells[0].Value?.ToString();
            tbName.Text = r.Cells[1].Value?.ToString();
            tbAge.Text = r.Cells[2].Value?.ToString();
            tbPhone.Text = r.Cells[4].Value?.ToString();
            dtBirth.Text = r.Cells[5].Value?.ToString();
            cbPosition.Text = r.Cells[6].Value?.ToString();

            rbNam.Checked = r.Cells[3].Value?.ToString() == "Nam";
            rbNu.Checked = !rbNam.Checked;

            avatarImage = r.Cells[7].Value as Image;
            picAvatar.Image = avatarImage;
        }

        // ================= EDIT =================
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            DataGridViewRow r = dgvEmployee.CurrentRow;

            r.Cells[0].Value = tbId.Text;
            r.Cells[1].Value = tbName.Text;
            r.Cells[2].Value = tbAge.Text;
            r.Cells[3].Value = rbNam.Checked ? "Nam" : "Nữ";
            r.Cells[4].Value = tbPhone.Text;
            r.Cells[5].Value = dtBirth.Value.ToShortDateString();
            r.Cells[6].Value = cbPosition.Text;
            r.Cells[7].Value = avatarImage;

            MessageBox.Show("Cập nhật thành công!");
        }

        // ================= DELETE =================
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                dgvEmployee.Rows.RemoveAt(dgvEmployee.CurrentRow.Index);
                ClearFields();
            }
        }

        // ================= CLEAR =================
        private void ClearFields()
        {
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            tbPhone.Clear();
            rbNam.Checked = true;
            picAvatar.Image = null;
            avatarImage = null;
        }

        // ================= BUTTON STYLE =================
        private void InitButtonStyle()
        {
            btAddNew.BackColor = Color.FromArgb(46, 204, 113);
            btEdit.BackColor = Color.FromArgb(52, 152, 219);
            btDelete.BackColor = Color.FromArgb(231, 76, 60);

            btAddNew.ForeColor =
            btEdit.ForeColor =
            btDelete.ForeColor = Color.White;

            btAddNew.FlatStyle =
            btEdit.FlatStyle =
            btDelete.FlatStyle = FlatStyle.Flat;
        }

        // ================= FORM UI =================
        private void InitFormUI()
        {
            Font uiFont = new Font("Segoe UI", 10);
            foreach (Control c in gbInfo.Controls)
            {
                c.Font = uiFont;
            }
        }

        // ================= EXTRA EVENTS =================
        private void lblPhone_Click(object sender, EventArgs e)
        {
            tbPhone.Focus();
        }

        private void lblBirth_Click(object sender, EventArgs e)
        {
            dtBirth.Select();
        }

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtBirth.Value.Year;
            if (DateTime.Now < dtBirth.Value.AddYears(age))
                age--;

            tbAge.Text = age.ToString();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            btChooseImage.PerformClick();
        }

    }
}
