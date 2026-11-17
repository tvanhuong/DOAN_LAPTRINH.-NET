using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.DAL
{
    public class BaiThiDAL
    {
        public bool LuuKetQua(BaiThiDTO bt)
        {
            string sql = "INSERT INTO BaiThi (MaND, MaMon, NgayThi, SoCauDung, TongSoCau, DiemSo) " +
                         "VALUES (@mand, @mamon, GETDATE(), @sodung, @tong, @diem)";
            SqlParameter[] p = {
                new SqlParameter("@mand", bt.MaND),
                new SqlParameter("@mamon", bt.MaMon),
                new SqlParameter("@sodung", bt.SoCauDung),
                new SqlParameter("@tong", bt.TongSoCau),
                new SqlParameter("@diem", bt.DiemSo)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }

        public DataTable LayLichSuThi(int? maND = null, string maMon = null)
        {
            string sql = "SELECT b.MaBaiThi, u.HoTen, m.TenMon, b.NgayThi, b.SoCauDung, b.TongSoCau, b.DiemSo " +
                         "FROM BaiThi b " +
                         "JOIN NguoiDung u ON b.MaND = u.MaND " +
                         "JOIN MonHoc m ON b.MaMon = m.MaMon WHERE 1=1 ";

            List<SqlParameter> pList = new List<SqlParameter>();
            if (maND.HasValue)
            {
                sql += " AND b.MaND = @mand";
                pList.Add(new SqlParameter("@mand", maND.Value));
            }
            if (!string.IsNullOrEmpty(maMon) && maMon != "ALL")
            {
                sql += " AND b.MaMon = @mamon";
                pList.Add(new SqlParameter("@mamon", maMon));
            }
            sql += " ORDER BY b.NgayThi DESC";

            return DatabaseHelper.ExecuteQuery(sql, pList.ToArray());
        }
    }
}
