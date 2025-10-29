using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24521840_NT106_Lab2
{
    public partial class Lab2_Bai03 : Form
    {
        public Lab2_Bai03()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input3.txt"))
                {
                    string content =
                        "1 + 2 + 3 + 4\n" +
                        "12 - 7 - 5 + 2 - 3\n" +
                        "2024 - 1 - 2 + 3\n" +
                        "222 + 333 - 444 * 2 + 1";
                    File.WriteAllText("input3.txt", content);
                }
                using (StreamReader sr = new StreamReader("input3.txt"))
                {
                    string content = sr.ReadToEnd();
                    rtb_output.Text = content;
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input3.txt"))
            {
                MessageBox.Show("Không tìm thấy file input3.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] lines = File.ReadAllLines("input3.txt");
            List<string> result = new List<string>();
            foreach(string line in lines)
            {
                string expr = line.Trim();
                if (expr == "") continue;

                double value = Calculate(expr);
                result.Add($"{expr} = {value}");
            }
            File.WriteAllLines("output3.txt", result);
            rtb_output.Lines = result.ToArray();
            MessageBox.Show("Đã tính toán và ghi ra file output3.txt thành công!");
        }

        private double Calculate(string expr)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> op = new Stack<char>();
            int i = 0;

            try
            {
                while (i < expr.Length)
                {
                    char c = expr[i];

                    // Bỏ qua khoảng trắng
                    if (c == ' ')
                    {
                        i++;
                        continue;
                    }

                    // Nếu là số hoặc dấu âm đứng đầu / sau toán tử
                    if (char.IsDigit(c) ||
                       ((c == '-' || c == '+') &&
                        (i == 0 || "*/(+-".Contains(expr[i - 1])) &&
                        i + 1 < expr.Length && char.IsDigit(expr[i + 1])))
                    {
                        string num = "";
                        num += c;
                        i++;
                        while (i < expr.Length && (char.IsDigit(expr[i]) || expr[i] == '.'))
                        {
                            num += expr[i];
                            i++;
                        }
                        values.Push(double.Parse(num));
                        continue;
                    }

                    // Nếu là dấu mở ngoặc
                    if (c == '(')
                    {
                        op.Push(c);
                    }
                    // Nếu là dấu đóng ngoặc
                    else if (c == ')')
                    {
                        while (op.Count > 0 && op.Peek() != '(')
                        {
                            if (values.Count < 2)
                                throw new Exception("Biểu thức không đúng định dạng");
                            values.Push(ApplyOp(op.Pop(), values.Pop(), values.Pop()));
                        }
                        if (op.Count == 0)
                            throw new Exception("Biểu thức không đúng định dạng");
                        op.Pop(); // bỏ '('
                    }
                    // Nếu là toán tử
                    else if ("+-*/".Contains(c))
                    {
                        // Kiểm tra toán tử liên tiếp (trừ khi là số âm)
                        if (i == expr.Length - 1 || "+-*/".Contains(expr[i + 1]))
                            throw new Exception("Biểu thức không đúng định dạng");

                        while (op.Count > 0 && Precedence(op.Peek()) >= Precedence(c))
                        {
                            if (values.Count < 2)
                                throw new Exception("Biểu thức không đúng định dạng");
                            values.Push(ApplyOp(op.Pop(), values.Pop(), values.Pop()));
                        }
                        op.Push(c);
                    }
                    // Ký tự không hợp lệ
                    else
                    {
                        throw new Exception("Biểu thức không đúng định dạng");
                    }

                    i++;
                }

                while (op.Count > 0)
                {
                    if (values.Count < 2)
                        throw new Exception("Biểu thức không đúng định dạng");
                    values.Push(ApplyOp(op.Pop(), values.Pop(), values.Pop()));
                }

                if (values.Count != 1)
                    throw new Exception("Biểu thức không đúng định dạng");

                return values.Pop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Biểu thức không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return double.NaN;
            }
        }

        private int Precedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if(b ==0)
                    {
                        MessageBox.Show("Không thể chia cho 0", "Lỗi tính toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return double.NaN;
                    }
                    return a / b;
            }
            return 0;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_output.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
