using System;
using System.Windows.Forms;
using ThiTracNghiem.BLL;
using ThiTracNghiem.DTO;

namespace ThiTracNghiem.GUI
{
    public partial class frmDangNhap : Form
    {
        private readonly NguoiDungBLL _bll = new NguoiDungBLL();

        public frmDangNhap()
        {
            frmFlash flash = new frmFlash();
            flash.ShowDialog();

            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(taiKhoan))
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui lòng nhập tài khoản!");
                txtTaiKhoan.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhau))
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            try
            {
                string loi = "";
                NguoiDungDTO user = _bll.DangNhap(taiKhoan, matKhau, out loi);
                if (user != null)
                {
                    Session.NguoiDungHienTai = user;
                    this.Hide();
                    frmMain main = new frmMain();
                    main.FormClosed += (s, args) =>
                    {
                        txtMatKhau.Clear();
                        this.Show();
                    };
                    main.Show();
                }
                else
                {
                    MessageBox.Show(loi, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
