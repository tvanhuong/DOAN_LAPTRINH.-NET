using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.GUI
{
    public partial class frmQuanLyCauHoi : Form
    {
        private readonly CauHoiBLL _cauHoiBLL = new CauHoiBLL();
        private readonly MonHocBLL _monHocBLL = new MonHocBLL();
        private int _maCauHoiDangChon = 0;

        public frmQuanLyCauHoi()
        {
            InitializeComponent();
        }

        private void frmQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            TaiDanhSachMonHoc();
        }

        private void TaiDanhSachMonHoc()
        {
            try
            {
                cboDapAnDung.Items.Clear();
                cboDapAnDung.Items.AddRange(new object[] { "A", "B", "C", "D" });
                cboDapAnDung.SelectedIndex = 0;

                List<MonHocDTO> list = _monHocBLL.LayDanhSachMon();
                cboMonHoc.DataSource = list;
                cboMonHoc.DisplayMember = "TenMon";
                cboMonHoc.ValueMember = "MaMon";

                

                if (list.Count > 0)
                {
                    cboMonHoc.SelectedIndex = 0;
                    TaiDanhSachCauHoi(list[0].MaMon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonHoc.SelectedValue != null)
            {
                string maMon = cboMonHoc.SelectedValue.ToString();
                TaiDanhSachCauHoi(maMon);
                LamMoiForm();
            }
        }

        private void TaiDanhSachCauHoi(string maMon)
        {
            try
            {
                dgvCauHoi.AutoGenerateColumns = false;
                List<CauHoiDTO> list = _cauHoiBLL.LayCauHoiTheoMon(maMon);
                dgvCauHoi.DataSource = list;
                lblTongSoCau.Text = $"Tổng số câu hỏi: {list.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải câu hỏi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCauHoi.Rows.Count)
            {
                DataGridViewRow row = dgvCauHoi.Rows[e.RowIndex];
                _maCauHoiDangChon = Convert.ToInt32(row.Cells["colMaCauHoi"].Value);
                txtNoiDung.Text = row.Cells["colNoiDung"].Value?.ToString();
                txtDapAnA.Text = row.Cells["colDapAnA"].Value?.ToString();
                txtDapAnB.Text = row.Cells["colDapAnB"].Value?.ToString();
                txtDapAnC.Text = row.Cells["colDapAnC"].Value?.ToString();
                txtDapAnD.Text = row.Cells["colDapAnD"].Value?.ToString();

                string dapAnDung = row.Cells["colDapAnDung"].Value?.ToString()?.Trim();
                cboDapAnDung.SelectedItem = dapAnDung;
            }
        }

        private bool ValidateDuLieu()
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (cboMonHoc.SelectedValue == null)
            {
                errorProvider1.SetError(cboMonHoc, "Vui lòng chọn môn học!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                errorProvider1.SetError(txtNoiDung, "Nội dung câu hỏi không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDapAnA.Text))
            {
                errorProvider1.SetError(txtDapAnA, "Vui lòng nhập đáp án A!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDapAnB.Text))
            {
                errorProvider1.SetError(txtDapAnB, "Vui lòng nhập đáp án B!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDapAnC.Text))
            {
                errorProvider1.SetError(txtDapAnC, "Vui lòng nhập đáp án C!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDapAnD.Text))
            {
                errorProvider1.SetError(txtDapAnD, "Vui lòng nhập đáp án D!");
                isValid = false;
            }

            if (cboDapAnDung.SelectedItem == null)
            {
                errorProvider1.SetError(cboDapAnDung, "Vui lòng chọn đáp án đúng!");
                isValid = false;
            }

            return isValid;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateDuLieu()) return;

            CauHoiDTO c = new CauHoiDTO
            {
                MaMon = cboMonHoc.SelectedValue.ToString(),
                NoiDung = txtNoiDung.Text.Trim(),
                DapAnA = txtDapAnA.Text.Trim(),
                DapAnB = txtDapAnB.Text.Trim(),
                DapAnC = txtDapAnC.Text.Trim(),
                DapAnD = txtDapAnD.Text.Trim(),
                DapAnDung = cboDapAnDung.SelectedItem.ToString()
            };

            string loi = "";
            if (_cauHoiBLL.ThemCauHoi(c, out loi))
            {
                MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachCauHoi(c.MaMon);
                LamMoiForm();
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maCauHoiDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi cần sửa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateDuLieu()) return;

            CauHoiDTO c = new CauHoiDTO
            {
                MaCauHoi = _maCauHoiDangChon,
                MaMon = cboMonHoc.SelectedValue.ToString(),
                NoiDung = txtNoiDung.Text.Trim(),
                DapAnA = txtDapAnA.Text.Trim(),
                DapAnB = txtDapAnB.Text.Trim(),
                DapAnC = txtDapAnC.Text.Trim(),
                DapAnD = txtDapAnD.Text.Trim(),
                DapAnDung = cboDapAnDung.SelectedItem.ToString()
            };

            string loi = "";
            if (_cauHoiBLL.CapNhatCauHoi(c, out loi))
            {
                MessageBox.Show("Cập nhật câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDanhSachCauHoi(c.MaMon);
                LamMoiForm();
            }
            else
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maCauHoiDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa câu hỏi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string loi = "";
                if (_cauHoiBLL.XoaCauHoi(_maCauHoiDangChon, out loi))
                {
                    MessageBox.Show("Xóa câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachCauHoi(cboMonHoc.SelectedValue.ToString());
                    LamMoiForm();
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            _maCauHoiDangChon = 0;
            txtNoiDung.Clear();
            txtDapAnA.Clear();
            txtDapAnB.Clear();
            txtDapAnC.Clear();
            txtDapAnD.Clear();
            cboDapAnDung.SelectedIndex = 0;
            errorProvider1.Clear();
            txtNoiDung.Focus();
        }
    }
}
