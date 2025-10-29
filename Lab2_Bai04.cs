using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24521840_NT106_Lab2
{
    public partial class Lab2_Bai04 : Form
    {
        List<Student> students = new List<Student>();
        private int currentStudentIndex = 0;

        public Lab2_Bai04()
        {
            InitializeComponent();
        }

        public class Student
        {
            public int MSSV { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float CourseAvg { get; set; }

            public void CalculateAvg()
            {
                CourseAvg = (Course1 + Course2 + Course3) / 3;
            }

            // Chuyển sinh viên thành chuỗi để ghi file
            public string ToFileString()
            {
                return $"{MSSV}\n{Name}\n{Phone}\n{Course1}\n{Course2}\n{Course3}";
            }

            // Tạo sinh viên từ mảng string (có 6 dòng dữ liệu
            public static Student FromStringArray(string[] lines)
            {
                if (lines.Length < 6)
                    throw new Exception("Dữ liệu sinh viên không đủ!");

                Student sv = new Student
                {//đồng thời chuyển kiểu dữ liệu cho từng phần tử
                    MSSV = int.Parse(lines[0].Trim()),
                    Name = lines[1].Trim(),
                    Phone = lines[2].Trim(),
                    Course1 = float.Parse(lines[3].Trim()),
                    Course2 = float.Parse(lines[4].Trim()),
                    Course3 = float.Parse(lines[5].Trim())
                };

                return sv;
            }
        }

        // Tạo file dữ liệu mẫu với thông tin của sinh viên thực hành
        private void CreateSampleFile()
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                // Sinh viên 1 - Sinh viên thực hành
                sb.AppendLine("24521840");
                sb.AppendLine("Nguyễn Võ Minh Trí");
                sb.AppendLine("0979613915");
                sb.AppendLine("9.5");
                sb.AppendLine("9.8");
                sb.AppendLine("9.0");
                sb.AppendLine();

                File.WriteAllText("input4.txt", sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Đã tạo dữ liệu mẫu ở file input4.txt!",
                    "Tạo file mẫu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo file mẫu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Đọc danh sách sinh viên từ file
        private List<Student> ReadStudentsFromFile(string filePath)
        {
            List<Student> studentList = new List<Student>();

            try
            {
                string content = File.ReadAllText(filePath, Encoding.UTF8);

                // Tách theo dòng trắng để phân cách các sinh viên
                string[] blocks = content.Split(new string[] { "\r\n\r\n", "\n\n" },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string block in blocks)
                {
                    // Tách từng dòng trong block, mỗi block trong blocks là 1 sinh viên
                    string[] lines = block.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    if (lines.Length >= 6) // Khi đủ dữ liệu mới thực hiện add vào list sinh viên
                    {
                        try
                        {
                            Student sv = Student.FromStringArray(lines);
                            studentList.Add(sv);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi đọc sinh viên: {ex.Message}", "Cảnh báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi đọc file: {ex.Message}");
            }

            return studentList;
        }

        // Ghi danh sách sinh viên vào file
        private void WriteStudentsToFile(string filePath, List<Student> studentList)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < studentList.Count; i++)
                {
                    sb.Append(studentList[i].ToFileString());

                    // Thêm dòng trắng phân cách
                    if (i < studentList.Count)
                    {
                        sb.AppendLine();
                        sb.AppendLine();
                    }
                }

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi ghi file: {ex.Message}");
            }
        }

        // Kiểm tra ràng buộc dữ liệu
        private bool ValidateInput()
        {
            // Kiểm tra MSSV (8 chữ số)
            if (tb_mssv.Text.Length != 8 || !int.TryParse(tb_mssv.Text, out int mssv))
            {
                MessageBox.Show("MSSV phải là số có 8 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_mssv.Focus();
                return false;
            }

            // Kiểm tra tên không để trống
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_name.Focus();
                return false;
            }

            // Kiểm tra số điện thoại (10 chữ số, bắt đầu bằng 0)
            if (tb_phone.Text.Length != 10 || !tb_phone.Text.StartsWith("0") || !long.TryParse(tb_phone.Text, out _))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_phone.Focus();
                return false;
            }

            // Kiểm tra điểm môn 1 (0-10)
            if (!float.TryParse(tb_course1.Text, out float d1) || d1 < 0 || d1 > 10)
            {
                MessageBox.Show("Điểm môn 1 phải là số từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_course1.Focus();
                return false;
            }

            // Kiểm tra điểm môn 2 (0-10)
            if (!float.TryParse(tb_course2.Text, out float d2) || d2 < 0 || d2 > 10)
            {
                MessageBox.Show("Điểm môn 2 phải là số từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_course2.Focus();
                return false;
            }

            // Kiểm tra điểm môn 3 (0-10)
            if (!float.TryParse(tb_course3.Text, out float d3) || d3 < 0 || d3 > 10)
            {
                MessageBox.Show("Điểm môn 3 phải là số từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_course3.Focus();
                return false;
            }

            return true;
        }

        // Nút Thêm vào hàng đợi - ghi vào input4.txt nhưng chưa tính điểm trung bình
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                Student sv = new Student
                {
                    MSSV = int.Parse(tb_mssv.Text),
                    Name = tb_name.Text.Trim(),
                    Phone = tb_phone.Text,
                    Course1 = float.Parse(tb_course1.Text),
                    Course2 = float.Parse(tb_course2.Text),
                    Course3 = float.Parse(tb_course3.Text)
                };

                // Đọc danh sách hiện tại từ input4.txt (nếu có)
                List<Student> existingStudents = new List<Student>();
                if (File.Exists("input4.txt"))
                {
                    try
                    {
                        existingStudents = ReadStudentsFromFile("input4.txt");
                    }
                    catch
                    {
                        existingStudents = new List<Student>();
                    }
                }

                existingStudents.Add(sv);

                // Update input4.txt
                WriteStudentsToFile("input4.txt", existingStudents);

                MessageBox.Show($"Đã thêm sinh viên {sv.Name} vào input4.txt!\nTổng: {existingStudents.Count} sinh viên", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields(); // Ghi xong thì xóa các textbox để viết sinh viên mới
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Ghi File Input - đọc input4.txt, tính điểm trung bình rồi xuất ra rtb_confirm và ghi vào output4.txt
        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra file tồn tại và có dữ liệu
                bool needCreateSample = false;

                if (!File.Exists("input4.txt"))
                {
                    needCreateSample = true;
                }
                else
                {
                    string content = File.ReadAllText("input4.txt", Encoding.UTF8);
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        needCreateSample = true;
                    }
                    else
                    {
                        try
                        {
                            var testList = ReadStudentsFromFile("input4.txt");
                            if (testList == null || testList.Count == 0)
                            {
                                needCreateSample = true;
                            }
                        }
                        catch
                        {
                            needCreateSample = true;
                        }
                    }
                }

                // Nếu cần tạo file mẫu, hỏi người dùng
                if (needCreateSample)
                {
                    DialogResult result = MessageBox.Show(
                        "File input4.txt không tồn tại hoặc không có dữ liệu!\n\n" +
                        "Bạn có muốn tạo file mẫu với 1 sinh viên bất kỳ không?",
                        "Tạo file mẫu",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CreateSampleFile();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng thêm sinh viên trước khi xử lý!", "Thông báo");
                        return;
                    }
                }

                // Đọc file input4.txt
                students = ReadStudentsFromFile("input4.txt");

                if (students == null || students.Count == 0)
                {
                    MessageBox.Show("File input4.txt không có dữ liệu hợp lệ!", "Lỗi");
                    return;
                }

                // Tính điểm trung bình cho mỗi sinh viên
                foreach (var sv in students)
                {
                    sv.CalculateAvg();
                }

                // Ghi xuống output4.txt (CÓ ĐIỂM TB)
                StringBuilder outputContent = new StringBuilder();
                for (int i = 0; i < students.Count; i++)
                {
                    Student sv = students[i];
                    outputContent.AppendLine(sv.MSSV.ToString());
                    outputContent.AppendLine(sv.Name);
                    outputContent.AppendLine(sv.Phone);
                    outputContent.AppendLine(sv.Course1.ToString("F2"));
                    outputContent.AppendLine(sv.Course2.ToString("F2"));
                    outputContent.AppendLine(sv.Course3.ToString("F2"));
                    outputContent.AppendLine(sv.CourseAvg.ToString("F2"));

                    if (i < students.Count - 1)
                    {
                        outputContent.AppendLine();
                    }
                }
                File.WriteAllText("output4.txt", outputContent.ToString(), Encoding.UTF8);

                // Hiển thị thông tin tổng quan trong RichTextBox
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("═══════════════════════════════════════");
                sb.AppendLine("DANH SÁCH SINH VIÊN SAU KHI TÍNH ĐIỂM");
                sb.AppendLine("═══════════════════════════════════════");
                sb.AppendLine($"Tổng số sinh viên: {students.Count}");
                sb.AppendLine($"Điểm trung bình cao nhất: {students.Max(s => s.CourseAvg):F2}");
                sb.AppendLine($"Điểm trung bình thấp nhất: {students.Min(s => s.CourseAvg):F2}");
                sb.AppendLine($"Điểm TB chung: {students.Average(s => s.CourseAvg):F2}");
                sb.AppendLine("──────────────────────────────────────");
                sb.AppendLine();

                for (int i = 0; i < students.Count; i++)
                {
                    var sv = students[i];
                    sb.AppendLine($"[{i + 1}] {sv.Name} - MSSV: {sv.MSSV}");
                    sb.AppendLine($"    Điểm: {sv.Course1:F1} | {sv.Course2:F1} | {sv.Course3:F1}");
                    sb.AppendLine($"    Điểm TB: {sv.CourseAvg:F2}");
                    sb.AppendLine();
                }

                MessageBox.Show($"Đã ghi dữ liệu sinh viên vào input.txt\nBấm <=/=> để xem từng sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtb_confirm.Text = sb.ToString();

                // Hiển thị sinh viên đầu tiên trong các TextBox bên phải
                currentStudentIndex = 0;
                DisplayCurrentStudent();

                MessageBox.Show($"Đã đọc {students.Count} sinh viên và tính điểm TB!\nKết quả đã ghi vào output4.txt",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị thông tin sinh viên hiện tại trong các TextBox bên phải
        private void DisplayCurrentStudent()
        {
            if (students == null || students.Count == 0)
            {
                MSSVBox.Text = "";
                NameBox.Text = "";
                PhoneBox.Text = "";
                Course1Box.Text = "";
                Course2Box.Text = "";
                Course3Box.Text = "";
                AvgBox.Text = "";
                page.Text = "0/0";
                return;
            }

            // Đảm bảo index hợp lệ
            if (currentStudentIndex < 0) currentStudentIndex = 0;
            if (currentStudentIndex >= students.Count) currentStudentIndex = students.Count - 1;

            Student sv = students[currentStudentIndex];

            MSSVBox.Text = sv.MSSV.ToString();
            NameBox.Text = sv.Name;
            PhoneBox.Text = sv.Phone;
            Course1Box.Text = sv.Course1.ToString("F2");
            Course2Box.Text = sv.Course2.ToString("F2");
            Course3Box.Text = sv.Course3.ToString("F2");
            AvgBox.Text = sv.CourseAvg.ToString("F2");

            // Cập nhật label hiển thị trang
            page.Text = $"{currentStudentIndex + 1}/{students.Count}";
        }

        // Xóa các ô nhập liệu bên trái
        private void ClearInputFields()
        {
            tb_mssv.Clear();
            tb_name.Clear();
            tb_phone.Clear();
            tb_course1.Clear();
            tb_course2.Clear();
            tb_course3.Clear();
            tb_mssv.Focus();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!\nHãy nhấn 'Tính Toán Ghi Output' trước.", "Thông báo");
                return;
            }

            if (currentStudentIndex < students.Count - 1)
            {
                currentStudentIndex++;
                DisplayCurrentStudent();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (students == null || students.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!\nHãy nhấn 'Tính Toán Ghi Output' trước.", "Thông báo");
                return;
            }

            if (currentStudentIndex > 0)
            {
                currentStudentIndex--;
                DisplayCurrentStudent();
            }
        }
    }
}
