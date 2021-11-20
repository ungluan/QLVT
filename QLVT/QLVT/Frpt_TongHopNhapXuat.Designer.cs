
namespace QLVT
{
    partial class Frpt_TongHopNhapXuat
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(816, 36);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(160, 31);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(605, 36);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(160, 31);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(126, 36);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(6);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(348, 28);
            this.cmbChiNhanh.TabIndex = 13;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chi nhánh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(301, 122);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 37;
            label2.Text = "Đến Ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 122);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 20);
            label3.TabIndex = 36;
            label3.Text = "Từ Ngày";
            // 
            // deTo
            // 
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(403, 114);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.DisplayFormat.FormatString = "d/MM/yyyy";
            this.deTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTo.Properties.Mask.EditMask = "d/MM/yyyy";
            this.deTo.Size = new System.Drawing.Size(157, 28);
            this.deTo.TabIndex = 35;
            // 
            // deFrom
            // 
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(99, 118);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.DisplayFormat.FormatString = "d/MM/yyyy";
            this.deFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deFrom.Properties.Mask.EditMask = "d/MM/yyyy";
            this.deFrom.Size = new System.Drawing.Size(157, 28);
            this.deFrom.TabIndex = 34;
            // 
            // Frpt_TongHopNhapXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 257);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.deTo);
            this.Controls.Add(this.deFrom);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.label1);
            this.Name = "Frpt_TongHopNhapXuat";
            this.Text = "Frpt_TongHopNhapXuat";
            this.Load += new System.EventHandler(this.Frpt_TongHopNhapXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit deTo;
        private DevExpress.XtraEditors.DateEdit deFrom;
    }
}