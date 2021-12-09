using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmKho : Form
    {
        String macn="";
        int vitri = 0;
        public Stack<String> history_kho;
        // Undo Type
        String THEM_BTN = "_&them"; // Click btn thêm
        String XOA_BTN = "_&xoa"; // Click btn xóa
        String GHI_BTN = "_&ghi"; // Click btn ghi

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
            history_kho = new Stack<string>();

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
            String undoHistory = "";
            if (history_kho.Count > 0) undoHistory = history_kho.Pop();
            if (history_kho.Count == 0) btnUnDo.Enabled = false;

            if (undoHistory.Equals(""))
            {
                btnUnDo.Enabled = false;
                return;
            }

            if (undoHistory.Equals(THEM_BTN))
            {
                unClickThem();
                return;
            }

            if (undoHistory.Contains("_&ghi"))
            {
                int index = split_index_ghi(undoHistory);
                unClickGhi(index);
                return;
            }

            if (undoHistory.Contains(XOA_BTN))
            {
                string[] data_backup_split = split_data(undoHistory);
                unClickXoa(data_backup_split);
                return;
            }
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
                history_kho.Push(GHI_BTN + "#%" + txtMa.Text);
                
                this.khoTableAdapter.Update(this.DS.Kho);
                bdsKHO.Position = vitri;
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                
            }
            gcKho.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = true;
            btnGhi.Enabled = false;

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
                    string tenKho = ((DataRowView)bdsKHO[bdsKHO.Position])["TENKHO"].ToString();
                    string diaChi = ((DataRowView)bdsKHO[bdsKHO.Position])["DIACHI"].ToString();
                    bdsKHO.RemoveCurrent();
                    history_kho.Push(XOA_BTN + "#%" + makho + "#%" + tenKho + "#%" + diaChi);
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho, bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    bdsKHO.Position = bdsKHO.Find("MAKHO", makho);
                   
                }
            }
            if (bdsKHO.Count == 0) btnXoa.Enabled = false;
        }


        // ------ UNDO ------
        private void unClickThem()
        {
            btnThem.Enabled = btnXoa.Enabled = gcKho.Enabled = btnReload.Enabled = pnInput.Enabled = true;
            btnGhi.Enabled = txtMa.Enabled = false;
            this.bdsKHO.CancelEdit();
            bdsKHO.Position = vitri;
        }

        private void themFunc()
        {
            vitri = bdsKHO.Position;
            txtMa.Enabled = true;
            this.bdsKHO.AddNew();
            txtMaCN.Text = macn;
            btnThem.Enabled = btnXoa.Enabled = gcKho.Enabled = btnReload.Enabled = false;
            btnUnDo.Enabled = pnInput.Enabled = btnGhi.Enabled = true;
        }

        private void unClickGhi(int index)
        {
            string maKho_backup = ((DataRowView)bdsKHO[index])[0].ToString().Trim();
            DialogResult dr = MessageBox.Show("Phiếu '" + maKho_backup + "' đã được ghi vào database.\nBạn có chắc muốn Undo không??", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //int deletedPosition = current_bds.Find(type, maPhieu);

                string tenKho_backup = ((DataRowView)bdsKHO[index])[1].ToString().Trim();
                string diaChi_backup = ((DataRowView)bdsKHO[index])[2].ToString().Trim();
                bdsKHO.RemoveAt(index);
                themFunc();
                this.khoTableAdapter.Update(this.DS.Kho);
                txtMa.Text = maKho_backup;
                txtTen.Text = tenKho_backup;
                txtDiaChi.Text = maKho_backup;

                return;
            }

            history_kho.Push(GHI_BTN + "#%" + maKho_backup);
        }

        private void unClickXoa(string[] data_backup)
        {
            bdsKHO.AddNew();
            ((DataRowView)bdsKHO[bdsKHO.Position])[0] = data_backup[1];
            // Khi tách dữ liệu ra thì ngày được tách thành: [2] - mm/dd/yyyy [3] - time [4] - AM/PM
            ((DataRowView)bdsKHO[bdsKHO.Position])[1] = data_backup[2];
            ((DataRowView)bdsKHO[bdsKHO.Position])[2] = data_backup[3];
            ((DataRowView)bdsKHO[bdsKHO.Position])[3] = macn;
            bdsKHO.EndEdit();
            this.khoTableAdapter.Update(this.DS.Kho);
        }

        public int split_index_ghi(string GHIBTN)
        {
            char[] separators = new char[] { '#', '%' };
            string[] temp = GHIBTN.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string maPhieu = temp[1];
            int indexDataRowUpdated = bdsKHO.Find("MAKHO", maPhieu);

            return indexDataRowUpdated;
        }

        private string[] split_data(string XOABTN)
        {
            char[] separators = new char[] { '#', '%' };
            string[] data = XOABTN.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return data;
        }
    }

}
