
namespace QLVT
{
    partial class Frpt_BangKeChiTietSoLuongTriGiaTheoLoai
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
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(264, 57);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.deFrom.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.Mask.EditMask = "d/M/yyyy";
            this.deFrom.Size = new System.Drawing.Size(150, 28);
            this.deFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày";
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(517, 57);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.DisplayFormat.FormatString = "d/M/yyyy";
            this.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.EditFormat.FormatString = "d/M/yyyy";
            this.deTo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.Mask.EditMask = "d/M/yyyy";
            this.deTo.Size = new System.Drawing.Size(150, 28);
            this.deTo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại";
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cmbLoai.Location = new System.Drawing.Point(58, 53);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(119, 28);
            this.cmbLoai.TabIndex = 5;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(703, 53);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(132, 37);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(859, 53);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 37);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frpt_BangKeChiTietSoLuongTriGiaTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 142);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deFrom);
            this.Name = "Frpt_BangKeChiTietSoLuongTriGiaTheoLoai";
            this.Text = "Xrpt_BangKeChiTietSoLuongTriGiaTheoLoai";
            this.Load += new System.EventHandler(this.Frpt_BangKeChiTietSoLuongTriGiaTheoLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit deTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnThoat;
    }
}