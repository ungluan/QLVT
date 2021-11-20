
namespace QLVT
{
    partial class Frpt_HoatDongCuaNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QLVT.DS();
            this.hOTENNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.cmbTenNV = new System.Windows.Forms.ComboBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            mANVLabel3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel3
            // 
            mANVLabel3.AutoSize = true;
            mANVLabel3.Location = new System.Drawing.Point(50, 170);
            mANVLabel3.Name = "mANVLabel3";
            mANVLabel3.Size = new System.Drawing.Size(108, 20);
            mANVLabel3.TabIndex = 45;
            mANVLabel3.Text = "Tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new System.Drawing.Point(572, 167);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(103, 20);
            label5.TabIndex = 48;
            label5.Text = "Mã nhân viên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(50, 234);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 20);
            label6.TabIndex = 51;
            label6.Text = "Loại";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(192, 112);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(6);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(356, 28);
            this.cmbChiNhanh.TabIndex = 39;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Chi nhánh";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(511, 379);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 37);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(192, 379);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(140, 37);
            this.btnPreview.TabIndex = 34;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hoạt Động Nhân Viên";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTENNVBindingSource
            // 
            this.hOTENNVBindingSource.DataMember = "HOTENNV";
            this.hOTENNVBindingSource.DataSource = this.dS;
            // 
            // hOTENNVTableAdapter
            // 
            this.hOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cmbTenNV
            // 
            this.cmbTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTENNVBindingSource, "MANV", true));
            this.cmbTenNV.DataSource = this.hOTENNVBindingSource;
            this.cmbTenNV.DisplayMember = "HOTEN";
            this.cmbTenNV.FormattingEnabled = true;
            this.cmbTenNV.Location = new System.Drawing.Point(192, 167);
            this.cmbTenNV.Name = "cmbTenNV";
            this.cmbTenNV.Size = new System.Drawing.Size(299, 28);
            this.cmbTenNV.TabIndex = 46;
            this.cmbTenNV.ValueMember = "MANV";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTENNVBindingSource, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(695, 164);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 26);
            this.txtMANV.TabIndex = 49;
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cmbLoai.Location = new System.Drawing.Point(191, 226);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(121, 28);
            this.cmbLoai.TabIndex = 50;
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(391, 226);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "d/MM/yyyy";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.Mask.EditMask = "d/MM/yyyy";
            this.deFrom.Size = new System.Drawing.Size(157, 28);
            this.deFrom.TabIndex = 30;
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(695, 222);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.DisplayFormat.FormatString = "d/MM/yyyy";
            this.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.Mask.EditMask = "d/MM/yyyy";
            this.deTo.Size = new System.Drawing.Size(157, 28);
            this.deTo.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(318, 230);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 20);
            label3.TabIndex = 32;
            label3.Text = "Từ Ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(593, 230);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 33;
            label2.Text = "Đến Ngày";
            // 
            // Frpt_HoatDongCuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 670);
            this.Controls.Add(label6);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.txtMANV);
            this.Controls.Add(label5);
            this.Controls.Add(this.cmbTenNV);
            this.Controls.Add(mANVLabel3);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.deTo);
            this.Controls.Add(this.deFrom);
            this.Controls.Add(this.label1);
            this.Name = "Frpt_HoatDongCuaNhanVien";
            this.Text = "Frpt_HoatDongCuaNhanVien";
            this.Load += new System.EventHandler(this.Frpt_HoatDongCuaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource hOTENNVBindingSource;
        private DSTableAdapters.HOTENNVTableAdapter hOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTenNV;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.ComboBox cmbLoai;
        private DevExpress.XtraEditors.DateEdit deFrom;
        private DevExpress.XtraEditors.DateEdit deTo;
    }
}