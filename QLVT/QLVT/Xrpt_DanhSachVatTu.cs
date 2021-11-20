using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_DanhSachVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachVatTu()
        {
            InitializeComponent();
            // Lúc nào rảnh test TH không có lệnh Fill thì đang ở Trang Vật tư,
            // Ở SQL thêm 1 vật tư, Không reload mà Click Preview thì liệu có 
            // vật tư mới thêm không
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
