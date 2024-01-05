
namespace KetNoiADO.NET.ChucNang
{
    partial class MoHinhNgatKetNoi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_NhanVien = new System.Windows.Forms.ComboBox();
            this.dgv_DSNV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên:";
            // 
            // cbb_NhanVien
            // 
            this.cbb_NhanVien.FormattingEnabled = true;
            this.cbb_NhanVien.Location = new System.Drawing.Point(257, 68);
            this.cbb_NhanVien.Name = "cbb_NhanVien";
            this.cbb_NhanVien.Size = new System.Drawing.Size(199, 34);
            this.cbb_NhanVien.TabIndex = 1;
            // 
            // dgv_DSNV
            // 
            this.dgv_DSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSNV.Location = new System.Drawing.Point(41, 142);
            this.dgv_DSNV.Name = "dgv_DSNV";
            this.dgv_DSNV.RowHeadersWidth = 51;
            this.dgv_DSNV.Size = new System.Drawing.Size(795, 150);
            this.dgv_DSNV.TabIndex = 2;
            this.dgv_DSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSNV_CellContentClick);
            this.dgv_DSNV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_DSNV_RowPostPaint);
            // 
            // MoHinhNgatKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_DSNV);
            this.Controls.Add(this.cbb_NhanVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MoHinhNgatKetNoi";
            this.Size = new System.Drawing.Size(867, 317);
            this.Load += new System.EventHandler(this.MoHinhNgatKetNoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_NhanVien;
        private System.Windows.Forms.DataGridView dgv_DSNV;
    }
}
