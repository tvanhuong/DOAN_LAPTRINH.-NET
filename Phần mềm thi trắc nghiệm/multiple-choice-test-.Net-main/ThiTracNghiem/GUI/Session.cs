using ThiTracNghiem.DTO;

namespace ThiTracNghiem.GUI
{
    public static class Session
    {
        public static NguoiDungDTO NguoiDungHienTai { get; set; }

        public static bool DaDangNhap => NguoiDungHienTai != null;
        public static bool IsAdmin => NguoiDungHienTai != null && NguoiDungHienTai.VaiTro == "Admin";
        public static bool IsThiSinh => NguoiDungHienTai != null && NguoiDungHienTai.VaiTro == "ThiSinh";

        public static void DangXuat()
        {
            NguoiDungHienTai = null;
        }
    }
}
