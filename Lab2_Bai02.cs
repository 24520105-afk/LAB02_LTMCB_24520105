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
    public partial class Lab2_Bai02 : Form
    {
        public Lab2_Bai02()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog(this);
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                rtb_output.Text = content;
                tb_name.Text = ofd.SafeFileName.ToString();
                tb_url.Text = ofd.FileName.ToString();

                int lineCount = 0;
                string line = sr.ReadLine();
                while (line != null)
                    lineCount++;
                tb_line.Text = lineCount.ToString();

                string[] word = content.Split(new char[] { ' ', '\t', '\n', '\r', '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '}', '[', ']', '|', ':', ';', '"', '<', ',', '>', '.', '?', '/' }, StringSplitOptions.RemoveEmptyEntries);
                tb_word.Text = word.Length.ToString();

                tb_char.Text = content.Length.ToString();

                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_url.Clear();
            tb_line.Clear();
            tb_word.Clear();
            tb_char.Clear();
            rtb_output.Clear();
        }
    }
}
