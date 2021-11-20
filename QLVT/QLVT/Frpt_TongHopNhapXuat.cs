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
    public partial class Frpt_TongHopNhapXuat : Form
    {
        public Frpt_TongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void Frpt_TongHopNhapXuat_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới.\n", "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (deFrom.Text.Length == 0)
            {
                MessageBox.Show("Ngày bắt đầu không được để trống", "", MessageBoxButtons.OK);
                deFrom.Focus();
                return;
            }
            if (deTo.Text.Length == 0)
            {
                MessageBox.Show("Ngày kết thúc không được để trống", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            if (deFrom.DateTime > deTo.DateTime)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            Xrpt_TongHopNhapXuat rpt = new Xrpt_TongHopNhapXuat(deFrom.DateTime, deTo.DateTime);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
