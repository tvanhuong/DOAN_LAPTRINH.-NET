using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.GUI
{
    public partial class frmLichSuKetQua : Form
    {
        private readonly BaiThiBLL _baiThiBLL = new BaiThiBLL();
        private readonly MonHocBLL _monHocBLL = new MonHocBLL();

        public frmLichSuKetQua()
        {
            InitializeComponent();
        }

        private void frmLichSuKetQua_Load(object sender, EventArgs e)
        {
            TaiDanhSachMon();
            TaiDuLieuLichSu();
        }

        private void TaiDanhSachMon()
        {
            try
            {
                List<MonHocDTO> list = _monHocBLL.LayDanhSachMon();
                list.Insert(0, new MonHocDTO { MaMon = "ALL", TenMon = "-- Tất cả các môn --" });

                cboLocMon.DataSource = list;
                cboLocMon.DisplayMember = "TenMon";
                cboLocMon.ValueMember = "MaMon";
                cboLocMon.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaiDuLieuLichSu()
        {
            try
            {
                dgvLichSu.AutoGenerateColumns = false;

                // Nếu là Thí sinh, chỉ xem kết quả của chính mình
                int? maND = Session.IsAdmin ? (int?)null : Session.NguoiDungHienTai?.MaND;
                string maMon = cboLocMon.SelectedValue?.ToString() ?? "ALL";

                DataTable dt = _baiThiBLL.LayLichSuThi(maND, maMon);
                dgvLichSu.DataSource = dt;

                // Tính thống kê
                int tongBai = dt.Rows.Count;
                double tongDiem = 0;
                double maxDiem = 0;

                foreach (DataRow r in dt.Rows)
                {
                    double d = Convert.ToDouble(r["DiemSo"]);
                    tongDiem += d;
                    if (d > maxDiem) maxDiem = d;
                }

                double dtb = (tongBai > 0) ? Math.Round(tongDiem / tongBai, 2) : 0;
                lblThongKe.Text = $"Tổng số lượt thi: {tongBai}  |  Điểm cao nhất: {maxDiem}  |  Điểm trung bình: {dtb}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLocMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaiDuLieuLichSu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiDuLieuLichSu();
        }
    }
}
