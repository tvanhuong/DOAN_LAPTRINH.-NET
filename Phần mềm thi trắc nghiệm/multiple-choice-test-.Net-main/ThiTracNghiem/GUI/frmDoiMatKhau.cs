using System;
using System.Windows.Forms;
using ThiTracNghiem.BLL;

namespace ThiTracNghiem.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        private readonly NguoiDungBLL _bll = new NguoiDungBLL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string mkCu = txtMatKhauCu.Text;
            string mkMoi = txtMatKhauMoi.Text;
            string xacNhan = txtXacNhanMoi.Text;

            if (Session.NguoiDungHienTai == null)
            {
                MessageBox.Show("Phiên làm việc đã hết hạn. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            string loi = "";
            bool ok = _bll.DoiMatKhau(Session.NguoiDungHienTai.MaND, mkCu, mkMoi, xacNhan, Session.NguoiDungHienTai.MatKhau, out loi);

            if (ok)
            {
                Session.NguoiDungHienTai.MatKhau = mkMoi;
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(loi, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
