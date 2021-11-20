using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        //public void closeFormWhenLogin()
        //{
        //    foreach (Form f in this.MdiChildren)
        //        if (f.GetType() != typeof(frmDangNhap))
        //        {
        //            f.Close();
        //        }
        //}
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
            MANV.Text = "Mã NV : " + Program.username;
            HOTEN.Text = "Họ tên nhân viên : " + Program.mHoten;
            NHOM.Text = "Nhóm : " + Program.mGroup;
            // Phân quyền
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = true;
            // Tiếp tục if trên nhóm Program.mGroup để bật và tắt các lệnh trên
            // menu chính

            // Phân quyền:
            // 1.Công ty
            // Chỉ có thể xem được dữ liệu của phân mảnh tương ứng
            // Xem được báo cáo
            // Tạo login thuộc nhóm công ty
            // Hệ thống = Danh mục = Báo cáo = true
            // Chi tiết các component

            // 2. Login thuộc nhóm chi nhánh toàn quyền trên chi nhánh đó,
            // không thể login trên chi nhánh khác
            // => True all

            // 3, User cũng giống như CHINHANH nhưng bớt đi không cho tạo login
            if (Program.mGroup == "CONGTY")
            {
                btnRegis.Enabled = true;
            }else if(Program.mGroup == "CHINHANH")
            {
                btnRegis.Enabled = true;
            }
            else
            {
                btnRegis.Enabled = false;
            }
            btnLogout.Enabled = true;
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnRegis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                if (Program.mloginDN == "")
                {
                    MessageBox.Show("Vui lòng đăng nhập trước khi tạo tài khoản!", "", MessageBoxButtons.OK);
                    return;
                }
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLapPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_PhieuNvLapTrongNamTheoLoai));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_PhieuNvLapTrongNamTheoLoai f = new Frpt_PhieuNvLapTrongNamTheoLoai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBangKeVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_BangKeChiTietSoLuongTriGiaTheoLoai));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_BangKeChiTietSoLuongTriGiaTheoLoai f = new Frpt_BangKeChiTietSoLuongTriGiaTheoLoai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBC4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_DanhSachDDHChuaCoPN));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_DanhSachDDHChuaCoPN f = new Frpt_DanhSachDDHChuaCoPN();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHDNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_HoatDongCuaNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_HoatDongCuaNhanVien f = new Frpt_HoatDongCuaNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBC6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Frpt_HoatDongCuaNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Frpt_TongHopNhapXuat f = new Frpt_TongHopNhapXuat();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
