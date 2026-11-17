using ThiTracNghiem.DAL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.BLL
{
    public class NguoiDungBLL
    {
        private readonly NguoiDungDAL _dal = new NguoiDungDAL();

        public NguoiDungDTO DangNhap(string taiKhoan, string matKhau, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(taiKhoan))
            {
                thongBaoLoi = "Tài khoản không được để trống!";
                return null;
            }
            if (string.IsNullOrWhiteSpace(matKhau))
            {
                thongBaoLoi = "Mật khẩu không được để trống!";
                return null;
            }

            NguoiDungDTO user = _dal.DangNhap(taiKhoan.Trim(), matKhau);
            if (user == null)
            {
                thongBaoLoi = "Tài khoản hoặc mật khẩu không chính xác!";
                return null;
            }
            return user;
        }

        public bool DoiMatKhau(int maND, string mkCu, string mkMoi, string xacNhanMk, string mkHienTai, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(mkCu) || string.IsNullOrWhiteSpace(mkMoi))
            {
                thongBaoLoi = "Vui lòng nhập đầy đủ các trường!";
                return false;
            }
            if (mkCu != mkHienTai)
            {
                thongBaoLoi = "Mật khẩu hiện tại không đúng!";
                return false;
            }
            if (mkMoi.Length < 6)
            {
                thongBaoLoi = "Mật khẩu mới phải có tối thiểu 6 ký tự!";
                return false;
            }
            if (mkMoi != xacNhanMk)
            {
                thongBaoLoi = "Xác nhận mật khẩu mới không khớp!";
                return false;
            }

            return _dal.DoiMatKhau(maND, mkMoi);
        }
    }
}
