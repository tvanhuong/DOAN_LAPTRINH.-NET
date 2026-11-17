using System.Collections.Generic;
using ThiTracNghiem.DAL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.BLL
{
    public class CauHoiBLL
    {
        private readonly CauHoiDAL _dal = new CauHoiDAL();

        public List<CauHoiDTO> LayCauHoiTheoMon(string maMon)
        {
            return _dal.LayCauHoiTheoMon(maMon);
        }

        public List<CauHoiDTO> LayDeThi(string maMon, int soCau)
        {
            return _dal.LayCauHoiThiNgauNhien(maMon, soCau);
        }

        public bool ThemCauHoi(CauHoiDTO c, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (!KiemTraHopLe(c, out thongBaoLoi)) return false;
            return _dal.ThemCauHoi(c);
        }

        public bool CapNhatCauHoi(CauHoiDTO c, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (c.MaCauHoi <= 0)
            {
                thongBaoLoi = "Chưa chọn câu hỏi cần cập nhật!";
                return false;
            }
            if (!KiemTraHopLe(c, out thongBaoLoi)) return false;
            return _dal.CapNhatCauHoi(c);
        }

        public bool XoaCauHoi(int maCauHoi, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (maCauHoi <= 0)
            {
                thongBaoLoi = "Mã câu hỏi không hợp lệ!";
                return false;
            }
            return _dal.XoaCauHoi(maCauHoi);
        }

        private bool KiemTraHopLe(CauHoiDTO c, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(c.MaMon))
            {
                thongBaoLoi = "Vui lòng chọn môn học!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(c.NoiDung))
            {
                thongBaoLoi = "Nội dung câu hỏi không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(c.DapAnA) || string.IsNullOrWhiteSpace(c.DapAnB) ||
                string.IsNullOrWhiteSpace(c.DapAnC) || string.IsNullOrWhiteSpace(c.DapAnD))
            {
                thongBaoLoi = "Phải nhập đầy đủ cả 4 đáp án A, B, C, D!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(c.DapAnDung) || !"ABCD".Contains(c.DapAnDung))
            {
                thongBaoLoi = "Đáp án đúng phải là một trong 4 lựa chọn: A, B, C, hoặc D!";
                return false;
            }
            return true;
        }
    }
}
