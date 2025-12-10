using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Form6 : Form // Sử dụng Form6
    {
        // Khai báo biến theo hình ảnh
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public Form6()
        {
            InitializeComponent();
        }

        // --- Hàm xử lý sự kiện chung cho TẤT CẢ các nút ---
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // 1. Logic nhập số và dấu thập phân
            if ((char.IsDigit(bt.Text, 0) && bt.Text.Length == 1) || bt.Text == ".")
            {
                txtDisplay.Text += bt.Text;
            }

            // 2. Logic phép toán (+, -, *, /)
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }

            // 3. Logic nút Bằng (=)
            else if (bt.Text == "=")
            {
                decimal secondValue = decimal.Parse(txtDisplay.Text);

                switch (opr)
                {
                    case "+":
                        txtDisplay.Text = (workingMemory + secondValue).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (workingMemory - secondValue).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (workingMemory * secondValue).ToString();
                        break;
                    case "/":
                        txtDisplay.Text = (workingMemory / secondValue).ToString();
                        break;
                }
            }

            // 4. Logic các phép toán đơn (±, √, %, 1/x)
            else if (bt.Text == "±")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = -currVal;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "√")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = (decimal)Math.Sqrt((double)currVal);
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "%")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = currVal / 100;
                txtDisplay.Text = currVal.ToString();
            }
            else if (bt.Text == "1/x")
            {
                decimal currVal = decimal.Parse(txtDisplay.Text);
                currVal = 1 / currVal;
                txtDisplay.Text = currVal.ToString();
            }

            // 5. Logic chức năng bộ nhớ (M+ / M-)
            else if (bt.Text == "M+")
            {
                memory = memory + decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M-")
            {
                memory = memory - decimal.Parse(txtDisplay.Text);
            }

            // 6. Logic chức năng xóa và bộ nhớ (C / CE / MS / MR / MC / Backspace)
            else if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
            }
            else if (bt.Text == "CE")
            {
                txtDisplay.Clear();
            }
            else if (bt.Text == "MS")
            {
                memory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "MR")
            {
                txtDisplay.Text = memory.ToString();
            }
            else if (bt.Text == "MC")
            {
                memory = 0;
            }
            else if (bt.Text == "←")
            {
                if (txtDisplay.TextLength != 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
                }
            }
        }
    }
}