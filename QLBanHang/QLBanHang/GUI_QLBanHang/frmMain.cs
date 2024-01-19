using DTO_QLBanHang;
using GUI_QLBanHang.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class frmMain : Form
    {
        public static NhanVien nhanVien;
        public frmMain()
        {
            InitializeComponent();
        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            resetMenu();

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetMenu()
        {
            if (nhanVien == null)
            {
                //He thong
                mnuDangXuat.Enabled = false;
                mnuDangNhap.Enabled = true;
                mnuHoSoNhanVien.Enabled = false;
                //Danh Muc
                mnuDanhMuc.Visible = false;
                mnuSanPham.Enabled = false;
                mnuNhanVien.Enabled = false;
                mnuKhachHang.Enabled = false;
                //Thong ke
                mnuThongke.Visible = false;
                mnuThongKeSanPham.Visible = false;
                mnuThongKeSanPham.Enabled = false;
                //Chao
                mnuChao.Visible = false;
                mnuThongTin.Enabled = false;
                mnuDangXuat2.Enabled = false;

            }
            else
            {

                mnuDangXuat.Enabled = true;
                mnuDangNhap.Enabled = false;
                mnuHoSoNhanVien.Enabled = true;

                mnuDanhMuc.Visible = true;
                mnuSanPham.Enabled = true;
                mnuNhanVien.Enabled = nhanVien.VaiTro == 1 ? true : false;
                mnuKhachHang.Enabled = true;

                mnuThongke.Visible = true;
                mnuThongKeSanPham.Enabled = nhanVien.VaiTro > 1 ? true : false;

                mnuChao.Visible = true;
                mnuThongTin.Enabled = true;
                mnuDangXuat2.Enabled = true;
                mnuChao.Text = "Hi " + nhanVien.Email;
            }
        }

        private void OpenOrActiveForm(Form frm)
        {
            Form frm1 = this.MdiChildren.FirstOrDefault(f => f.Name == frm.Name);
            if (frm1 != null)
            {
                frm1.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }    
        }

        private void DangNhap()
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            resetMenu();
        }

        private void DangXuat()
        {
            nhanVien = null;
            foreach (var f in this.MdiChildren) 
            {
                f.Close();
            }
            resetMenu();
        }

        private void thongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void mnuHoSoNhanVien_Click(object sender, EventArgs e)
        {
            frmHoSoNhanVien frm = new frmHoSoNhanVien();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                resetMenu();
                DialogHelper.Alert("Cap nhat thanh cong. Ban can dang nhap lai");
                DangNhap();
;            }    
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmDanhSachHang frm = new frmDanhSachHang();
            OpenOrActiveForm(frm);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            QLNV frm = new QLNV();
            OpenOrActiveForm(frm);
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            QLKH frm = new QLKH();
            OpenOrActiveForm(frm);
        }

        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            var frm = new ThongKe();
            OpenOrActiveForm(frm);
        }

        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            /*Rỗng.../*/
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"";
                System.Diagnostics.Process.Start(filePath);
            }
            catch(Exception ex)
            {
                DialogHelper.Error("Lỗi: "+ex.Message);
            }
        }

        private void mnuGioiThieuPhanMem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            OpenOrActiveForm(frm);
        }

        private void mnuDangXuat2_Click(object sender, EventArgs e)
        {
            DangXuat();
        }
    }
}
