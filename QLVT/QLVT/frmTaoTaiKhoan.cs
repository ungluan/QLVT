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
    public partial class frmTaoTaiKhoan : Form
    {
        String groupSelected = Program.mGroup;
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                rbtCongTy.Checked = true;
                rbtCongTy.Enabled = true;
                rbtChiNhanh.Enabled = rbtUser.Enabled = false;
                cmbChiNhanh.Enabled = true;
            }
            else if(Program.mGroup == "CHINHANH")
            {
                rbtCongTy.Enabled = false ;
                rbtChiNhanh.Enabled = rbtUser.Enabled = true;
                rbtChiNhanh.Checked = true;
                cmbChiNhanh.Enabled = false;
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void nhanVienBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void rbtCongTy_CheckedChanged(object sender, EventArgs e)
        {
            groupSelected = "CONGTY";
        }

        private void rdbChiNhanh_CheckedChanged(object sender, EventArgs e)
        {
            groupSelected = "CHINHANH";
        }

        private void rbtUser_CheckedChanged(object sender, EventArgs e)
        {
            groupSelected = "USER";
        }
        private void taoTaiKhoan()
        {
            String query = "DECLARE	@return_value int "+
                "EXEC	@return_value = [dbo].[SP_Tao_Tai_Khoan] "+
                "@LOGINNAME = N'"+txtLoginName.Text.Trim()+"', "+
                "@PASSWORD = N'"+txtPassword.Text+"', "+
                "@MANV = N'"+txtMaNV.Text+"', "+
                "@ROLE = N'"+groupSelected+"' "+
                "SELECT	'Return Value' = @return_value";
            try
            {
                Program.ExecSqlNonQuery(query);
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
                txtLoginName.Text = "";
                txtPassword.Text = "";
                if (Program.mGroup == "CHINHANH") rbtChiNhanh.Checked = true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi tạo tài khoản: \n"+e.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được thiếu!", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if (txtPassword.Text=="")
            {
                MessageBox.Show("Password không được thiếu!", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            taoTaiKhoan();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if(cmbChiNhanh.SelectedIndex != Program.mChinhanh)
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
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
