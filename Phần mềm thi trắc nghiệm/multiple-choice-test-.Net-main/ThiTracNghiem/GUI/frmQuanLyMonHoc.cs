using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.GUI
{
    public partial class frmQuanLyMonHoc : Form
    {
        private readonly MonHocBLL _bll = new MonHocBLL();

        public frmQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            TaiDanhSachMonHoc();
        }

        private void TaiDanhSachMonHoc()
        {
            try
            {
                dgvMonHoc.AutoGenerateColumns = false;
                List<MonHocDTO> list = _bll.LayDanhSachMon();
                dgvMonHoc.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMonHoc.Rows.Count)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
                txtMaMon.Text = row.Cells["colMaMon"].Value?.ToString();
                txtTenMon.Text = row.Cells["colTenMon"].Value?.ToString();
                nudThoiGianThi.Value = Convert.ToDecimal(row.Cells["colThoiGianThi"].Value ?? 15);
                nudSoCauHoi.Value = Convert.ToDecimal(row.Cells["colSoCauHoi"].Value ?? 10);
                txtMaMon.Enabled = false; // Khóa mã môn khi đang chọn sửa
            }
        }

        private bool ValidateDuLieu(bool isThemMoi)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (isThemMoi && string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                errorProvider1.SetError(txtMaMon, "Mã môn học không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                errorProvider1.SetError(txtTenMon, "Tên môn học không được để trống!");
                isValid = false;
            }

            if (nudThoiGianThi.Value <= 0)
            {
                errorProvider1.SetError(nudThoiGianThi, "Thời gian thi phải lớn hơn 0 phút!");
                isValid = false;
            }

            if (nudSoCauHoi.Value <= 0)
            {
                errorProvider1.SetError(nudSoCauHoi, "Số câu hỏi phải lớn hơn 0!");
                isValid = false;
            }

            return isValid;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateDuLieu(true)) return;

            MonHocDTO m = new MonHocDTO
            {
                MaMon = txtMaMon.Text.Trim().ToUpper(),
                TenMon = txtTenMon.Text.Trim(),
                ThoiGianThi = (int)nudThoiGianThi.Value,
                SoCauHoi = (int)nudSoCauHoi.Value
            };

            string loi = "";
            if (_bll.ThemMonHoc(m, out loi))
            {
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachMonHoc();
                btnLamMoi_Click(null, null);
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học từ bảng để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateDuLieu(false)) return;

            MonHocDTO m = new MonHocDTO
            {
                MaMon = txtMaMon.Text.Trim(),
                TenMon = txtTenMon.Text.Trim(),
                ThoiGianThi = (int)nudThoiGianThi.Value,
                SoCauHoi = (int)nudSoCauHoi.Value
            };

            string loi = "";
            if (_bll.CapNhatMonHoc(m, out loi))
            {
                MessageBox.Show("Cập nhật môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachMonHoc();
                btnLamMoi_Click(null, null);
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa từ bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa môn [{txtTenMon.Text}]?\nLưu ý: Toàn bộ câu hỏi liên quan cũng sẽ bị xóa!", 
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string loi = "";
                if (_bll.XoaMonHoc(txtMaMon.Text.Trim(), out loi))
                {
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachMonHoc();
                    btnLamMoi_Click(null, null);
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            nudThoiGianThi.Value = 15;
            nudSoCauHoi.Value = 10;
            txtMaMon.Enabled = true;
            errorProvider1.Clear();
            txtMaMon.Focus();
        }
    }
}
