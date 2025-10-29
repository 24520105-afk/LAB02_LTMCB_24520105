using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Packaging;
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
using Word = Microsoft.Office.Interop.Word;


namespace _24521840_NT106_Lab2
{
    public partial class Lab2_Bai07 : Form
    {
        public Lab2_Bai07()
        {
            InitializeComponent();
            LoadDrives();
        }

        // --- Load danh sách ổ đĩa ---
        private void LoadDrives()
        {
            tw_direc.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name)
                {
                    Tag = drive.Name
                };
                node.Nodes.Add("Loading...");
                tw_direc.Nodes.Add(node);
            }
        }

        // --- Khi mở rộng thư mục ---
        private void tw_direc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();

            string path = node.Tag as string;
            if (!Directory.Exists(path)) return;

            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    TreeNode subDir = new TreeNode(Path.GetFileName(dir))
                    {
                        Tag = dir
                    };
                    subDir.Nodes.Add("Loading...");
                    node.Nodes.Add(subDir);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file))
                    {
                        Tag = file
                    };
                    node.Nodes.Add(fileNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở thư mục: " + ex.Message);
            }
        }

        // --- Khi chọn node (thư mục hoặc file) ---
        private void tw_direc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag as string;
            if (File.Exists(path))
                DisplayFileContent(path);
        }

        // --- Hiển thị nội dung file ---
        private void DisplayFileContent(string path)
        {
            string ext = Path.GetExtension(path).ToLower();

            try
            {
                // --- File văn bản ---
                if (ext == ".txt" || ext == ".cs" || ext == ".log" || ext == ".xml" || ext == ".json")
                {
                    rtb_content.Visible = true;
                    ptb_view.Visible = false;
                    rtb_content.Text = File.ReadAllText(path);
                }
                // --- Hình ảnh ---
                else if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    ptb_view.Visible = true;
                    rtb_content.Visible = false;
                    ptb_view.Image = Image.FromFile(path);
                    ptb_view.SizeMode = PictureBoxSizeMode.Zoom;
                }
                // --- File Word (.doc, .docx) ---
                else if (ext == ".doc" || ext == ".docx")
                {
                    rtb_content.Visible = true;
                    ptb_view.Visible = false;
                    rtb_content.Text = ReadWordFile(path);
                }
                else
                {
                    rtb_content.Visible = true;
                    ptb_view.Visible = false;
                    rtb_content.Text = $"Không thể hiển thị nội dung của file {ext}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private string ReadWordFile(string filePath)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document doc = null;
            string text = "";

            try
            {
                object file = filePath;
                object missing = Type.Missing;
                doc = wordApp.Documents.Open(ref file, ref missing, true);
                text = doc.Content.Text;
            }
            finally
            {
                if (doc != null) doc.Close();
                wordApp.Quit();
            }

            return text;
        }

        private void Lab2_Bai07_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }
    }
}
