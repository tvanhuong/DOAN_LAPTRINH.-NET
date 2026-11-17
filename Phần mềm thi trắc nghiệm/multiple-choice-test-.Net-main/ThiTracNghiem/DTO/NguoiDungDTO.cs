namespace ThiTracNghiem.DTO
{
    public class NguoiDungDTO
    {
        public int MaND { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string VaiTro { get; set; }

        public NguoiDungDTO() { }

        public NguoiDungDTO(int maND, string taiKhoan, string matKhau, string hoTen, string vaiTro)
        {
            MaND = maND;
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            HoTen = hoTen;
            VaiTro = vaiTro;
        }
    }
}
