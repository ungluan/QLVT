
namespace QLVT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegis = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangKeVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnBC4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHDNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBC5 = new DevExpress.XtraBars.BarButtonItem();
            this.rib_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xx = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_NghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ss = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBC6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLogin,
            this.btnRegis,
            this.btnLogout,
            this.btnNhanVien,
            this.btnBangKeVatTu,
            this.btnBC4,
            this.btnLapPhieu,
            this.btnVatTu,
            this.btnKho,
            this.barButtonItem1,
            this.btnHDNV,
            this.btnBC5,
            this.btnBC6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(14);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rib_HeThong,
            this.rib_DanhMuc,
            this.rib_NghiepVu,
            this.rib_BaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 231);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnRegis
            // 
            this.btnRegis.Caption = "Tạo tài khoản";
            this.btnRegis.Enabled = false;
            this.btnRegis.Id = 2;
            this.btnRegis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegis.ImageOptions.Image")));
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnRegis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegis_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Enabled = false;
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Name = "btnLogout";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.Image")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnBangKeVatTu
            // 
            this.btnBangKeVatTu.Caption = "Bảng kê chi tiết vật tư";
            this.btnBangKeVatTu.Id = 5;
            this.btnBangKeVatTu.Name = "btnBangKeVatTu";
            this.btnBangKeVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangKeVatTu_ItemClick);
            // 
            // btnBC4
            // 
            this.btnBC4.Caption = "Danh sách đơn đặt hàng chưa có phiếu nhập";
            this.btnBC4.Id = 6;
            this.btnBC4.Name = "btnBC4";
            this.btnBC4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBC4_ItemClick);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Caption = "Lập phiếu nhập xuất";
            this.btnLapPhieu.Id = 7;
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapPhieu_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật tư";
            this.btnVatTu.Id = 8;
            this.btnVatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.Image")));
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 9;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.Name = "btnKho";
            this.btnKho.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnHDNV
            // 
            this.btnHDNV.Caption = "Hoạt động nhân viên";
            this.btnHDNV.Id = 11;
            this.btnHDNV.Name = "btnHDNV";
            this.btnHDNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHDNV_ItemClick);
            // 
            // btnBC5
            // 
            this.btnBC5.Caption = "barButtonItem3";
            this.btnBC5.Id = 12;
            this.btnBC5.Name = "btnBC5";
            // 
            // rib_HeThong
            // 
            this.rib_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rib_HeThong.Name = "rib_HeThong";
            this.rib_HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRegis);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rib_DanhMuc
            // 
            this.rib_DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.xx});
            this.rib_DanhMuc.Name = "rib_DanhMuc";
            this.rib_DanhMuc.Text = "Danh mục";
            this.rib_DanhMuc.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup6.ImageOptions.Image")));
            this.ribbonPageGroup6.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // xx
            // 
            this.xx.ItemLinks.Add(this.btnKho);
            this.xx.Name = "xx";
            // 
            // rib_NghiepVu
            // 
            this.rib_NghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rib_NghiepVu.Name = "rib_NghiepVu";
            this.rib_NghiepVu.Text = "Nghiệp vụ";
            this.rib_NghiepVu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLapPhieu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rib_BaoCao
            // 
            this.rib_BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ss,
            this.ribbonPageGroup7,
            this.ribbonPageGroup5});
            this.rib_BaoCao.Name = "rib_BaoCao";
            this.rib_BaoCao.Text = "Báo cáo";
            this.rib_BaoCao.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangKeVatTu);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ss
            // 
            this.ss.ItemLinks.Add(this.btnBC4);
            this.ss.Name = "ss";
            this.ss.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnHDNV);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1137, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(64, 25);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(69, 25);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(68, 25);
            this.NHOM.Text = "NHOM";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnBC6);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // btnBC6
            // 
            this.btnBC6.Caption = "Tổng hợp nhập xuất";
            this.btnBC6.Id = 13;
            this.btnBC6.Name = "btnBC6";
            this.btnBC6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBC6_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 526);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnRegis;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_NghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_BaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnBangKeVatTu;
        private DevExpress.XtraBars.BarButtonItem btnBC4;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ss;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup xx;
        private DevExpress.XtraBars.BarButtonItem btnHDNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnBC5;
        private DevExpress.XtraBars.BarButtonItem btnBC6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}