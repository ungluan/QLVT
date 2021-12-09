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
    public partial class subformChonChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public int ReturnValue1 { get; set; }
        private String tenCN = "";
        private int maNV;

        


        public subformChonChiNhanh(object gETVALUE)
        {
            InitializeComponent();
            /*this.maNV = maNV;*/
        
        }

        public subformChonChiNhanh(Action<string> gETVALUE)
        {
        }

        private void LayDSPM(String cmd)
        {
            SqlConnection conn_string = new SqlConnection(Program.connstr_publisher);
            DataTable dt = new DataTable();
            conn_string.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_string);
            da.Fill(dt);
            conn_string.Close();
            cmbChiNhanh.DataSource = dt;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }
        private void subformChonChiNhanh_Load(object sender, EventArgs e)
        {
            //LayDSPM("SELECT * FROM Get_Subscribes");
            LayDSPM("SELECT * FROM V_DS_PHANMANH");
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            tenCN = cmbChiNhanh.Text;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == Program.servername)
            {
                MessageBox.Show("Nhân viên đã ở chi nhánh này!", "", MessageBoxButtons.OK);
                cmbChiNhanh.Focus();
                return;
            }
            try
            {
                String query = "EXEC SP_Chuyen_Chi_Nhanh '" + maNV + "',N'" + tenCN + "'";
                Program.ExecSqlNonQuery(query);
                MessageBox.Show("Chuyển chi nhánh thành công!", "", MessageBoxButtons.OK);
                this.ReturnValue1 = 1;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi chuyển chi nhánh: \n"+ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
