using System;
using System.Collections.Generic;
using System.Data;
using ThiTracNghiem.DAL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.BLL
{
    public class BaiThiBLL
    {
        private readonly BaiThiDAL _dal = new BaiThiDAL();

        public double TinhDiem(List<CauHoiDTO> danhSachCauHoi, out int soCauDung)
        {
            soCauDung = 0;
            if (danhSachCauHoi == null || danhSachCauHoi.Count == 0) return 0;

            foreach (var ch in danhSachCauHoi)
            {
                if (!string.IsNullOrEmpty(ch.DapAnChon) && ch.DapAnChon.Trim().ToUpper() == ch.DapAnDung.Trim().ToUpper())
                {
                    soCauDung++;
                }
            }

            double diem = ((double)soCauDung / danhSachCauHoi.Count) * 10.0;
            return Math.Round(diem, 2);
        }

        public bool LuuKetQuaThi(int maND, string maMon, int soCauDung, int tongSoCau, double diemSo)
        {
            BaiThiDTO bt = new BaiThiDTO
            {
                MaND = maND,
                MaMon = maMon,
                SoCauDung = soCauDung,
                TongSoCau = tongSoCau,
                DiemSo = diemSo
            };
            return _dal.LuuKetQua(bt);
        }

        public DataTable LayLichSuThi(int? maND, string maMon)
        {
            return _dal.LayLichSuThi(maND, maMon);
        }
    }
}
