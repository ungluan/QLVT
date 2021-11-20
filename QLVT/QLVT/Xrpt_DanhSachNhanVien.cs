using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_DanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource2.Fill();
        }

    }
}
