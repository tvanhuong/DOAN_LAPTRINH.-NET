namespace ThiTracNghiem.GUI
{
    partial class frmLichSuKetQua
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLocMon;
        private System.Windows.Forms.ComboBox cboLocMon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBaiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCauDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongSoCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemSo;

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
            System.Windows.Forms.DataGridViewCellStyle cellNgayThi = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellDiemSo = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboLocMon = new System.Windows.Forms.ComboBox();
            this.lblLocMon = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.colMaBaiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoCauDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongSoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblThongKe);
            this.pnlTop.Controls.Add(this.btnLamMoi);
            this.pnlTop.Controls.Add(this.cboLocMon);
            this.pnlTop.Controls.Add(this.lblLocMon);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(10, 10);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblThongKe.Location = new System.Drawing.Point(500, 15);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(450, 23);
            this.lblThongKe.TabIndex = 3;
            this.lblThongKe.Text = "Tổng số lượt thi: 0  |  Điểm cao nhất: 0  |  Điểm trung bình: 0";
            this.lblThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.Navy;
            this.btnLamMoi.Location = new System.Drawing.Point(395, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 28);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Tải Lại";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboLocMon
            // 
            this.cboLocMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocMon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLocMon.FormattingEnabled = true;
            this.cboLocMon.Location = new System.Drawing.Point(125, 14);
            this.cboLocMon.Name = "cboLocMon";
            this.cboLocMon.Size = new System.Drawing.Size(255, 25);
            this.cboLocMon.TabIndex = 1;
            this.cboLocMon.SelectedIndexChanged += new System.EventHandler(this.cboLocMon_SelectedIndexChanged);
            // 
            // lblLocMon
            // 
            this.lblLocMon.AutoSize = true;
            this.lblLocMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLocMon.ForeColor = System.Drawing.Color.Navy;
            this.lblLocMon.Location = new System.Drawing.Point(15, 17);
            this.lblLocMon.Name = "lblLocMon";
            this.lblLocMon.Size = new System.Drawing.Size(100, 17);
            this.lblLocMon.TabIndex = 0;
            this.lblLocMon.Text = "Lọc Theo Môn:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvLichSu);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.Navy;
            this.grpDanhSach.Location = new System.Drawing.Point(10, 65);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.grpDanhSach.Size = new System.Drawing.Size(964, 586);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH LỊCH SỬ KẾT QUẢ THI";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBaiThi,
            this.colHoTen,
            this.colTenMon,
            this.colNgayThi,
            this.colSoCauDung,
            this.colTongSoCau,
            this.colDiemSo});
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSu.Location = new System.Drawing.Point(5, 27);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(954, 554);
            this.dgvLichSu.TabIndex = 0;
            // 
            // colMaBaiThi
            // 
            this.colMaBaiThi.DataPropertyName = "MaBaiThi";
            this.colMaBaiThi.FillWeight = 15F;
            this.colMaBaiThi.HeaderText = "Mã";
            this.colMaBaiThi.Name = "colMaBaiThi";
            this.colMaBaiThi.ReadOnly = true;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 40F;
            this.colHoTen.HeaderText = "Họ Và Tên Thí Sinh";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.FillWeight = 40F;
            this.colTenMon.HeaderText = "Môn Thi";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colNgayThi
            // 
            this.colNgayThi.DataPropertyName = "NgayThi";
            cellNgayThi.Format = "dd/MM/yyyy HH:mm:ss";
            this.colNgayThi.DefaultCellStyle = cellNgayThi;
            this.colNgayThi.FillWeight = 30F;
            this.colNgayThi.HeaderText = "Thời Gian Nộp";
            this.colNgayThi.Name = "colNgayThi";
            this.colNgayThi.ReadOnly = true;
            // 
            // colSoCauDung
            // 
            this.colSoCauDung.DataPropertyName = "SoCauDung";
            this.colSoCauDung.FillWeight = 20F;
            this.colSoCauDung.HeaderText = "Số Đúng";
            this.colSoCauDung.Name = "colSoCauDung";
            this.colSoCauDung.ReadOnly = true;
            // 
            // colTongSoCau
            // 
            this.colTongSoCau.DataPropertyName = "TongSoCau";
            this.colTongSoCau.FillWeight = 20F;
            this.colTongSoCau.HeaderText = "Tổng Câu";
            this.colTongSoCau.Name = "colTongSoCau";
            this.colTongSoCau.ReadOnly = true;
            // 
            // colDiemSo
            // 
            this.colDiemSo.DataPropertyName = "DiemSo";
            cellDiemSo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            cellDiemSo.ForeColor = System.Drawing.Color.DarkRed;
            cellDiemSo.Format = "N2";
            this.colDiemSo.DefaultCellStyle = cellDiemSo;
            this.colDiemSo.FillWeight = 20F;
            this.colDiemSo.HeaderText = "Điểm";
            this.colDiemSo.Name = "colDiemSo";
            this.colDiemSo.ReadOnly = true;
            // 
            // frmLichSuKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLichSuKetQua";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Lịch Sử & Báo Cáo Kết Quả Thi";
            this.Load += new System.EventHandler(this.frmLichSuKetQua_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
