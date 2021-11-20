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
    public partial class frmVatTu : Form
    {
        int vitri;
        public frmVatTu()
        {
            InitializeComponent();
        }
        
        private void frmVatTu_Load(object sender, EventArgs e)
        {
            // Bỏ qua kiểm tra ràng buộc trên data set
            DS.EnforceConstraints = false;
            // Gán chuỗi kết nối vào connectionString của từng Adapter
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Giữ lại nhằm mục đích thực thi phục hồi
            vitri = bdsVT.Position;
            bdsVT.AddNew();
            pnInput.Enabled = true;

            // Sau khi thêm mới chỉ cho 2 nút lệnh hoạt động
            // Ghi và Undo
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =
                     btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUnDo.Enabled = true;
            gcVatTu.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.DS.Vattu);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            pnInput.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUnDo.Enabled = true;
            gcVatTu.Enabled = false;
        }
        private int checkExistsMaVT()
        {
            String query = "DECLARE	@return_value int "
                        + "EXEC	@return_value = [dbo].[SP_Kiem_Tra_Ma] "
                        + "@TYPE = MAVT," + "@ID = " + txtMa.Text.Trim()
                        +" SELECT	'Return Value' = @return_value";
            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            return myReader.GetInt32(0);
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được thiếu!", "", MessageBoxButtons.OK);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtSLT.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được thiếu!", "", MessageBoxButtons.OK);
                txtSLT.Focus();
                return;
            }
            if (checkExistsMaVT() == 1)
            {
                MessageBox.Show("Mã vật tư đã tồn tại, vui lòng nhập mã khác!", "", MessageBoxButtons.OK);
                txtMa.Focus();
                return;
            }
            try
            {
                bdsVT.EndEdit();
                bdsVT.ResetCurrentItem();
                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Update(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcVatTu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUnDo.Enabled = false;

            pnInput.Enabled = false;
        }

        private void txtSLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private int checkTTMaVT(String mavt)
        {
            String query = "DECLARE	@return_value int "
                    + "EXEC	@return_value = [dbo].[SP_Kiem_Tra_Trang_Thai_Vat_Tu] "
                    + "@MA = '" + mavt + "'"
                    + " SELECT	'Return Value' = @return_value";
            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            //if (myReader == null)
            //{
            //    return -1;
            //}
            myReader.Read();
            return myReader.GetInt32(0);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String mavt = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();
            int result = checkTTMaVT(mavt);
            //if (result == -1)
            //{
            //    MessageBox.Show("Có lỗi xảy ra khi xóa vật tư!\n", "", MessageBoxButtons.OK);
            //    return;
            //}
            if (result != 0)
            {
                MessageBox.Show("Vật tư này đang được sử dụng, không thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    //mavt = int.Parse(((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString());
                    bdsVT.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.DS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư, bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.DS.Vattu);
                    bdsVT.Position = bdsVT.Find("MAVT", mavt);
                    return;
                }
            }
            if (bdsVT.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUnDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Chưa làm
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_DanhSachVatTu rpt = new Xrpt_DanhSachVatTu();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
