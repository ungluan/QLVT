using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class Frpt_DanhSachDDHChuaCoPN : Form
    {
        public Frpt_DanhSachDDHChuaCoPN()
        {
            InitializeComponent();
        }

        private void Frpt_DanhSachDDHChuaCoPN_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            if (Program.mGroup == "CHINHANH")
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_DanhSachDDHChuaCoPN rpt = new Xrpt_DanhSachDDHChuaCoPN();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
