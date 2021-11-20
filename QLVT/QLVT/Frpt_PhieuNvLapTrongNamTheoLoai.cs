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
    public partial class Frpt_PhieuNvLapTrongNamTheoLoai : Form
    {
        int manv;
        public Frpt_PhieuNvLapTrongNamTheoLoai()
        {
            InitializeComponent();
        }

        private void Frpt_PhieuNvLapTrongNamTheoLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOTENNV' table. You can move, or remove it, as needed.
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

            for(int i=2000; i<=DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i);
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Viết code rẻ về phân mảnh mới
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                // Lấy tài khoản hỗ trợ kết nối để kết nối về chi nhánh mới
                // 2 biến này ta đã định nghĩa trên program, trên từng site ta cũng 
                // đã tạo 2 tk HTKN
                // Bây giờ ta dùng nó để rẻ về phân mảnh mới
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                // Nếu bằng thì ta kết nối lại
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới.\n", "", MessageBoxButtons.OK);
            }
            else
            {
                this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Xrpt_PhieuNvLapTrongNamTheoLoai rpt = new Xrpt_PhieuNvLapTrongNamTheoLoai(manv,
                    cmbLoai.Text.Substring(0, 1), int.Parse(cmbNam.Text));
            rpt.lblTieuDe.Text = "DANH SÁCH PHIẾU " + cmbLoai.Text.ToUpper() +
                " NHÂN VIÊN LẬP TRONG NĂM " + cmbNam.Text;
            rpt.lblHoTen.Text = cmbHoTen.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                manv = int.Parse(cmbHoTen.SelectedValue.ToString());
            }catch(Exception ex) { }
            // Represents text as sequence of UTF 16
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
