namespace ThiTracNghiem.DTO
{
    public class MonHocDTO
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int ThoiGianThi { get; set; }
        public int SoCauHoi { get; set; }

        public MonHocDTO() { }

        public MonHocDTO(string maMon, string tenMon, int thoiGianThi, int soCauHoi)
        {
            MaMon = maMon;
            TenMon = tenMon;
            ThoiGianThi = thoiGianThi;
            SoCauHoi = soCauHoi;
        }
    }
}
