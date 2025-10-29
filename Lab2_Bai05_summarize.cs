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
using _24521840_NT106_Lab2;

namespace _24521840_NT106_Lab2
{
    public partial class Lab2_Bai05_summarize : Form
    {
        
        public Lab2_Bai05_summarize(Dictionary<string, Lab2_Bai05_Movie> moviesData)
        {
            InitializeComponent();
            movies = moviesData;
        }

        private void btn_read_data_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Visible = true;
                lbl_progress.Visible = true;
                progressBar.Value = 0;
                progressBar.Maximum = movies.Count + 2;
                Application.DoEvents();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("BÁO CÁO THỐNG KÊ DOANH THU RẠP PHIM");
                sb.AppendLine();

                progressBar.Value++;
                Application.DoEvents();

                var rankedMovies = movies.Values.OrderByDescending(m => m.Revenue).ToList();

                sb.AppendLine($"{"HẠNG",-6} {"TÊN PHIM",-30} {"VÉ BÁN",-10} {"VÉ TỒN",-10} {"DOANH THU",-15}");
                sb.AppendLine(new string('-', 90));

                for (int i = 0; i < rankedMovies.Count; i++)
                {
                    var movie = rankedMovies[i];
                    sb.AppendLine($"#{i + 1,-5} {movie.Name,-3} {movie.TotalSold,-10} {movie.RemainingSeats,-10} {movie.Revenue + "đ",-15:N0}");
                    sb.AppendLine($"       Vớt: {movie.SoldVot}, Thường: {movie.SoldThuong}, VIP: {movie.SoldVIP}");
                    sb.AppendLine();

                    progressBar.Value++;
                    Application.DoEvents();
                }

                sb.AppendLine(new string('=', 90));
                sb.AppendLine($"TỔNG DOANH THU: {movies.Values.Sum(m => m.Revenue):N0}đ");
                sb.AppendLine($"TỔNG VÉ ĐÃ BÁN: {movies.Values.Sum(m => m.TotalSold)} vé");
                sb.AppendLine(new string('=', 90));

                progressBar.Value = progressBar.Maximum;
                txt_summary.Text = sb.ToString();

                System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
                {
                    if (InvokeRequired)
                        Invoke(new Action(() =>
                        {
                            progressBar.Visible = false;
                            lbl_progress.Visible = false;
                        }));
                });

                MessageBox.Show("Đọc dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lbl_progress.Visible = false;
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_write_data_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Visible = true;
                lbl_progress.Visible = true;
                progressBar.Value = 0;
                progressBar.Maximum = movies.Count + 2;
                Application.DoEvents();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("BÁO CÁO THỐNG KÊ DOANH THU CHI TIẾT RẠP PHIM");
                sb.AppendLine();

                progressBar.Value++;
                Application.DoEvents();

                var rankedMovies = movies.Values.OrderByDescending(m => m.Revenue).ToList();

                sb.AppendLine($"{"HẠNG",-6} {"TÊN PHIM",-30} {"VÉ BÁN",-10} {"VÉ TỒN",-10} {"TỈ LỆ",-12} {"DOANH THU",-15}");
                sb.AppendLine(new string('-', 100));

                for (int i = 0; i < rankedMovies.Count; i++)
                {
                    var movie = rankedMovies[i];
                    int totalSeats = movie.Rooms.Count * 15;
                    double percentage = totalSeats > 0 ? (double)movie.TotalSold / totalSeats * 100 : 0;

                    sb.AppendLine($"#{i + 1,-5} {movie.Name,-30} {movie.TotalSold,-10} {movie.RemainingSeats,-10} {percentage,-12:F1}% {movie.Revenue + "đ",-15:N0}");
                    sb.AppendLine($"       Chi tiết: Vớt={movie.SoldVot}, Thường={movie.SoldThuong}, VIP={movie.SoldVIP}");
                    sb.AppendLine($"       Giá chuẩn: {movie.StandardPrice:N0}đ | Phòng: {string.Join(", ", movie.Rooms)}");
                    sb.AppendLine();

                    progressBar.Value++;
                    Application.DoEvents();
                }

                sb.AppendLine(new string('=', 100));
                sb.AppendLine($"TỔNG DOANH THU: {movies.Values.Sum(m => m.Revenue):N0}đ");
                sb.AppendLine($"TỔNG VÉ ĐÃ BÁN: {movies.Values.Sum(m => m.TotalSold)} vé");
                sb.AppendLine($"TỔNG VÉ TỒN: {movies.Values.Sum(m => m.RemainingSeats)} vé");
                sb.AppendLine(new string('=', 100));

                progressBar.Value = progressBar.Maximum;
                Application.DoEvents();

                File.WriteAllText("output5.txt", sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Ghi file output5.txt thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
                {
                    if (InvokeRequired)
                        Invoke(new Action(() =>
                        {
                            progressBar.Visible = false;
                            lbl_progress.Visible = false;
                        }));
                });
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lbl_progress.Visible = false;
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
