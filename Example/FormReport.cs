using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Example
{
    public partial class FormReport : Form
    {
        public FormReport(DataGridView source)
        {
            InitializeComponent();
            InitUI();
            LoadReport(source);
        }

        private void InitUI()
        {
            lblTotal.Font =
            lblMale.Font =
            lblFemale.Font =
            lblAvgAge.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            lblTotal.BackColor = Color.FromArgb(52, 152, 219);
            lblMale.BackColor = Color.FromArgb(46, 204, 113);
            lblFemale.BackColor = Color.FromArgb(231, 76, 60);

            lblTotal.ForeColor =
            lblMale.ForeColor =
            lblFemale.ForeColor = Color.White;

            dgvReport.AllowUserToAddRows = false;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadReport(DataGridView src)
        {
            int total = src.Rows.Count;
            int male = 0;
            int female = 0;
            int ageSum = 0;

            dgvReport.Columns.Clear();
            dgvReport.Columns.Add("position", "Chức vụ");
            dgvReport.Columns.Add("count", "Số lượng");

            var positionGroups = src.Rows
                .Cast<DataGridViewRow>()
                .GroupBy(r => r.Cells[6].Value?.ToString());

            foreach (var g in positionGroups)
            {
                dgvReport.Rows.Add(g.Key, g.Count());
            }

            foreach (DataGridViewRow r in src.Rows)
            {
                if (r.Cells[3].Value?.ToString() == "Nam") male++;
                else female++;

                int age;
                if (int.TryParse(r.Cells[2].Value?.ToString(), out age))
                    ageSum += age;
            }

            lblTotal.Text = $"👥 Tổng nhân viên: {total}";
            lblMale.Text = $"👨 Nam: {male}";
            lblFemale.Text = $"👩 Nữ: {female}";

            lblAvgAge.Text = total > 0
                ? $"📊 Tuổi trung bình: {ageSum / total}"
                : "📊 Tuổi trung bình: 0";
        }
    }
}
