using System.Collections.Generic;
using ThiTracNghiem.DAL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.BLL
{
    public class MonHocBLL
    {
        private readonly MonHocDAL _dal = new MonHocDAL();

        public List<MonHocDTO> LayDanhSachMon()
        {
            return _dal.LayTatCaMonHoc();
        }

        public bool ThemMonHoc(MonHocDTO m, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(m.MaMon))
            {
                thongBaoLoi = "Mã môn học không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(m.TenMon))
            {
                thongBaoLoi = "Tên môn học không được để trống!";
                return false;
            }
            if (m.ThoiGianThi <= 0)
            {
                thongBaoLoi = "Thời gian thi phải lớn hơn 0 phút!";
                return false;
            }
            if (m.SoCauHoi <= 0)
            {
                thongBaoLoi = "Số câu hỏi phải lớn hơn 0!";
                return false;
            }
            if (_dal.KiemTraTonTai(m.MaMon.Trim()))
            {
                thongBaoLoi = "Mã môn học đã tồn tại trong hệ thống!";
                return false;
            }

            return _dal.ThemMonHoc(m);
        }

        public bool CapNhatMonHoc(MonHocDTO m, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(m.TenMon))
            {
                thongBaoLoi = "Tên môn học không được để trống!";
                return false;
            }
            if (m.ThoiGianThi <= 0 || m.SoCauHoi <= 0)
            {
                thongBaoLoi = "Thời gian thi và số câu hỏi phải lớn hơn 0!";
                return false;
            }

            return _dal.CapNhatMonHoc(m);
        }

        public bool XoaMonHoc(string maMon, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(maMon))
            {
                thongBaoLoi = "Mã môn không hợp lệ!";
                return false;
            }
            return _dal.XoaMonHoc(maMon);
        }
    }
}
