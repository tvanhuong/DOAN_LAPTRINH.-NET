using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.DAL
{
    public class CauHoiDAL
    {
        public List<CauHoiDTO> LayCauHoiTheoMon(string maMon)
        {
            List<CauHoiDTO> list = new List<CauHoiDTO>();
            string sql = "SELECT MaCauHoi, MaMon, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung FROM CauHoi WHERE MaMon = @ma";
            SqlParameter[] p = { new SqlParameter("@ma", maMon) };
            DataTable dt = DatabaseHelper.ExecuteQuery(sql, p);
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new CauHoiDTO
                {
                    MaCauHoi = Convert.ToInt32(r["MaCauHoi"]),
                    MaMon = r["MaMon"].ToString(),
                    NoiDung = r["NoiDung"].ToString(),
                    DapAnA = r["DapAnA"].ToString(),
                    DapAnB = r["DapAnB"].ToString(),
                    DapAnC = r["DapAnC"].ToString(),
                    DapAnD = r["DapAnD"].ToString(),
                    DapAnDung = r["DapAnDung"].ToString()
                });
            }
            return list;
        }

        public List<CauHoiDTO> LayCauHoiThiNgauNhien(string maMon, int soLuong)
        {
            List<CauHoiDTO> list = new List<CauHoiDTO>();
            string sql = "SELECT TOP (@top) MaCauHoi, MaMon, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung " +
                         "FROM CauHoi WHERE MaMon = @ma ORDER BY NEWID()";
            SqlParameter[] p = {
                new SqlParameter("@top", soLuong),
                new SqlParameter("@ma", maMon)
            };
            DataTable dt = DatabaseHelper.ExecuteQuery(sql, p);
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new CauHoiDTO
                {
                    MaCauHoi = Convert.ToInt32(r["MaCauHoi"]),
                    MaMon = r["MaMon"].ToString(),
                    NoiDung = r["NoiDung"].ToString(),
                    DapAnA = r["DapAnA"].ToString(),
                    DapAnB = r["DapAnB"].ToString(),
                    DapAnC = r["DapAnC"].ToString(),
                    DapAnD = r["DapAnD"].ToString(),
                    DapAnDung = r["DapAnDung"].ToString(),
                    DapAnChon = ""
                });
            }
            return list;
        }

        public bool ThemCauHoi(CauHoiDTO c)
        {
            string sql = "INSERT INTO CauHoi (MaMon, NoiDung, DapAnA, DapAnB, DapAnC, DapAnD, DapAnDung) " +
                         "VALUES (@mamon, @noidung, @a, @b, @c, @d, @dung)";
            SqlParameter[] p = {
                new SqlParameter("@mamon", c.MaMon),
                new SqlParameter("@noidung", c.NoiDung),
                new SqlParameter("@a", c.DapAnA),
                new SqlParameter("@b", c.DapAnB),
                new SqlParameter("@c", c.DapAnC),
                new SqlParameter("@d", c.DapAnD),
                new SqlParameter("@dung", c.DapAnDung)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }

        public bool CapNhatCauHoi(CauHoiDTO c)
        {
            string sql = "UPDATE CauHoi SET MaMon = @mamon, NoiDung = @noidung, DapAnA = @a, DapAnB = @b, " +
                         "DapAnC = @c, DapAnD = @d, DapAnDung = @dung WHERE MaCauHoi = @id";
            SqlParameter[] p = {
                new SqlParameter("@mamon", c.MaMon),
                new SqlParameter("@noidung", c.NoiDung),
                new SqlParameter("@a", c.DapAnA),
                new SqlParameter("@b", c.DapAnB),
                new SqlParameter("@c", c.DapAnC),
                new SqlParameter("@d", c.DapAnD),
                new SqlParameter("@dung", c.DapAnDung),
                new SqlParameter("@id", c.MaCauHoi)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }

        public bool XoaCauHoi(int maCauHoi)
        {
            string sql = "DELETE FROM CauHoi WHERE MaCauHoi = @id";
            SqlParameter[] p = { new SqlParameter("@id", maCauHoi) };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
