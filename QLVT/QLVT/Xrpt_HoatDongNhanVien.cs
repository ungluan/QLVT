using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT
{
    public partial class Xrpt_HoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_HoatDongNhanVien(String manv,DateTime from, DateTime to  ,String loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = from;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = to;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = loai;
            this.sqlDataSource1.Fill();
        }

    }
}
