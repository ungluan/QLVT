using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_BangKeChiTietSoLuongTheoLoai : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BangKeChiTietSoLuongTheoLoai()
        {
            //InitializeComponent();
        }
        public Xrpt_BangKeChiTietSoLuongTheoLoai(DateTime dateFrom, DateTime dateTo, String nhom, String loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = dateFrom;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateTo;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
            this.sqlDataSource1.Fill();
        }
    }
}
