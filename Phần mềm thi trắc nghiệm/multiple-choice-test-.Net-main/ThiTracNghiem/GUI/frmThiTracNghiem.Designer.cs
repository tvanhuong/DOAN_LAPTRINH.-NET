namespace ThiTracNghiem.GUI
{
    partial class frmThiTracNghiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblChonMon;
        private System.Windows.Forms.ComboBox cboMonThi;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Panel pnlNoiDungThi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpCauHoi;
        private System.Windows.Forms.Label lblSoThuTuCau;
        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private System.Windows.Forms.Panel pnlDapAn;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.Label lblGiaiThichDapAn;
        private System.Windows.Forms.Panel pnlDieuHuong;
        private System.Windows.Forms.Button btnCauTruoc;
        private System.Windows.Forms.Button btnCauSau;
        private System.Windows.Forms.GroupBox grpDanhSachCau;
        private System.Windows.Forms.FlowLayoutPanel pnlDanhSachCau;
        private System.Windows.Forms.Timer timerThi;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.lblDongHo = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.cboMonThi = new System.Windows.Forms.ComboBox();
            this.lblChonMon = new System.Windows.Forms.Label();
            this.pnlNoiDungThi = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpCauHoi = new System.Windows.Forms.GroupBox();
            this.lblGiaiThichDapAn = new System.Windows.Forms.Label();
            this.pnlDieuHuong = new System.Windows.Forms.Panel();
            this.btnCauSau = new System.Windows.Forms.Button();
            this.btnCauTruoc = new System.Windows.Forms.Button();
            this.pnlDapAn = new System.Windows.Forms.Panel();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.lblSoThuTuCau = new System.Windows.Forms.Label();
            this.grpDanhSachCau = new System.Windows.Forms.GroupBox();
            this.pnlDanhSachCau = new System.Windows.Forms.FlowLayoutPanel();
            this.timerThi = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlNoiDungThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpCauHoi.SuspendLayout();
            this.pnlDieuHuong.SuspendLayout();
            this.pnlDapAn.SuspendLayout();
            this.grpDanhSachCau.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnNopBai);
            this.pnlHeader.Controls.Add(this.lblDongHo);
            this.pnlHeader.Controls.Add(this.btnBatDau);
            this.pnlHeader.Controls.Add(this.cboMonThi);
            this.pnlHeader.Controls.Add(this.lblChonMon);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(992, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnNopBai
            // 
            this.btnNopBai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNopBai.BackColor = System.Drawing.Color.Crimson;
            this.btnNopBai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNopBai.Enabled = false;
            this.btnNopBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNopBai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNopBai.ForeColor = System.Drawing.Color.White;
            this.btnNopBai.Location = new System.Drawing.Point(863, 8);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(115, 36);
            this.btnNopBai.TabIndex = 4;
            this.btnNopBai.Text = "NỘP BÀI";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // lblDongHo
            // 
            this.lblDongHo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDongHo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDongHo.ForeColor = System.Drawing.Color.Navy;
            this.lblDongHo.Location = new System.Drawing.Point(733, 10);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(120, 32);
            this.lblDongHo.TabIndex = 3;
            this.lblDongHo.Text = "00:00";
            this.lblDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.Navy;
            this.btnBatDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatDau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBatDau.ForeColor = System.Drawing.Color.White;
            this.btnBatDau.Location = new System.Drawing.Point(420, 10);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(140, 32);
            this.btnBatDau.TabIndex = 2;
            this.btnBatDau.Text = "BẮT ĐẦU THI";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // cboMonThi
            // 
            this.cboMonThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonThi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMonThi.FormattingEnabled = true;
            this.cboMonThi.Location = new System.Drawing.Point(120, 14);
            this.cboMonThi.Name = "cboMonThi";
            this.cboMonThi.Size = new System.Drawing.Size(280, 25);
            this.cboMonThi.TabIndex = 1;
            // 
            // lblChonMon
            // 
            this.lblChonMon.AutoSize = true;
            this.lblChonMon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChonMon.ForeColor = System.Drawing.Color.Navy;
            this.lblChonMon.Location = new System.Drawing.Point(15, 17);
            this.lblChonMon.Name = "lblChonMon";
            this.lblChonMon.Size = new System.Drawing.Size(100, 17);
            this.lblChonMon.TabIndex = 0;
            this.lblChonMon.Text = "Chọn Môn Thi:";
            // 
            // pnlNoiDungThi
            // 
            this.pnlNoiDungThi.Controls.Add(this.splitContainer1);
            this.pnlNoiDungThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDungThi.Location = new System.Drawing.Point(10, 65);
            this.pnlNoiDungThi.Name = "pnlNoiDungThi";
            this.pnlNoiDungThi.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlNoiDungThi.Size = new System.Drawing.Size(992, 586);
            this.pnlNoiDungThi.TabIndex = 1;
            this.pnlNoiDungThi.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpCauHoi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpDanhSachCau);
            this.splitContainer1.Size = new System.Drawing.Size(992, 576);
            this.splitContainer1.SplitterDistance = 748;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpCauHoi
            // 
            this.grpCauHoi.BackColor = System.Drawing.Color.White;
            this.grpCauHoi.Controls.Add(this.lblGiaiThichDapAn);
            this.grpCauHoi.Controls.Add(this.pnlDieuHuong);
            this.grpCauHoi.Controls.Add(this.pnlDapAn);
            this.grpCauHoi.Controls.Add(this.txtNoiDungCauHoi);
            this.grpCauHoi.Controls.Add(this.lblSoThuTuCau);
            this.grpCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCauHoi.ForeColor = System.Drawing.Color.Navy;
            this.grpCauHoi.Location = new System.Drawing.Point(0, 0);
            this.grpCauHoi.Name = "grpCauHoi";
            this.grpCauHoi.Padding = new System.Windows.Forms.Padding(15);
            this.grpCauHoi.Size = new System.Drawing.Size(748, 576);
            this.grpCauHoi.TabIndex = 0;
            this.grpCauHoi.TabStop = false;
            this.grpCauHoi.Text = "NỘI DUNG BÀI THI";
            // 
            // lblGiaiThichDapAn
            // 
            this.lblGiaiThichDapAn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiaiThichDapAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiaiThichDapAn.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGiaiThichDapAn.Location = new System.Drawing.Point(18, 470);
            this.lblGiaiThichDapAn.Name = "lblGiaiThichDapAn";
            this.lblGiaiThichDapAn.Size = new System.Drawing.Size(712, 30);
            this.lblGiaiThichDapAn.TabIndex = 4;
            this.lblGiaiThichDapAn.Text = "Đáp án đúng:";
            this.lblGiaiThichDapAn.Visible = false;
            // 
            // pnlDieuHuong
            // 
            this.pnlDieuHuong.Controls.Add(this.btnCauSau);
            this.pnlDieuHuong.Controls.Add(this.btnCauTruoc);
            this.pnlDieuHuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDieuHuong.Location = new System.Drawing.Point(15, 511);
            this.pnlDieuHuong.Name = "pnlDieuHuong";
            this.pnlDieuHuong.Size = new System.Drawing.Size(718, 50);
            this.pnlDieuHuong.TabIndex = 3;
            // 
            // btnCauSau
            // 
            this.btnCauSau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauSau.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCauSau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauSau.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCauSau.ForeColor = System.Drawing.Color.Navy;
            this.btnCauSau.Location = new System.Drawing.Point(568, 5);
            this.btnCauSau.Name = "btnCauSau";
            this.btnCauSau.Size = new System.Drawing.Size(145, 40);
            this.btnCauSau.TabIndex = 1;
            this.btnCauSau.Text = "Câu Tiếp Theo ⏩";
            this.btnCauSau.UseVisualStyleBackColor = false;
            this.btnCauSau.Click += new System.EventHandler(this.btnCauSau_Click);
            // 
            // btnCauTruoc
            // 
            this.btnCauTruoc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCauTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauTruoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCauTruoc.ForeColor = System.Drawing.Color.Navy;
            this.btnCauTruoc.Location = new System.Drawing.Point(5, 5);
            this.btnCauTruoc.Name = "btnCauTruoc";
            this.btnCauTruoc.Size = new System.Drawing.Size(145, 40);
            this.btnCauTruoc.TabIndex = 0;
            this.btnCauTruoc.Text = "⏪ Câu Trước";
            this.btnCauTruoc.UseVisualStyleBackColor = false;
            this.btnCauTruoc.Click += new System.EventHandler(this.btnCauTruoc_Click);
            // 
            // pnlDapAn
            // 
            this.pnlDapAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDapAn.AutoScroll = true;
            this.pnlDapAn.Controls.Add(this.rdoD);
            this.pnlDapAn.Controls.Add(this.rdoC);
            this.pnlDapAn.Controls.Add(this.rdoB);
            this.pnlDapAn.Controls.Add(this.rdoA);
            this.pnlDapAn.Location = new System.Drawing.Point(18, 175);
            this.pnlDapAn.Name = "pnlDapAn";
            this.pnlDapAn.Size = new System.Drawing.Size(712, 285);
            this.pnlDapAn.TabIndex = 2;
            // 
            // rdoD
            // 
            this.rdoD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoD.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rdoD.ForeColor = System.Drawing.Color.Black;
            this.rdoD.Location = new System.Drawing.Point(15, 205);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(683, 50);
            this.rdoD.TabIndex = 3;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "D. Đáp án D";
            this.rdoD.UseVisualStyleBackColor = true;
            this.rdoD.CheckedChanged += new System.EventHandler(this.rdoDapAn_CheckedChanged);
            // 
            // rdoC
            // 
            this.rdoC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoC.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rdoC.ForeColor = System.Drawing.Color.Black;
            this.rdoC.Location = new System.Drawing.Point(15, 140);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(683, 50);
            this.rdoC.TabIndex = 2;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "C. Đáp án C";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.CheckedChanged += new System.EventHandler(this.rdoDapAn_CheckedChanged);
            // 
            // rdoB
            // 
            this.rdoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoB.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rdoB.ForeColor = System.Drawing.Color.Black;
            this.rdoB.Location = new System.Drawing.Point(15, 75);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(683, 50);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B. Đáp án B";
            this.rdoB.UseVisualStyleBackColor = true;
            this.rdoB.CheckedChanged += new System.EventHandler(this.rdoDapAn_CheckedChanged);
            // 
            // rdoA
            // 
            this.rdoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoA.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.rdoA.ForeColor = System.Drawing.Color.Black;
            this.rdoA.Location = new System.Drawing.Point(15, 10);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(683, 50);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A. Đáp án A";
            this.rdoA.UseVisualStyleBackColor = true;
            this.rdoA.CheckedChanged += new System.EventHandler(this.rdoDapAn_CheckedChanged);
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDungCauHoi.BackColor = System.Drawing.Color.White;
            this.txtNoiDungCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDungCauHoi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNoiDungCauHoi.ForeColor = System.Drawing.Color.Black;
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(18, 55);
            this.txtNoiDungCauHoi.Multiline = true;
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.ReadOnly = true;
            this.txtNoiDungCauHoi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(712, 105);
            this.txtNoiDungCauHoi.TabIndex = 1;
            // 
            // lblSoThuTuCau
            // 
            this.lblSoThuTuCau.AutoSize = true;
            this.lblSoThuTuCau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoThuTuCau.ForeColor = System.Drawing.Color.Navy;
            this.lblSoThuTuCau.Location = new System.Drawing.Point(15, 28);
            this.lblSoThuTuCau.Name = "lblSoThuTuCau";
            this.lblSoThuTuCau.Size = new System.Drawing.Size(121, 20);
            this.lblSoThuTuCau.TabIndex = 0;
            this.lblSoThuTuCau.Text = "CÂU HỎI 1 / 10:";
            // 
            // grpDanhSachCau
            // 
            this.grpDanhSachCau.BackColor = System.Drawing.Color.White;
            this.grpDanhSachCau.Controls.Add(this.pnlDanhSachCau);
            this.grpDanhSachCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSachCau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSachCau.ForeColor = System.Drawing.Color.Navy;
            this.grpDanhSachCau.Location = new System.Drawing.Point(0, 0);
            this.grpDanhSachCau.Name = "grpDanhSachCau";
            this.grpDanhSachCau.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSachCau.Size = new System.Drawing.Size(240, 576);
            this.grpDanhSachCau.TabIndex = 0;
            this.grpDanhSachCau.TabStop = false;
            this.grpDanhSachCau.Text = "DANH SÁCH CÂU";
            // 
            // pnlDanhSachCau
            // 
            this.pnlDanhSachCau.AutoScroll = true;
            this.pnlDanhSachCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDanhSachCau.Location = new System.Drawing.Point(10, 28);
            this.pnlDanhSachCau.Name = "pnlDanhSachCau";
            this.pnlDanhSachCau.Size = new System.Drawing.Size(220, 538);
            this.pnlDanhSachCau.TabIndex = 0;
            // 
            // timerThi
            // 
            this.timerThi.Interval = 1000;
            this.timerThi.Tick += new System.EventHandler(this.timerThi_Tick);
            // 
            // frmThiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1012, 661);
            this.Controls.Add(this.pnlNoiDungThi);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThiTracNghiem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Làm Bài Thi Trắc Nghiệm";
            this.Load += new System.EventHandler(this.frmThiTracNghiem_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNoiDungThi.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpCauHoi.ResumeLayout(false);
            this.grpCauHoi.PerformLayout();
            this.pnlDieuHuong.ResumeLayout(false);
            this.pnlDapAn.ResumeLayout(false);
            this.grpDanhSachCau.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
