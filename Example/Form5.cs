using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Form5 : Form
    {
        decimal workingMemory = 0;
        string opr = "";

        public Form5()
        {
            InitializeComponent();
        }

        // --- Xử lý nút số ---
        // Đã sửa logic bt2_Click từ gán (=) sang nối (+=)

        private void bt0_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "0")
            {
                tbDisplay.Text += bt0.Text;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            // Logic cho nút 3: Nối Text
            tbDisplay.Text += bt3.Text;
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            // Logic cho nút Dấu chấm (.): Chỉ cho phép thêm 1 dấu chấm
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += btDot.Text;
            }
        }

        // --- Xử lý nút Phép toán (+ / *) ---

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // --- Xử lý nút Bằng (=) ---

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);

            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            }

            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString();
            }

            workingMemory = 0;
            opr = "";
        }
    }
}