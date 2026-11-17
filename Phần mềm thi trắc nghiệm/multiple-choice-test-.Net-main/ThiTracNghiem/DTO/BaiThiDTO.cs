using System;

namespace ThiTracNghiem.DTO
{
    public class BaiThiDTO
    {
        public int MaBaiThi { get; set; }
        public int MaND { get; set; }
        public string HoTen { get; set; }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public DateTime NgayThi { get; set; }
        public int SoCauDung { get; set; }
        public int TongSoCau { get; set; }
        public double DiemSo { get; set; }

        public BaiThiDTO() { }
    }
}
