using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.GUI
{
    public partial class frmThiTracNghiem : Form
    {
        private readonly MonHocBLL _monHocBLL = new MonHocBLL();
        private readonly CauHoiBLL _cauHoiBLL = new CauHoiBLL();
        private readonly BaiThiBLL _baiThiBLL = new BaiThiBLL();

        private List<CauHoiDTO> _danhSachCauHoi = new List<CauHoiDTO>();
        private int _cauHienTai = 0;
        private int _thoiGianConLaiGiay = 0;
        private bool _daNopBai = false;
        private MonHocDTO _monDangThi = null;
        private List<Button> _listButtonCauHoi = new List<Button>();

        public frmThiTracNghiem()
        {
            InitializeComponent();
        }

        private void frmThiTracNghiem_Load(object sender, EventArgs e)
        {
            TaiDanhSachMon();
        }

        private void TaiDanhSachMon()
        {
            try
            {
                List<MonHocDTO> list = _monHocBLL.LayDanhSachMon();
                cboMonThi.DataSource = list;
                cboMonThi.DisplayMember = "TenMon";
                cboMonThi.ValueMember = "MaMon";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải môn thi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (cboMonThi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn môn thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _monDangThi = (MonHocDTO)cboMonThi.SelectedItem;
            _danhSachCauHoi = _cauHoiBLL.LayDeThi(_monDangThi.MaMon, _monDangThi.SoCauHoi);

            if (_danhSachCauHoi == null || _danhSachCauHoi.Count == 0)
            {
                MessageBox.Show("Môn học này hiện chưa có câu hỏi trong ngân hàng đề! Vui lòng chọn môn khác hoặc thêm câu hỏi.", 
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thiết lập trạng thái bắt đầu thi
            _cauHienTai = 0;
            _daNopBai = false;
            _thoiGianConLaiGiay = _monDangThi.ThoiGianThi * 60;

            cboMonThi.Enabled = false;
            btnBatDau.Enabled = false;
            btnNopBai.Enabled = true;
            pnlNoiDungThi.Visible = true;

            KhoiTaoNutCauHoi();
            HienThiCauHoi(_cauHienTai);

            timerThi.Start();
            CapNhatDongHo();
        }

        private void KhoiTaoNutCauHoi()
        {
            pnlDanhSachCau.Controls.Clear();
            _listButtonCauHoi.Clear();

            for (int i = 0; i < _danhSachCauHoi.Count; i++)
            {
                int index = i;
                Button btn = new Button
                {
                    Text = (i + 1).ToString(),
                    Width = 45,
                    Height = 45,
                    Margin = new Padding(4),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    BackColor = Color.WhiteSmoke,
                    Cursor = Cursors.Hand
                };
                btn.Click += (s, e) =>
                {
                    LuuDapAnCauHienTai();
                    _cauHienTai = index;
                    HienThiCauHoi(_cauHienTai);
                };

                _listButtonCauHoi.Add(btn);
                pnlDanhSachCau.Controls.Add(btn);
            }
        }

        private void HienThiCauHoi(int index)
        {
            if (index < 0 || index >= _danhSachCauHoi.Count) return;

            CauHoiDTO ch = _danhSachCauHoi[index];
            lblSoThuTuCau.Text = $"CÂU HỎI {index + 1} / {_danhSachCauHoi.Count}:";
            txtNoiDungCauHoi.Text = ch.NoiDung;

            rdoA.Text = "A. " + ch.DapAnA;
            rdoB.Text = "B. " + ch.DapAnB;
            rdoC.Text = "C. " + ch.DapAnC;
            rdoD.Text = "D. " + ch.DapAnD;

            // Xóa chọn trước
            rdoA.Checked = false;
            rdoB.Checked = false;
            rdoC.Checked = false;
            rdoD.Checked = false;

            // Đặt lại đáp án đã chọn trước đó
            if (ch.DapAnChon == "A") rdoA.Checked = true;
            else if (ch.DapAnChon == "B") rdoB.Checked = true;
            else if (ch.DapAnChon == "C") rdoC.Checked = true;
            else if (ch.DapAnChon == "D") rdoD.Checked = true;

            // Nút câu trước / sau
            btnCauTruoc.Enabled = (index > 0);
            btnCauSau.Enabled = (index < _danhSachCauHoi.Count - 1);

            // Làm nổi bật nút câu đang chọn
            for (int i = 0; i < _listButtonCauHoi.Count; i++)
            {
                if (i == index)
                {
                    _listButtonCauHoi[i].FlatAppearance.BorderSize = 2;
                    _listButtonCauHoi[i].FlatAppearance.BorderColor = Color.Navy;
                }
                else
                {
                    _listButtonCauHoi[i].FlatAppearance.BorderSize = 1;
                    _listButtonCauHoi[i].FlatAppearance.BorderColor = Color.DarkGray;
                }
            }

            // Nếu đã nộp bài, hiện đáp án đúng để đối chiếu
            if (_daNopBai)
            {
                lblGiaiThichDapAn.Visible = true;
                lblGiaiThichDapAn.Text = $"Đáp án đúng của câu này là: [{ch.DapAnDung}]";
                lblGiaiThichDapAn.ForeColor = (ch.DapAnChon == ch.DapAnDung) ? Color.DarkGreen : Color.Crimson;
            }
            else
            {
                lblGiaiThichDapAn.Visible = false;
            }
        }

        private void LuuDapAnCauHienTai()
        {
            if (_daNopBai || _danhSachCauHoi.Count == 0) return;

            CauHoiDTO ch = _danhSachCauHoi[_cauHienTai];
            if (rdoA.Checked) ch.DapAnChon = "A";
            else if (rdoB.Checked) ch.DapAnChon = "B";
            else if (rdoC.Checked) ch.DapAnChon = "C";
            else if (rdoD.Checked) ch.DapAnChon = "D";

            if (!string.IsNullOrEmpty(ch.DapAnChon))
            {
                _listButtonCauHoi[_cauHienTai].BackColor = Color.ForestGreen;
                _listButtonCauHoi[_cauHienTai].ForeColor = Color.White;
            }
        }

        private void rdoDapAn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (rdo != null && rdo.Checked)
            {
                LuuDapAnCauHienTai();
            }
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            LuuDapAnCauHienTai();
            if (_cauHienTai > 0)
            {
                _cauHienTai--;
                HienThiCauHoi(_cauHienTai);
            }
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            LuuDapAnCauHienTai();
            if (_cauHienTai < _danhSachCauHoi.Count - 1)
            {
                _cauHienTai++;
                HienThiCauHoi(_cauHienTai);
            }
        }

        private void timerThi_Tick(object sender, EventArgs e)
        {
            if (_thoiGianConLaiGiay > 0)
            {
                _thoiGianConLaiGiay--;
                CapNhatDongHo();
            }
            else
            {
                timerThi.Stop();
                MessageBox.Show("Đã hết thời gian làm bài! Hệ thống sẽ tự động nộp bài thi của bạn.", 
                                "Hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XuLyNopBai();
            }
        }

        private void CapNhatDongHo()
        {
            int phut = _thoiGianConLaiGiay / 60;
            int giay = _thoiGianConLaiGiay % 60;
            lblDongHo.Text = $"{phut:D2}:{giay:D2}";

            // Đổi màu đỏ khi còn dưới 1 phút
            if (_thoiGianConLaiGiay <= 60)
            {
                lblDongHo.ForeColor = Color.Crimson;
            }
            else
            {
                lblDongHo.ForeColor = Color.Navy;
            }
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            LuuDapAnCauHienTai();

            // Đếm số câu chưa làm
            int soCauChuaLam = 0;
            foreach (var ch in _danhSachCauHoi)
            {
                if (string.IsNullOrEmpty(ch.DapAnChon)) soCauChuaLam++;
            }

            string canhBao = (soCauChuaLam > 0) 
                ? $"Bạn còn {soCauChuaLam} câu chưa trả lời!\nBạn có chắc chắn muốn nộp bài ngay bây giờ?"
                : "Bạn có chắc chắn muốn nộp bài thi?";

            if (MessageBox.Show(canhBao, "Xác nhận nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerThi.Stop();
                XuLyNopBai();
            }
        }

        private void XuLyNopBai()
        {
            _daNopBai = true;
            btnNopBai.Enabled = false;
            rdoA.Enabled = false;
            rdoB.Enabled = false;
            rdoC.Enabled = false;
            rdoD.Enabled = false;

            int soCauDung = 0;
            double diem = _baiThiBLL.TinhDiem(_danhSachCauHoi, out soCauDung);

            // Cập nhật màu trên các nút câu hỏi: Đúng màu xanh lá, Sai màu đỏ
            for (int i = 0; i < _danhSachCauHoi.Count; i++)
            {
                var ch = _danhSachCauHoi[i];
                if (ch.DapAnChon == ch.DapAnDung)
                {
                    _listButtonCauHoi[i].BackColor = Color.ForestGreen;
                    _listButtonCauHoi[i].ForeColor = Color.White;
                }
                else
                {
                    _listButtonCauHoi[i].BackColor = Color.Crimson;
                    _listButtonCauHoi[i].ForeColor = Color.White;
                }
            }

            // Lưu kết quả vào CSDL
            int maND = (Session.NguoiDungHienTai != null) ? Session.NguoiDungHienTai.MaND : 1;
            _baiThiBLL.LuuKetQuaThi(maND, _monDangThi.MaMon, soCauDung, _danhSachCauHoi.Count, diem);

            // Hiển thị lại câu hiện tại kèm đáp án
            HienThiCauHoi(_cauHienTai);

            // Đánh giá xếp loại
            string xepLoai = (diem >= 8.5) ? "Xuất sắc" : (diem >= 7.0) ? "Khá / Giỏi" : (diem >= 5.0) ? "Đạt" : "Chưa đạt";

            MessageBox.Show($"KẾT QUẢ BÀI THI MÔN [{_monDangThi.TenMon}]\n\n" +
                            $"- Số câu đúng: {soCauDung} / {_danhSachCauHoi.Count}\n" +
                            $"- Điểm số: {diem} / 10.0\n" +
                            $"- Xếp loại: {xepLoai}\n\n" +
                            "(Bạn có thể bấm vào các câu hỏi bên dưới để xem lại chi tiết bài làm và đáp án đúng).", 
                            "Kết Quả Thi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboMonThi.Enabled = true;
            btnBatDau.Enabled = true;
        }
    }
}
