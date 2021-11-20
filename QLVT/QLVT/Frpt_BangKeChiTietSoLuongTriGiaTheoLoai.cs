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
    public partial class Frpt_BangKeChiTietSoLuongTriGiaTheoLoai : Form
    {
        public Frpt_BangKeChiTietSoLuongTriGiaTheoLoai()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cmbLoai.Text.Equals(""))
            {
                MessageBox.Show("Loại không được để trống!", "", MessageBoxButtons.OK);
                cmbLoai.Focus();
                return;
            }
            if (deFrom.Text.Length == 0)
            {
                MessageBox.Show("Ngày bắt đầu không được để trống","",MessageBoxButtons.OK);
                deFrom.Focus();
                return;
            }
            if (deTo.Text.Length == 0)
            {
                MessageBox.Show("Ngày kết thúc không được để trống", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            if (deFrom.DateTime>deTo.DateTime)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "", MessageBoxButtons.OK);
                deTo.Focus();
                return;
            }
            
            Xrpt_BangKeChiTietSoLuongTheoLoai rpt = new Xrpt_BangKeChiTietSoLuongTheoLoai(
                deFrom.DateTime, deTo.DateTime, Program.mGroup, cmbLoai.Text.Substring(0,1));
            rpt.lblTieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ HÀNG " + 
                cmbLoai.Text.ToUpper() + " TỪ NGÀY " +deFrom.Text +" ĐẾN NGÀY "+deTo.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void Frpt_BangKeChiTietSoLuongTriGiaTheoLoai_Load(object sender, EventArgs e)
        {

        }

    }
}
