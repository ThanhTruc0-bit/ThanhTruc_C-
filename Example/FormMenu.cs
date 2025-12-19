using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            // 1. Panel Tiêu đề (Header)
            Panel pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.FromArgb(44, 62, 80)
            };
            Label lblTitle = new Label
            {
                Text = "DANH SÁCH BÀI TẬP THỰC HÀNH",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlHeader.Controls.Add(lblTitle);

            // 2. Khu vực chứa nút bấm (FlowLayoutPanel tự động xếp hàng)
            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(30),
                AutoScroll = true, // Tự hiện thanh cuộn nếu nhiều bài tập
                BackColor = Color.FromArgb(236, 240, 241)
            };

            // 3. Nút Quản Lý Nhân Viên (Ưu tiên nằm đầu tiên)
            Button btnQL = CreateStyledButton("QUẢN LÝ NHÂN VIÊN", Color.FromArgb(46, 204, 113));
            btnQL.Width = 260; // Nút này to hơn cho nổi bật
            btnQL.Click += (s, e) => OpenForm(new FormLogin());
            flow.Controls.Add(btnQL);

            // 4. Vòng lặp tạo 22 nút bài tập
            string currentNamespace = this.GetType().Namespace;
            for (int i = 1; i <= 22; i++)
            {
                int baiIndex = i; // Biến cục bộ để tránh lỗi vòng lặp
                Button btn = CreateStyledButton("Bài " + baiIndex, Color.FromArgb(52, 152, 219));

                btn.Click += (s, e) => {
                    try
                    {
                        // Tìm Class Form theo tên (Ví dụ: Example.Form1)
                        string formName = currentNamespace + ".Form" + baiIndex;
                        Type t = Type.GetType(formName);

                        if (t != null)
                        {
                            Form f = (Form)Activator.CreateInstance(t);
                            OpenForm(f);
                        }
                        else
                        {
                            MessageBox.Show($"Chưa tạo file Form{baiIndex}.cs", "Thông báo");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                };
                flow.Controls.Add(btn);
            }

            this.Controls.Add(flow);
            this.Controls.Add(pnlHeader);
        }

        // Hàm tạo style cho nút bấm (giống phong cách Web)
        private Button CreateStyledButton(string text, Color bgColor)
        {
            Button btn = new Button
            {
                Text = text,
                Width = 120,
                Height = 50,
                Margin = new Padding(10),
                BackColor = bgColor,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;

            // Hiệu ứng Hover
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(34, 47, 62);
            btn.MouseLeave += (s, e) => btn.BackColor = bgColor;

            return btn;
        }

        private void OpenForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}