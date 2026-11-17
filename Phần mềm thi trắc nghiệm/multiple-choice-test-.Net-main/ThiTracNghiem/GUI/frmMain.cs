using System;
using System.Windows.Forms;

namespace ThiTracNghiem.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            CapNhatThongTinNguoiDung();
        }

        private void PhanQuyen()
        {
            if (Session.NguoiDungHienTai == null) return;

            // Nếu là Thí sinh, ẩn menu Quản lý
            if (Session.IsThiSinh)
            {
                menuQuanLy.Visible = false;
                // Tự động mở form thi cho thí sinh
                MoFormCon<frmThiTracNghiem>();
            }
            else
            {
                menuQuanLy.Visible = true;
                // Admin mặc định mở Quản lý môn học
                MoFormCon<frmQuanLyMonHoc>();
            }
        }

        private void CapNhatThongTinNguoiDung()
        {
            if (Session.NguoiDungHienTai != null)
            {
                lblTrangThaiNguoiDung.Text = $"Người dùng: {Session.NguoiDungHienTai.HoTen} ({Session.NguoiDungHienTai.VaiTro})";
            }
            lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        public void MoFormCon<T>() where T : Form, new()
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    return;
                }
            }

            T formMoi = new T();
            formMoi.MdiParent = this;
            formMoi.Show();
        }

        private void menuQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            MoFormCon<frmQuanLyMonHoc>();
        }

        private void menuQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            MoFormCon<frmQuanLyCauHoi>();
        }

        private void menuLamBaiThi_Click(object sender, EventArgs e)
        {
            MoFormCon<frmThiTracNghiem>();
        }

        private void menuLichSuKetQua_Click(object sender, EventArgs e)
        {
            MoFormCon<frmLichSuKetQua>();
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.DangXuat();
                this.Close();
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuThongTin_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }
    }
}
