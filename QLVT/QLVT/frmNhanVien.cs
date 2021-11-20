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
    public partial class frmNhanVien : Form
    {
       
        int vitri = 0;
        String macn = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }
        private int checkExistsMaNV(String query)
        {
            SqlDataReader myReader =  Program.ExecSqlDataReader(query);
            myReader.Read();
            return myReader.GetInt32(0);
        }
        private String getMaCN()
        {
            String query = "Select MaCN from ChiNhanh";
            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            return myReader.GetString(0);
        }
        private int validateNgaySinh()
        {
            //deNgaySinh.Text
            String[] token = deNgaySinh.Text.Split('/');
            int day = Int32.Parse(token[0]);
            int month = Int32.Parse(token[1]);
            int year = Int32.Parse(token[2]);
            if (DateTime.Now.Year - year > 18)
            {
                return 1;
            }
            if (DateTime.Now.Year - year < 18)
            {
                return 0;
            }
            if (DateTime.Now.Month >= month)
            {
                return 1;
            }
            if (DateTime.Now.Month < month)
            {
                return 0;
            }
            if (DateTime.Now.Day >= day)
            {
                return 1;
            }
            return 0;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            // Gán chuỗi kết nối
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);


            macn = getMaCN();
            // Sao chép bds_dspm đã load ở form đăng nhập
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =
                    btnUnDo.Enabled = btnGhi.Enabled = btnChuyenCN.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = 
                    btnUnDo.Enabled = btnGhi.Enabled = true;
                if (bdsNV.Count == 0)
                {
                    btnXoa.Enabled = btnChuyenCN.Enabled = false;
                }else
                {
                    btnXoa.Enabled = btnChuyenCN.Enabled = true;
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            pnInput.Enabled = true;
            bdsNV.AddNew();
            txtMaCN.Text = macn;
            txtMaNV.Enabled = true;
            trangThaiXoaCheckBox.Checked = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =
                     btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUnDo.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            gcNhanVien.Enabled = true;
            pnInput.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnUnDo.Enabled
                = btnThoat.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            pnInput.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUnDo.Enabled = true;
            gcNhanVien.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Mã nhân viên ở đầu khóa chính không thể xóa được nếu mã nhân viên này
            // đã tồn tại ở đầu khóa ngoại
            Int32 manv = 0;
            if (bds_DatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bds_PhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bds_PhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập Phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.frmChinh.MANV.Text == txtMaNV.Text)
            {
                MessageBox.Show("Không thể xóa chính mình!", "", MessageBoxButtons.OK);
                return;
            }
            if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ??","Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();
                    String query = "EXEC [dbo].[SP_Xoa_Tai_Khoan] @MANV = N'" + manv+"'";
                    Program.ExecSqlNonQuery(query);
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên, bạn hãy xóa lại\n"+ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (txtHo.Text.Trim()=="")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (deNgaySinh.Text.Trim()=="") {
                MessageBox.Show("Ngày sinh không được thiếu!", "", MessageBoxButtons.OK);
                deNgaySinh.Focus();
                return;
            }
            if (validateNgaySinh() == 0)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "", MessageBoxButtons.OK);
                deNgaySinh.Focus();
                return;
            }
            if (float.Parse(txtLuong.Text.Trim()) < 4000000)
            {
                MessageBox.Show("Lương phải lớn hơn hoặc bằng 4 triệu đồng!", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }
            String query = "DECLARE	@return_value int "+
                            "EXEC @return_value = [dbo].[SP_Kiem_Tra_Ma] "+
                            "@Type = N'MANV'," +
                            "@ID ="+ txtMaNV.Text.Trim()+
                            " SELECT  'Return Value' = @return_value";

            if (checkExistsMaNV(query) != 0)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                txtMaNV.Focus();
                return;
            }
            try
            {
                // Ghi vào trong bds
                // Đưa thông tin đó lên cái lưới
                // Đưa thông tin lên csdl trên đường kết nối mà ta đã đăng nhập or đang
                // kết nối tới
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhanVien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUnDo.Enabled = false;

            pnInput.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Viết code rẻ về phân mảnh mới
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if(cmbChiNhanh.SelectedIndex != Program.mChinhanh)
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
                
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                // Trong thực tế lệnh này là lệnh thừa
                // Bởi vì coongty chỉ rẻ server và không thể hiệu chỉnh
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtLuong_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
  
            int maNV = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
            subformChonChiNhanh form = new subformChonChiNhanh(maNV);
            form.ShowDialog();
            if (form.ReturnValue1 == 1)
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            if (bdsNV.Count == 0) btnChuyenCN.Enabled = false;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xrpt_DanhSachNhanVien rpt = new Xrpt_DanhSachNhanVien();
            if (cmbChiNhanh.Text == "CHINHANH1")
            {
                rpt.lblTieuDe.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH 1";
            }
            else
            {
                rpt.lblTieuDe.Text = "DANH SÁCH NHÂN VIÊN CHI NHÁNH 2";
            }
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
