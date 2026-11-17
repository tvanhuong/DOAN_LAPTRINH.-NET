namespace ThiTracNghiem.GUI
{
    partial class frmQuanLyCauHoi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblChonMon;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label lblTongSoCau;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblDapAnA;
        private System.Windows.Forms.TextBox txtDapAnA;
        private System.Windows.Forms.Label lblDapAnB;
        private System.Windows.Forms.TextBox txtDapAnB;
        private System.Windows.Forms.Label lblDapAnC;
        private System.Windows.Forms.TextBox txtDapAnC;
        private System.Windows.Forms.Label lblDapAnD;
        private System.Windows.Forms.TextBox txtDapAnD;
        private System.Windows.Forms.Label lblDapAnDung;
        private System.Windows.Forms.ComboBox cboDapAnDung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDapAnDung;
        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblChonMon = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.lblTongSoCau = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblDapAnA = new System.Windows.Forms.Label();
            this.txtDapAnA = new System.Windows.Forms.TextBox();
            this.lblDapAnB = new System.Windows.Forms.Label();
            this.txtDapAnB = new System.Windows.Forms.TextBox();
            this.lblDapAnC = new System.Windows.Forms.Label();
            this.txtDapAnC = new System.Windows.Forms.TextBox();
            this.lblDapAnD = new System.Windows.Forms.Label();
            this.txtDapAnD = new System.Windows.Forms.TextBox();
            this.lblDapAnDung = new System.Windows.Forms.Label();
            this.cboDapAnDung = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.colMaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDapAnDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTongSoCau);
            this.pnlTop.Controls.Add(this.cboMonHoc);
            this.pnlTop.Controls.Add(this.lblChonMon);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 45);
            this.pnlTop.TabIndex = 0;
            // 
            // lblChonMon
            // 
            this.lblChonMon.AutoSize = true;
            this.lblChonMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChonMon.ForeColor = System.Drawing.Color.Navy;
            this.lblChonMon.Location = new System.Drawing.Point(10, 12);
            this.lblChonMon.Name = "lblChonMon";
            this.lblChonMon.Size = new System.Drawing.Size(107, 19);
            this.lblChonMon.TabIndex = 0;
            this.lblChonMon.Text = "Chọn Môn Học:";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(125, 9);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(300, 25);
            this.cboMonHoc.TabIndex = 1;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // lblTongSoCau
            // 
            this.lblTongSoCau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongSoCau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblTongSoCau.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTongSoCau.Location = new System.Drawing.Point(700, 12);
            this.lblTongSoCau.Name = "lblTongSoCau";
            this.lblTongSoCau.Size = new System.Drawing.Size(250, 19);
            this.lblTongSoCau.TabIndex = 2;
            this.lblTongSoCau.Text = "Tổng số câu hỏi: 0";
            this.lblTongSoCau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 55);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpThongTin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(964, 596);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.cboDapAnDung);
            this.grpThongTin.Controls.Add(this.lblDapAnDung);
            this.grpThongTin.Controls.Add(this.txtDapAnD);
            this.grpThongTin.Controls.Add(this.lblDapAnD);
            this.grpThongTin.Controls.Add(this.txtDapAnC);
            this.grpThongTin.Controls.Add(this.lblDapAnC);
            this.grpThongTin.Controls.Add(this.txtDapAnB);
            this.grpThongTin.Controls.Add(this.lblDapAnB);
            this.grpThongTin.Controls.Add(this.txtDapAnA);
            this.grpThongTin.Controls.Add(this.lblDapAnA);
            this.grpThongTin.Controls.Add(this.txtNoiDung);
            this.grpThongTin.Controls.Add(this.lblNoiDung);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(964, 270);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "CHI TIẾT CÂU HỎI";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoiDung.ForeColor = System.Drawing.Color.Black;
            this.lblNoiDung.Location = new System.Drawing.Point(15, 28);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(60, 15);
            this.lblNoiDung.TabIndex = 0;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiDung.Location = new System.Drawing.Point(85, 25);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(860, 55);
            this.txtNoiDung.TabIndex = 1;
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.AutoSize = true;
            this.lblDapAnA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDapAnA.ForeColor = System.Drawing.Color.Black;
            this.lblDapAnA.Location = new System.Drawing.Point(15, 95);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(59, 15);
            this.lblDapAnA.TabIndex = 2;
            this.lblDapAnA.Text = "Đáp án A:";
            // 
            // txtDapAnA
            // 
            this.txtDapAnA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDapAnA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDapAnA.Location = new System.Drawing.Point(85, 92);
            this.txtDapAnA.Name = "txtDapAnA";
            this.txtDapAnA.Size = new System.Drawing.Size(860, 23);
            this.txtDapAnA.TabIndex = 3;
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.AutoSize = true;
            this.lblDapAnB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDapAnB.ForeColor = System.Drawing.Color.Black;
            this.lblDapAnB.Location = new System.Drawing.Point(15, 128);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(58, 15);
            this.lblDapAnB.TabIndex = 4;
            this.lblDapAnB.Text = "Đáp án B:";
            // 
            // txtDapAnB
            // 
            this.txtDapAnB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDapAnB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDapAnB.Location = new System.Drawing.Point(85, 125);
            this.txtDapAnB.Name = "txtDapAnB";
            this.txtDapAnB.Size = new System.Drawing.Size(860, 23);
            this.txtDapAnB.TabIndex = 5;
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.AutoSize = true;
            this.lblDapAnC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDapAnC.ForeColor = System.Drawing.Color.Black;
            this.lblDapAnC.Location = new System.Drawing.Point(15, 161);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(59, 15);
            this.lblDapAnC.TabIndex = 6;
            this.lblDapAnC.Text = "Đáp án C:";
            // 
            // txtDapAnC
            // 
            this.txtDapAnC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDapAnC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDapAnC.Location = new System.Drawing.Point(85, 158);
            this.txtDapAnC.Name = "txtDapAnC";
            this.txtDapAnC.Size = new System.Drawing.Size(860, 23);
            this.txtDapAnC.TabIndex = 7;
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.AutoSize = true;
            this.lblDapAnD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDapAnD.ForeColor = System.Drawing.Color.Black;
            this.lblDapAnD.Location = new System.Drawing.Point(15, 194);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(59, 15);
            this.lblDapAnD.TabIndex = 8;
            this.lblDapAnD.Text = "Đáp án D:";
            // 
            // txtDapAnD
            // 
            this.txtDapAnD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDapAnD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDapAnD.Location = new System.Drawing.Point(85, 191);
            this.txtDapAnD.Name = "txtDapAnD";
            this.txtDapAnD.Size = new System.Drawing.Size(860, 23);
            this.txtDapAnD.TabIndex = 9;
            // 
            // lblDapAnDung
            // 
            this.lblDapAnDung.AutoSize = true;
            this.lblDapAnDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDapAnDung.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDapAnDung.Location = new System.Drawing.Point(15, 230);
            this.lblDapAnDung.Name = "lblDapAnDung";
            this.lblDapAnDung.Size = new System.Drawing.Size(82, 15);
            this.lblDapAnDung.TabIndex = 10;
            this.lblDapAnDung.Text = "Đáp án đúng:";
            // 
            // cboDapAnDung
            // 
            this.cboDapAnDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDapAnDung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cboDapAnDung.FormattingEnabled = true;
            this.cboDapAnDung.Location = new System.Drawing.Point(105, 226);
            this.cboDapAnDung.Name = "cboDapAnDung";
            this.cboDapAnDung.Size = new System.Drawing.Size(80, 25);
            this.cboDapAnDung.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Navy;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(230, 224);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(330, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(430, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(530, 224);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvCauHoi);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.Navy;
            this.grpDanhSach.Location = new System.Drawing.Point(0, 0);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(964, 322);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH CÂU HỎI TRẮC NGHIỆM";
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.AllowUserToAddRows = false;
            this.dgvCauHoi.AllowUserToDeleteRows = false;
            this.dgvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCauHoi.BackgroundColor = System.Drawing.Color.White;
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCauHoi,
            this.colNoiDung,
            this.colDapAnA,
            this.colDapAnB,
            this.colDapAnC,
            this.colDapAnD,
            this.colDapAnDung});
            this.dgvCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCauHoi.Location = new System.Drawing.Point(3, 20);
            this.dgvCauHoi.MultiSelect = false;
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.ReadOnly = true;
            this.dgvCauHoi.RowHeadersVisible = false;
            this.dgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCauHoi.Size = new System.Drawing.Size(958, 299);
            this.dgvCauHoi.TabIndex = 0;
            this.dgvCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauHoi_CellClick);
            // 
            // colMaCauHoi
            // 
            this.colMaCauHoi.DataPropertyName = "MaCauHoi";
            this.colMaCauHoi.FillWeight = 15F;
            this.colMaCauHoi.HeaderText = "Mã";
            this.colMaCauHoi.Name = "colMaCauHoi";
            this.colMaCauHoi.ReadOnly = true;
            // 
            // colNoiDung
            // 
            this.colNoiDung.DataPropertyName = "NoiDung";
            this.colNoiDung.FillWeight = 85F;
            this.colNoiDung.HeaderText = "Nội Dung Câu Hỏi";
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.ReadOnly = true;
            // 
            // colDapAnA
            // 
            this.colDapAnA.DataPropertyName = "DapAnA";
            this.colDapAnA.FillWeight = 40F;
            this.colDapAnA.HeaderText = "Đáp Án A";
            this.colDapAnA.Name = "colDapAnA";
            this.colDapAnA.ReadOnly = true;
            // 
            // colDapAnB
            // 
            this.colDapAnB.DataPropertyName = "DapAnB";
            this.colDapAnB.FillWeight = 40F;
            this.colDapAnB.HeaderText = "Đáp Án B";
            this.colDapAnB.Name = "colDapAnB";
            this.colDapAnB.ReadOnly = true;
            // 
            // colDapAnC
            // 
            this.colDapAnC.DataPropertyName = "DapAnC";
            this.colDapAnC.FillWeight = 40F;
            this.colDapAnC.HeaderText = "Đáp Án C";
            this.colDapAnC.Name = "colDapAnC";
            this.colDapAnC.ReadOnly = true;
            // 
            // colDapAnD
            // 
            this.colDapAnD.DataPropertyName = "DapAnD";
            this.colDapAnD.FillWeight = 40F;
            this.colDapAnD.HeaderText = "Đáp Án D";
            this.colDapAnD.Name = "colDapAnD";
            this.colDapAnD.ReadOnly = true;
            // 
            // colDapAnDung
            // 
            this.colDapAnDung.DataPropertyName = "DapAnDung";
            this.colDapAnDung.FillWeight = 20F;
            this.colDapAnDung.HeaderText = "Đúng";
            this.colDapAnDung.Name = "colDapAnDung";
            this.colDapAnDung.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyCauHoi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Quản Lý Ngân Hàng Câu Hỏi";
            this.Load += new System.EventHandler(this.frmQuanLyCauHoi_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
