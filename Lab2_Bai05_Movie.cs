using System;
using System.Collections.Generic;

namespace _24521840_NT106_Lab2
{
    public partial class Lab2_Bai05_Movie
    {
        public string Name { get; set; }
        public decimal StandardPrice { get; set; }
        public List<int> Rooms { get; set; }
        public int SoldVot { get; set; }       // Vé vớt
        public int SoldThuong { get; set; }    // Vé thường
        public int SoldVIP { get; set; }       // Vé VIP
        public int RemainingSeats { get; set; } // Vé tồn
        public Dictionary<string, bool> SeatAvailability { get; set; }

        public Lab2_Bai05_Movie()
        {
            Rooms = new List<int>();
            SeatAvailability = new Dictionary<string, bool>();
            SoldVot = 0;
            SoldThuong = 0;
            SoldVIP = 0;
        }

        public int TotalSold => SoldVot + SoldThuong + SoldVIP;

        public decimal Revenue => (SoldVot * StandardPrice * 0.25m) +
                                  (SoldThuong * StandardPrice) +
                                  (SoldVIP * StandardPrice * 2m);
    }
}
