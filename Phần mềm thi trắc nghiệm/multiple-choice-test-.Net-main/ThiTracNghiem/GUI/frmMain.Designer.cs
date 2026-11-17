namespace ThiTracNghiem.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyMonHoc;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyCauHoi;
        private System.Windows.Forms.ToolStripMenuItem menuThi;
        private System.Windows.Forms.ToolStripMenuItem menuLamBaiThi;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuLichSuKetQua;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem menuThongTin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThaiNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThaiNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLamBaiThi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLichSuKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuThi,
            this.menuBaoCao,
            this.menuCuaSo,
            this.menuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.menuCuaSo;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoiMatKhau,
            this.toolStripSeparator1,
            this.menuDangXuat,
            this.menuThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(81, 23);
            this.menuHeThong.Text = "&Hệ Thống";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyMonHoc,
            this.menuQuanLyCauHoi});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(72, 23);
            this.menuQuanLy.Text = "&Quản Lý";
            // 
            // menuThi
            // 
            this.menuThi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLamBaiThi});
            this.menuThi.Name = "menuThi";
            this.menuThi.Size = new System.Drawing.Size(119, 23);
            this.menuThi.Text = "&Thi Trắc Nghiệm";
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLichSuKetQua});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(115, 23);
            this.menuBaoCao.Text = "&Kết Quả Bài Thi";
            // 
            // menuCuaSo
            // 
            this.menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCascade,
            this.menuTileHorizontal,
            this.menuTileVertical});
            this.menuCuaSo.Name = "menuCuaSo";
            this.menuCuaSo.Size = new System.Drawing.Size(64, 23);
            this.menuCuaSo.Text = "&Cửa Sổ";
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongTin});
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(73, 23);
            this.menuTroGiup.Text = "&Trợ Giúp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThaiNguoiDung,
            this.lblThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThaiNguoiDung
            // 
            this.lblTrangThaiNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTrangThaiNguoiDung.ForeColor = System.Drawing.Color.Navy;
            this.lblTrangThaiNguoiDung.Name = "lblTrangThaiNguoiDung";
            this.lblTrangThaiNguoiDung.Size = new System.Drawing.Size(898, 17);
            this.lblTrangThaiNguoiDung.Spring = true;
            this.lblTrangThaiNguoiDung.Text = "Người dùng: Khách";
            this.lblTrangThaiNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(95, 17);
            this.lblThoiGian.Text = "01/01/2026 00:00";
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Image = global::ThiTracNghiem.Properties.Resources.reset_password;
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(164, 24);
            this.menuDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.menuDoiMatKhau_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Image = global::ThiTracNghiem.Properties.Resources.icons8_logout_32;
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(164, 24);
            this.menuDangXuat.Text = "Đăng &Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Image = global::ThiTracNghiem.Properties.Resources.exit_16;
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuThoat.Size = new System.Drawing.Size(164, 24);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuQuanLyMonHoc
            // 
            this.menuQuanLyMonHoc.Image = global::ThiTracNghiem.Properties.Resources.education;
            this.menuQuanLyMonHoc.Name = "menuQuanLyMonHoc";
            this.menuQuanLyMonHoc.Size = new System.Drawing.Size(201, 24);
            this.menuQuanLyMonHoc.Text = "Quản Lý Môn Học";
            this.menuQuanLyMonHoc.Click += new System.EventHandler(this.menuQuanLyMonHoc_Click);
            // 
            // menuQuanLyCauHoi
            // 
            this.menuQuanLyCauHoi.Image = global::ThiTracNghiem.Properties.Resources.strategic_consulting;
            this.menuQuanLyCauHoi.Name = "menuQuanLyCauHoi";
            this.menuQuanLyCauHoi.Size = new System.Drawing.Size(201, 24);
            this.menuQuanLyCauHoi.Text = "Ngân Hàng Câu Hỏi";
            this.menuQuanLyCauHoi.Click += new System.EventHandler(this.menuQuanLyCauHoi_Click);
            // 
            // menuLamBaiThi
            // 
            this.menuLamBaiThi.Image = global::ThiTracNghiem.Properties.Resources.exam_time;
            this.menuLamBaiThi.Name = "menuLamBaiThi";
            this.menuLamBaiThi.Size = new System.Drawing.Size(148, 24);
            this.menuLamBaiThi.Text = "Làm Bài Thi";
            this.menuLamBaiThi.Click += new System.EventHandler(this.menuLamBaiThi_Click);
            // 
            // menuLichSuKetQua
            // 
            this.menuLichSuKetQua.Image = global::ThiTracNghiem.Properties.Resources.file;
            this.menuLichSuKetQua.Name = "menuLichSuKetQua";
            this.menuLichSuKetQua.Size = new System.Drawing.Size(187, 24);
            this.menuLichSuKetQua.Text = "Lịch Sử & Thống Kê";
            this.menuLichSuKetQua.Click += new System.EventHandler(this.menuLichSuKetQua_Click);
            // 
            // menuCascade
            // 
            this.menuCascade.Image = global::ThiTracNghiem.Properties.Resources.window;
            this.menuCascade.Name = "menuCascade";
            this.menuCascade.Size = new System.Drawing.Size(180, 24);
            this.menuCascade.Text = "Xếp lớp";
            this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
            // 
            // menuTileHorizontal
            // 
            this.menuTileHorizontal.Image = global::ThiTracNghiem.Properties.Resources.split__1_;
            this.menuTileHorizontal.Name = "menuTileHorizontal";
            this.menuTileHorizontal.Size = new System.Drawing.Size(180, 24);
            this.menuTileHorizontal.Text = "Xếp ngang";
            this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);
            // 
            // menuTileVertical
            // 
            this.menuTileVertical.Image = global::ThiTracNghiem.Properties.Resources.split;
            this.menuTileVertical.Name = "menuTileVertical";
            this.menuTileVertical.Size = new System.Drawing.Size(180, 24);
            this.menuTileVertical.Text = "Xếp dọc";
            this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);
            // 
            // menuThongTin
            // 
            this.menuThongTin.Image = global::ThiTracNghiem.Properties.Resources.icons8_information_16;
            this.menuThongTin.Name = "menuThongTin";
            this.menuThongTin.Size = new System.Drawing.Size(139, 24);
            this.menuThongTin.Text = "Thông Tin";
            this.menuThongTin.Click += new System.EventHandler(this.menuThongTin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
