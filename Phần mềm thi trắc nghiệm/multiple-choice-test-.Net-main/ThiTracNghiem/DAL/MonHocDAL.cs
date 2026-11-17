using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.DAL
{
    public class MonHocDAL
    {
        public List<MonHocDTO> LayTatCaMonHoc()
        {
            List<MonHocDTO> list = new List<MonHocDTO>();
            string sql = "SELECT MaMon, TenMon, ThoiGianThi, SoCauHoi FROM MonHoc ORDER BY TenMon";
            DataTable dt = DatabaseHelper.ExecuteQuery(sql);
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new MonHocDTO(
                    r["MaMon"].ToString(),
                    r["TenMon"].ToString(),
                    Convert.ToInt32(r["ThoiGianThi"]),
                    Convert.ToInt32(r["SoCauHoi"])
                ));
            }
            return list;
        }

        public bool KiemTraTonTai(string maMon)
        {
            string sql = "SELECT COUNT(*) FROM MonHoc WHERE MaMon = @ma";
            SqlParameter[] p = { new SqlParameter("@ma", maMon) };
            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sql, p));
            return count > 0;
        }

        public bool ThemMonHoc(MonHocDTO m)
        {
            string sql = "INSERT INTO MonHoc (MaMon, TenMon, ThoiGianThi, SoCauHoi) VALUES (@ma, @ten, @time, @socau)";
            SqlParameter[] p = {
                new SqlParameter("@ma", m.MaMon),
                new SqlParameter("@ten", m.TenMon),
                new SqlParameter("@time", m.ThoiGianThi),
                new SqlParameter("@socau", m.SoCauHoi)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }

        public bool CapNhatMonHoc(MonHocDTO m)
        {
            string sql = "UPDATE MonHoc SET TenMon = @ten, ThoiGianThi = @time, SoCauHoi = @socau WHERE MaMon = @ma";
            SqlParameter[] p = {
                new SqlParameter("@ten", m.TenMon),
                new SqlParameter("@time", m.ThoiGianThi),
                new SqlParameter("@socau", m.SoCauHoi),
                new SqlParameter("@ma", m.MaMon)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }

        public bool XoaMonHoc(string maMon)
        {
            string sql = "DELETE FROM MonHoc WHERE MaMon = @ma";
            SqlParameter[] p = { new SqlParameter("@ma", maMon) };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
