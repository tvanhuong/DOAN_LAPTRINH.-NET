namespace ThiTracNghiem.GUI
{
    partial class frmDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMoi;
        private System.Windows.Forms.TextBox txtXacNhanMoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhanMoi = new System.Windows.Forms.Label();
            this.txtXacNhanMoi = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Navy;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(434, 55);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐỔI MẬT KHẨU CÁ NHÂN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMatKhauCu.Location = new System.Drawing.Point(40, 75);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(82, 17);
            this.lblMatKhauCu.TabIndex = 1;
            this.lblMatKhauCu.Text = "Mật khẩu cũ:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMatKhauCu.Location = new System.Drawing.Point(170, 72);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(215, 24);
            this.txtMatKhauCu.TabIndex = 2;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMatKhauMoi.Location = new System.Drawing.Point(40, 118);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(91, 17);
            this.lblMatKhauMoi.TabIndex = 3;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(170, 115);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(215, 24);
            this.txtMatKhauMoi.TabIndex = 4;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhanMoi
            // 
            this.lblXacNhanMoi.AutoSize = true;
            this.lblXacNhanMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblXacNhanMoi.Location = new System.Drawing.Point(40, 161);
            this.lblXacNhanMoi.Name = "lblXacNhanMoi";
            this.lblXacNhanMoi.Size = new System.Drawing.Size(123, 17);
            this.lblXacNhanMoi.TabIndex = 5;
            this.lblXacNhanMoi.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMoi
            // 
            this.txtXacNhanMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtXacNhanMoi.Location = new System.Drawing.Point(170, 158);
            this.txtXacNhanMoi.Name = "txtXacNhanMoi";
            this.txtXacNhanMoi.Size = new System.Drawing.Size(215, 24);
            this.txtXacNhanMoi.TabIndex = 6;
            this.txtXacNhanMoi.UseSystemPasswordChar = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Navy;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(170, 205);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(105, 34);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnHuy.Location = new System.Drawing.Point(285, 205);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 34);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDoiMatKhau
            // 
            this.AcceptButton = this.btnXacNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(434, 265);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtXacNhanMoi);
            this.Controls.Add(this.lblXacNhanMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
