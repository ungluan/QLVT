using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class Frpt_HoatDongCuaNhanVien : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        public Frpt_HoatDongCuaNhanVien()
        {
            InitializeComponent();
        }

        private void Frpt_HoatDongCuaNhanVien_Load(object sender, EventArgs e)
        {
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.HOTENNV' table. You can move, or remove it, as needed.
            this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);

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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            try
            {
                String query = "SELECT NGAYSINH, LUONG, DIACHI FROM NhanVien "
                    + "WHERE MANV = " + txtMANV.Text;
                SqlDataReader myReader = Program.ExecSqlDataReader(query);
                myReader.Read();

              

                Xrpt_HoatDongNhanVien rpt = new Xrpt_HoatDongNhanVien(
                txtMANV.Text, deFrom.DateTime, deTo.DateTime, cmbLoai.Text.Substring(0, 1));

                rpt.lblMANV.Text = txtMANV.Text;
                rpt.lblTen.Text = cmbTenNV.Text;
                rpt.lblNgaySinh.Text = myReader.GetDateTime(0).ToString("dd/MM/yyyy");
                rpt.lblLuong.Text = myReader.GetDouble(1).ToString("N");
                rpt.lblDiaChi.Text = myReader.GetString(2);
                

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
        }
    }
}
