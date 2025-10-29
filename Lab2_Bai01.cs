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
    public partial class Lab2_Bai01 : Form
    {
        public Lab2_Bai01()
        {
            InitializeComponent();
            if (!File.Exists("input1.txt"))
            {
                string content = "Nguyen Le Ngoc Anh\nMSSV: 24520105\nClass: NT106.Q14";
                File.WriteAllText("input1.txt", content);
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input1.txt"))
                {
                    string content = sr.ReadToEnd();
                    rtb_output.Text = content;
                    MessageBox.Show("Đã đọc file thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("output1.txt"))
                {
                    sw.Write(rtb_output.Text.ToUpper());
                }
                MessageBox.Show("Đã ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
