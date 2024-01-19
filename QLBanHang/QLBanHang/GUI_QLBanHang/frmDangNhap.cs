using BUS_QLBanHang;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //btnDangNhap_Click
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim().Length ==0 || txtMatKhau.Text.Trim().Length ==0)
            {
                DialogHelper.Alert("Ban can nhap day du thong tin dang nhap");
                return;
            }    
            string matKhau = StringHelper.MD5Hash(txtMatKhau.Text);
            frmMain.nhanVien = BUS_NhanVien.DangNhap(txtEmail.Text, matKhau);

            if(frmMain.nhanVien != null)
            {
                DialogHelper.Alert("Dang nhap thanh cong");
                this.Close();
            }
            else 
            {
                DialogHelper.Alert("Sai thong tin dang nhap");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //btnQuenMatKhau
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                DialogHelper.Alert("Ban can nhap emaail nhan thong tin phuc hoi mat khau");
                txtEmail.Focus();
                return;
            }
            if (!EmailHelper.IsValidEmail(txtEmail.Text))
            {
                DialogHelper.Alert("Dia chi email khong hop le");
                return;
            }
            string email = txtEmail.Text.Trim();
            if (BUS_NhanVien.DaTonTaiEmail(email) == false)
            {
                DialogHelper.Alert("Dia chi email khong ton tai");
                txtEmail.Focus();
                return;
            }
            string matKhauMoi = StringHelper.GetRandomString(8);
            string subject = "Ban da su dung tinh nang quen mat khau";
            string msg = "Mat khau moi la: " + matKhauMoi;
            string result = EmailHelper.SendMail(txtEmail.Text.Trim(), subject, msg);
            if (result == "")
            {
                DialogHelper.Alert("Mot email phuc hoi mat khau da dc gui den ban");
                if (BUS_NhanVien.CreatePassword(txtEmail.Text.Trim(), StringHelper.MD5Hash(matKhauMoi)) > 0)
                {
                    DialogHelper.Alert("Mat khau moi cua ban da dc tao");
                }
            }
            else
                DialogHelper.Alert("Loi gui Email: " + result);
        }
    }
}
