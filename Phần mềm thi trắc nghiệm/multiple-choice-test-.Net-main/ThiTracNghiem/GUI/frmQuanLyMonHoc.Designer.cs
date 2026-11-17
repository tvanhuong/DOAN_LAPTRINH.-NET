namespace ThiTracNghiem.GUI
{
    partial class frmQuanLyMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblThoiGianThi;
        private System.Windows.Forms.NumericUpDown nudThoiGianThi;
        private System.Windows.Forms.Label lblPhut;
        private System.Windows.Forms.Label lblSoCauHoi;
        private System.Windows.Forms.NumericUpDown nudSoCauHoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCauHoi;
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudSoCauHoi = new System.Windows.Forms.NumericUpDown();
            this.lblSoCauHoi = new System.Windows.Forms.Label();
            this.lblPhut = new System.Windows.Forms.Label();
            this.nudThoiGianThi = new System.Windows.Forms.NumericUpDown();
            this.lblThoiGianThi = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGianThi)).BeginInit();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
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
            this.splitContainer1.Size = new System.Drawing.Size(784, 541);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.nudSoCauHoi);
            this.grpThongTin.Controls.Add(this.lblSoCauHoi);
            this.grpThongTin.Controls.Add(this.lblPhut);
            this.grpThongTin.Controls.Add(this.nudThoiGianThi);
            this.grpThongTin.Controls.Add(this.lblThoiGianThi);
            this.grpThongTin.Controls.Add(this.txtTenMon);
            this.grpThongTin.Controls.Add(this.lblTenMon);
            this.grpThongTin.Controls.Add(this.txtMaMon);
            this.grpThongTin.Controls.Add(this.lblMaMon);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.Navy;
            this.grpThongTin.Location = new System.Drawing.Point(0, 0);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(784, 160);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN MÔN HỌC";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(410, 115);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(310, 115);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(210, 115);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 32);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Navy;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(110, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nudSoCauHoi
            // 
            this.nudSoCauHoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudSoCauHoi.Location = new System.Drawing.Point(430, 73);
            this.nudSoCauHoi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSoCauHoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoCauHoi.Name = "nudSoCauHoi";
            this.nudSoCauHoi.Size = new System.Drawing.Size(120, 23);
            this.nudSoCauHoi.TabIndex = 8;
            this.nudSoCauHoi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblSoCauHoi
            // 
            this.lblSoCauHoi.AutoSize = true;
            this.lblSoCauHoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoCauHoi.ForeColor = System.Drawing.Color.Black;
            this.lblSoCauHoi.Location = new System.Drawing.Point(340, 75);
            this.lblSoCauHoi.Name = "lblSoCauHoi";
            this.lblSoCauHoi.Size = new System.Drawing.Size(65, 15);
            this.lblSoCauHoi.TabIndex = 7;
            this.lblSoCauHoi.Text = "Số câu hỏi:";
            // 
            // lblPhut
            // 
            this.lblPhut.AutoSize = true;
            this.lblPhut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhut.ForeColor = System.Drawing.Color.Black;
            this.lblPhut.Location = new System.Drawing.Point(235, 75);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(32, 15);
            this.lblPhut.TabIndex = 6;
            this.lblPhut.Text = "phút";
            // 
            // nudThoiGianThi
            // 
            this.nudThoiGianThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudThoiGianThi.Location = new System.Drawing.Point(110, 73);
            this.nudThoiGianThi.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudThoiGianThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThoiGianThi.Name = "nudThoiGianThi";
            this.nudThoiGianThi.Size = new System.Drawing.Size(120, 23);
            this.nudThoiGianThi.TabIndex = 5;
            this.nudThoiGianThi.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblThoiGianThi
            // 
            this.lblThoiGianThi.AutoSize = true;
            this.lblThoiGianThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThoiGianThi.ForeColor = System.Drawing.Color.Black;
            this.lblThoiGianThi.Location = new System.Drawing.Point(20, 75);
            this.lblThoiGianThi.Name = "lblThoiGianThi";
            this.lblThoiGianThi.Size = new System.Drawing.Size(76, 15);
            this.lblThoiGianThi.TabIndex = 4;
            this.lblThoiGianThi.Text = "Thời gian thi:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenMon.Location = new System.Drawing.Point(430, 32);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(325, 23);
            this.txtTenMon.TabIndex = 3;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenMon.ForeColor = System.Drawing.Color.Black;
            this.lblTenMon.Location = new System.Drawing.Point(340, 35);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(79, 15);
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Text = "Tên môn học:";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaMon.Location = new System.Drawing.Point(110, 32);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(180, 23);
            this.txtMaMon.TabIndex = 1;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaMon.ForeColor = System.Drawing.Color.Black;
            this.lblMaMon.Location = new System.Drawing.Point(20, 35);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(78, 15);
            this.lblMaMon.TabIndex = 0;
            this.lblMaMon.Text = "Mã môn học:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvMonHoc);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.Navy;
            this.grpDanhSach.Location = new System.Drawing.Point(0, 0);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(784, 377);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH MÔN HỌC";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.AllowUserToAddRows = false;
            this.dgvMonHoc.AllowUserToDeleteRows = false;
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colThoiGianThi,
            this.colSoCauHoi});
            this.dgvMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonHoc.Location = new System.Drawing.Point(3, 20);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowHeadersVisible = false;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(778, 354);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.FillWeight = 30F;
            this.colMaMon.HeaderText = "Mã Môn";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.FillWeight = 70F;
            this.colTenMon.HeaderText = "Tên Môn Học";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colThoiGianThi
            // 
            this.colThoiGianThi.DataPropertyName = "ThoiGianThi";
            this.colThoiGianThi.FillWeight = 30F;
            this.colThoiGianThi.HeaderText = "TG Thi (Phút)";
            this.colThoiGianThi.Name = "colThoiGianThi";
            this.colThoiGianThi.ReadOnly = true;
            // 
            // colSoCauHoi
            // 
            this.colSoCauHoi.DataPropertyName = "SoCauHoi";
            this.colSoCauHoi.FillWeight = 30F;
            this.colSoCauHoi.HeaderText = "Số Câu Hỏi";
            this.colSoCauHoi.Name = "colSoCauHoi";
            this.colSoCauHoi.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQuanLyMonHoc";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.frmQuanLyMonHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThoiGianThi)).EndInit();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
