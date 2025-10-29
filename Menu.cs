using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24520105_NT106_Lab2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_bai01_Click(object sender, EventArgs e)
        {
            Lab2_Bai01 bai01 = new Lab2_Bai01();
            bai01.Show();
        }

        private void btn_bai02_Click(object sender, EventArgs e)
        {
            Lab2_Bai02 bai02 = new Lab2_Bai02();
            bai02.Show();
        }

        private void btn_bai03_Click(object sender, EventArgs e)
        {
            Lab2_Bai03 bai03 = new Lab2_Bai03();
            bai03.Show();
        }

        private void btn_bai04_Click(object sender, EventArgs e)
        {
            Lab2_Bai04 bai04 = new Lab2_Bai04();
            bai04.Show();
        }

        private void btn_bai05_Click(object sender, EventArgs e)
        {
            Lab2_Bai05 bai05 = new Lab2_Bai05();
            bai05.Show();
        }

        private void btn_bai07_Click(object sender, EventArgs e)
        {
            Lab2_Bai07 bai07 = new Lab2_Bai07();
            bai07.Show();
        }
    }
}
