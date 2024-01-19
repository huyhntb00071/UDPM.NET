namespace GUI_QLBanHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnuChao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSoNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKeSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieuPhanMem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(328, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DỰ ÁN MẪU C# - QUẢN LÝ BÁN HÀNG ";
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuThongke,
            this.mnuHuongDan,
            this.mnuChao});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1055, 28);
            this.mnsMain.TabIndex = 4;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnuChao
            // 
            this.mnuChao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuChao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTin,
            this.mnuDangXuat2});
            this.mnuChao.Name = "mnuChao";
            this.mnuChao.Size = new System.Drawing.Size(61, 24);
            this.mnuChao.Text = "Chào ";
            // 
            // mnuThongTin
            // 
            this.mnuThongTin.Name = "mnuThongTin";
            this.mnuThongTin.Size = new System.Drawing.Size(224, 26);
            this.mnuThongTin.Text = "Thông tin ";
            this.mnuThongTin.Click += new System.EventHandler(this.thongTinToolStripMenuItem_Click);
            // 
            // mnuDangXuat2
            // 
            this.mnuDangXuat2.Name = "mnuDangXuat2";
            this.mnuDangXuat2.Size = new System.Drawing.Size(224, 26);
            this.mnuDangXuat2.Text = "Đăng xuất ";
            this.mnuDangXuat2.Click += new System.EventHandler(this.mnuDangXuat2_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuHoSoNhanVien,
            this.mnuThoat});
            this.mnuHeThong.Image = global::GUI_QLBanHang.Properties.Resources.Gear;
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(109, 24);
            this.mnuHeThong.Text = "Hệ thống ";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Checked = true;
            this.mnuDangNhap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangNhap.Image")));
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDangNhap.Size = new System.Drawing.Size(255, 26);
            this.mnuDangNhap.Text = "Đăng nhập ";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mnuDangXuat.Image")));
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuDangXuat.Size = new System.Drawing.Size(255, 26);
            this.mnuDangXuat.Text = "Đăng xuất ";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuHoSoNhanVien
            // 
            this.mnuHoSoNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuHoSoNhanVien.Image")));
            this.mnuHoSoNhanVien.Name = "mnuHoSoNhanVien";
            this.mnuHoSoNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuHoSoNhanVien.Size = new System.Drawing.Size(255, 26);
            this.mnuHoSoNhanVien.Text = "Hồ sơ nhân viên ";
            this.mnuHoSoNhanVien.Click += new System.EventHandler(this.mnuHoSoNhanVien_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(255, 26);
            this.mnuThoat.Text = "Thoát ";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuNhanVien,
            this.mnuKhachHang});
            this.mnuDanhMuc.Image = global::GUI_QLBanHang.Properties.Resources.Book;
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(114, 24);
            this.mnuDanhMuc.Text = "Danh mục ";
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Image = ((System.Drawing.Image)(resources.GetObject("mnuSanPham.Image")));
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnuSanPham.Size = new System.Drawing.Size(224, 26);
            this.mnuSanPham.Text = "Sản phẩm ";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhanVien.Image")));
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanVien.Text = "Nhân viên ";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuKhachHang.Image")));
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.mnuKhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachHang.Text = "Khách hàng ";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuThongke
            // 
            this.mnuThongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKeSanPham});
            this.mnuThongke.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongke.Image")));
            this.mnuThongke.Name = "mnuThongke";
            this.mnuThongke.Size = new System.Drawing.Size(108, 24);
            this.mnuThongke.Text = "Thống kê ";
            // 
            // mnuThongKeSanPham
            // 
            this.mnuThongKeSanPham.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKeSanPham.Image")));
            this.mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            this.mnuThongKeSanPham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mnuThongKeSanPham.Size = new System.Drawing.Size(271, 26);
            this.mnuThongKeSanPham.Text = "Thống kê sản phẩm ";
            this.mnuThongKeSanPham.Click += new System.EventHandler(this.mnuThongKeSanPham_Click);
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDanSuDung,
            this.mnuGioiThieuPhanMem});
            this.mnuHuongDan.Image = global::GUI_QLBanHang.Properties.Resources.Globe;
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(122, 24);
            this.mnuHuongDan.Text = "Hướng dẫn ";
            this.mnuHuongDan.Click += new System.EventHandler(this.mnuHuongDan_Click);
            // 
            // mnuHuongDanSuDung
            // 
            this.mnuHuongDanSuDung.Image = ((System.Drawing.Image)(resources.GetObject("mnuHuongDanSuDung.Image")));
            this.mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            this.mnuHuongDanSuDung.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.mnuHuongDanSuDung.Size = new System.Drawing.Size(283, 26);
            this.mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng ";
            this.mnuHuongDanSuDung.Click += new System.EventHandler(this.mnuHuongDanSuDung_Click);
            // 
            // mnuGioiThieuPhanMem
            // 
            this.mnuGioiThieuPhanMem.Image = ((System.Drawing.Image)(resources.GetObject("mnuGioiThieuPhanMem.Image")));
            this.mnuGioiThieuPhanMem.Name = "mnuGioiThieuPhanMem";
            this.mnuGioiThieuPhanMem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.mnuGioiThieuPhanMem.Size = new System.Drawing.Size(283, 26);
            this.mnuGioiThieuPhanMem.Text = "Giới thiệu phần mềm ";
            this.mnuGioiThieuPhanMem.Click += new System.EventHandler(this.mnuGioiThieuPhanMem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QLBanHang.Properties.Resources.fpoly;
            this.pictureBox1.Location = new System.Drawing.Point(228, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1055, 572);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "FrmMan-QLBH";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSoNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuThongke;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieuPhanMem;
        private System.Windows.Forms.ToolStripMenuItem mnuChao;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTin;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat2;
    }
}

