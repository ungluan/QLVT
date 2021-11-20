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
    public partial class frmKho : Form
    {
        String macn="";
        int vitri = 0;
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHO.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            macn = ((DataRowView)bdsKHO[0])["MACN"].ToString();
            // Sao chép bds_dspm đã load ở form đăng nhập
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =
                    btnUnDo.Enabled = btnGhi.Enabled = false;
                txtMaCN.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                txtMaCN.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =
                btnUnDo.Enabled = btnGhi.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsKHO.Position;
            bdsKHO.AddNew();
            txtMaCN.Text = macn;

            gcKho.Enabled = false;
            pnInput.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =
                     btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUnDo.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKHO.Position;
            pnInput.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUnDo.Enabled = true;
            gcKho.Enabled = false;
        }

        private void btnUnDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Chưa
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.DS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private int checkExistsMaKho()
        {
            String query = "DECLARE	@return_value int " +
                            "EXEC @return_value = [dbo].[SP_Kiem_Tra_Ma] " +
                            "@Type = N'MAKHO'," +
                            "@ID =" + txtMa.Text.Trim() +
                            " SELECT  'Return Value' = @return_value";
            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            return myReader.GetInt32(0);
        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Mã Kho không được thiếu!", "", MessageBoxButtons.OK);
                txtMa.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (checkExistsMaKho()!= 0)
            {
                MessageBox.Show("Mã kho đã tồn tại");
                txtMa.Focus();
                return;
            }
            try
            {
                bdsKHO.EndEdit();
                bdsKHO.ResetCurrentItem();
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Update(this.DS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcKho.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUnDo.Enabled = false;

            pnInput.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makho ="";
            if (bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập Phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makho = ((DataRowView)bdsKHO[bdsKHO.Position])["MAKHO"].ToString();
                    bdsKHO.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho, bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    bdsKHO.Position = bdsKHO.Find("MAKHO", makho);
                    return;
                }
            }
            if (bdsKHO.Count == 0) btnXoa.Enabled = false;
        }
    }
}
