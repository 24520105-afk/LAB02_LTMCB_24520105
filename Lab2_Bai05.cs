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
    public partial class Lab2_Bai05 : Form
    {
        private Dictionary<string, Lab2_Bai05_Movie> movies;
        public Lab2_Bai05()
        {
            InitializeComponent();
            movies = new Dictionary<string, Lab2_Bai05_Movie>();
        }

        private string[] allSeats = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };

        private Dictionary<string, decimal> seatPriceMultipliers = new Dictionary<string, decimal>
        {
            { "A1", 0.25m }, { "A5", 0.25m }, { "C1", 0.25m }, { "C5", 0.25m }, // Vé vớt
            { "A2", 1.0m }, { "A3", 1.0m }, { "A4", 1.0m }, { "C2", 1.0m }, { "C3", 1.0m }, { "C4", 1.0m }, // Vé thường
            { "B1", 2.0m }, { "B2", 2.0m }, { "B3", 2.0m }, { "B4", 2.0m }, { "B5", 2.0m } // Vé VIP
        };

        private void btn_summarize_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0)
            {
                MessageBox.Show("Vui lòng đọc dữ liệu trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Lab2_Bai05_summarize bai05_Summarize = new Lab2_Bai05_summarize(movies);
            bai05_Summarize.Show();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("input5.txt"))
                {
                    MessageBox.Show("File input5.txt không tồn tại!\n\nTạo file mẫu...",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CreateSampleFile();
                }

                LoadDataFromFile();
                MessageBox.Show($"Đọc file thành công!\n\nĐã load {movies.Count} phim từ input5.txt",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_list_film.SelectedItem == null || cb_list_room.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clb_choose_seat.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clb_choose_seat.CheckedIndices.Count > 2)
            {
                MessageBox.Show("Không thể đặt quá 2 vé!\n Vì đang là những ngày cao điểm của năm \n Và để có đủ vé cho mọi người \n chúng tôi xin phép chỉ bán 2 vé cho mỗi lượt \n Xin lỗi quý khách vì sự bất tiện này!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMovie = cb_list_film.SelectedItem.ToString();
            string roomText = cb_list_room.SelectedItem.ToString();
            int room = int.Parse(roomText.Replace("Phòng ", ""));
            var movie = movies[selectedMovie];

            int votCount = 0, thuongCount = 0, vipCount = 0;
            List<string> selectedSeats = new List<string>();

            foreach (int i in clb_choose_seat.CheckedIndices)
            {
                string itemText = clb_choose_seat.Items[i].ToString();
                string seat = itemText.Split(' ')[0];
                selectedSeats.Add(seat);
                string key = $"{room}-{seat}";
                movie.SeatAvailability[key] = false;

                decimal multiplier = seatPriceMultipliers[seat];
                if (multiplier == 0.25m) votCount++;
                else if (multiplier == 1.0m) thuongCount++;
                else vipCount++;
            }

            movie.SoldVot += votCount;
            movie.SoldThuong += thuongCount;
            movie.SoldVIP += vipCount;
            movie.RemainingSeats -= (votCount + thuongCount + vipCount);

            SaveDataToFile();

            MessageBox.Show("Đặt vé thành công!\n\n" + tb_output.Text,
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tb_name.Clear();
            UpdateSeatList();
        }
        private void cb_list_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_list_film.SelectedItem == null) return;

            string selectedMovie = cb_list_film.SelectedItem.ToString();
            var movie = movies[selectedMovie];

            cb_list_room.Items.Clear();
            foreach (int room in movie.Rooms)
            {
                cb_list_room.Items.Add($"Phòng {room}");
            }
            if (cb_list_room.Items.Count > 0)
            {
                cb_list_room.SelectedIndex = 0;
                cb_list_room_SelectedIndexChanged(null, null); 
            }

        }
        private void cb_list_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSeatList();
        }
        private void clb_choose_seat_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clb_choose_seat.GetItemCheckState(e.Index) == CheckState.Indeterminate)
            {
                e.NewValue = CheckState.Unchecked;
                return;
            }

            BeginInvoke(new Action(() => UpdateTicketInfo()));
        }
        private void LoadDataFromFile()
        {
            movies.Clear();
            string content = File.ReadAllText("input5.txt", Encoding.UTF8);
            string[] blocks = content.Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string block in blocks)
            {
                string[] lines = block.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (lines.Length >= 6)
                {
                    var movie = new Lab2_Bai05_Movie

                    {
                        Name = lines[0].Trim(),
                        StandardPrice = decimal.Parse(lines[1].Trim()),
                        Rooms = lines[2].Split(',').Select(r => int.Parse(r.Trim())).ToList(),
                        SoldVot = int.Parse(lines[3].Trim()),
                        SoldThuong = int.Parse(lines[4].Trim()),
                        SoldVIP = int.Parse(lines[5].Trim())
                    };

                    if (lines.Length >= 7)
                        movie.RemainingSeats = int.Parse(lines[6].Trim());
                    else
                        movie.RemainingSeats = movie.Rooms.Count * allSeats.Length - movie.TotalSold;

                    InitializeSeats(movie);
                    movies.Add(movie.Name, movie);
                }
            }

            UpdateMovieComboBox();
            if (cb_list_film.Items.Count > 0)
            {
                cb_list_film.SelectedIndex = 0;
                cb_list_film_SelectedIndexChanged(null, null);  // Cập nhật danh sách phòng
                cb_list_room_SelectedIndexChanged(null, null);  // Cập nhật ghế
            }
        }
        private void CreateSampleFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Đào, phở và piano");
            sb.AppendLine("45000");
            sb.AppendLine("1,2,3");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("45");
            sb.AppendLine();
            sb.AppendLine("Mai");
            sb.AppendLine("100000");
            sb.AppendLine("2,3");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("30");
            sb.AppendLine();
            sb.AppendLine("Gặp lại chị bầu");
            sb.AppendLine("70000");
            sb.AppendLine("1");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("15");
            sb.AppendLine();
            sb.AppendLine("Tarot");
            sb.AppendLine("90000");
            sb.AppendLine("3");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("0");
            sb.AppendLine("15");

            File.WriteAllText("input5.txt", sb.ToString(), Encoding.UTF8);
        }
        private void SaveDataToFile()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (var movie in movies.Values)
            {
                if (count > 0) sb.AppendLine();

                sb.AppendLine(movie.Name);
                sb.AppendLine(movie.StandardPrice.ToString());
                sb.AppendLine(string.Join(",", movie.Rooms));
                sb.AppendLine(movie.SoldVot.ToString());
                sb.AppendLine(movie.SoldThuong.ToString());
                sb.AppendLine(movie.SoldVIP.ToString());
                sb.AppendLine(movie.RemainingSeats.ToString());

                count++;
            }

            File.WriteAllText("input5.txt", sb.ToString(), Encoding.UTF8);
        }

        // Khởi tạo ghế cho phim
        private void InitializeSeats(Lab2_Bai05_Movie movie)
        {
            int totalSeats = movie.Rooms.Count * allSeats.Length;
            int soldSeats = movie.TotalSold;
            movie.RemainingSeats = totalSeats - soldSeats;

            foreach (int room in movie.Rooms)
            {
                foreach (string seat in allSeats)
                {
                    string key = $"{room}-{seat}";
                    movie.SeatAvailability[key] = true;
                }
            }

            // Đánh dấu ghế đã bán (giả lập)
            int markedSeats = 0;
            foreach (int room in movie.Rooms)
            {
                foreach (string seat in allSeats)
                {
                    if (markedSeats >= soldSeats) break;
                    string key = $"{room}-{seat}";
                    movie.SeatAvailability[key] = false;
                    markedSeats++;
                }
                if (markedSeats >= soldSeats) break;
            }
        }
        private void UpdateMovieComboBox()
        {
            cb_list_film.Items.Clear();
            foreach (var movie in movies.Keys)
            {
                cb_list_film.Items.Add(movie);
            }
            if (cb_list_film.Items.Count > 0)
                cb_list_film.SelectedIndex = 0;
        }
        private void UpdateSeatList()
        {
            clb_choose_seat.Items.Clear();
            tb_output.Clear();

            if (cb_list_film.SelectedItem == null || cb_list_room.SelectedItem == null) return;

            string selectedMovie = cb_list_film.SelectedItem.ToString();
            string roomText = cb_list_room.SelectedItem.ToString();
            int room = int.Parse(roomText.Replace("Phòng ", ""));

            var movie = movies[selectedMovie];

            foreach (string seat in allSeats)
            {
                string key = $"{room}-{seat}";
                if (movie.SeatAvailability.ContainsKey(key))
                {
                    bool available = movie.SeatAvailability[key];
                    string seatType = GetSeatType(seat);
                    decimal price = movie.StandardPrice * seatPriceMultipliers[seat];
                    string displayText = $"{seat} ({seatType})";

                    if (!available)
                        displayText += " [Đã đặt]";

                    clb_choose_seat.Items.Add(displayText, false);
                    if (!available)
                    {
                        clb_choose_seat.SetItemCheckState(clb_choose_seat.Items.Count - 1, CheckState.Indeterminate);
                    }
                }
            }
        }
        private string GetSeatType(string seat)
        {
            decimal multiplier = seatPriceMultipliers[seat];
            if (multiplier == 0.25m) return "Vớt";
            if (multiplier == 1.0m) return "Thường";
            return "VIP";
        }

        // Cập nhật thông tin vé
        private void UpdateTicketInfo()
        {
            if (cb_list_film.SelectedItem == null) return;

            string selectedMovie = cb_list_film.SelectedItem.ToString();
            string roomText = cb_list_room.SelectedItem.ToString();
            int room = int.Parse(roomText.Replace("Phòng ", ""));
            var movie = movies[selectedMovie];

            decimal total = 0;
            List<string> selectedSeats = new List<string>();

            foreach (int i in clb_choose_seat.CheckedIndices)
            {
                string itemText = clb_choose_seat.Items[i].ToString();
                string seat = itemText.Split(' ')[0];
                selectedSeats.Add(seat);
                decimal multiplier = seatPriceMultipliers[seat];
                total += movie.StandardPrice * multiplier;
            }

            if (selectedSeats.Count > 0)
            {
                tb_output.Text = $"Khách hàng: {tb_name.Text}\n";
                tb_output.Text += $"Phim: {selectedMovie}\n";
                tb_output.Text += $"Phòng: {room}\n";
                tb_output.Text += $"Ghế: {string.Join(", ", selectedSeats)}\n";
                tb_output.Text += $"Tổng tiền: {total:N0}đ";
            }
            else
            {
                tb_output.Clear();
            }
        }
    }
}
