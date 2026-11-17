using System;
using System.Data;
using System.Data.SqlClient;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.DAL
{
    public class NguoiDungDAL
    {
        public NguoiDungDTO DangNhap(string taiKhoan, string matKhau)
        {
            string sql = "SELECT MaND, TaiKhoan, MatKhau, HoTen, VaiTro FROM NguoiDung WHERE TaiKhoan = @tk AND MatKhau = @mk";
            SqlParameter[] p = {
                new SqlParameter("@tk", taiKhoan),
                new SqlParameter("@mk", matKhau)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, p);
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                return new NguoiDungDTO(
                    Convert.ToInt32(r["MaND"]),
                    r["TaiKhoan"].ToString(),
                    r["MatKhau"].ToString(),
                    r["HoTen"].ToString(),
                    r["VaiTro"].ToString()
                );
            }
            return null;
        }

        public bool DoiMatKhau(int maND, string matKhauMoi)
        {
            string sql = "UPDATE NguoiDung SET MatKhau = @mk WHERE MaND = @id";
            SqlParameter[] p = {
                new SqlParameter("@mk", matKhauMoi),
                new SqlParameter("@id", maND)
            };
            return DatabaseHelper.ExecuteNonQuery(sql, p) > 0;
        }
    }
}
