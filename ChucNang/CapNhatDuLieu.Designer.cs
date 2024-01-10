
namespace KetNoiADO.NET.ChucNang
{
    partial class CapNhatDuLieu
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
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Quyen = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txt_ID_Xoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_Quyen_Sua = new System.Windows.Forms.ComboBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_DiaChi_Sua = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Password_Sua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Username_Sua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ID_Sua = new System.Windows.Forms.TextBox();
            this.txt_HoTen_Sua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AllowUserToAddRows = false;
            this.dgv_NhanVien.AllowUserToDeleteRows = false;
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(37, 3);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(909, 121);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            this.dgv_NhanVien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_NhanVien_RowHeaderMouseClick);
            this.dgv_NhanVien.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_NhanVien_RowPostPaint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Quyen);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm";
            // 
            // comboBox_Quyen
            // 
            this.comboBox_Quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Quyen.FormattingEnabled = true;
            this.comboBox_Quyen.Location = new System.Drawing.Point(116, 156);
            this.comboBox_Quyen.Name = "comboBox_Quyen";
            this.comboBox_Quyen.Size = new System.Drawing.Size(177, 34);
            this.comboBox_Quyen.TabIndex = 6;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(71, 248);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(168, 32);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(116, 124);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(177, 32);
            this.txt_Password.TabIndex = 3;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(116, 91);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(177, 32);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(116, 58);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(177, 32);
            this.txt_DiaChi.TabIndex = 1;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(116, 26);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(177, 32);
            this.txt_HoTen.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quyền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.txt_ID_Xoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(372, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(47, 248);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(147, 32);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_ID_Xoa
            // 
            this.txt_ID_Xoa.Location = new System.Drawing.Point(136, 32);
            this.txt_ID_Xoa.Name = "txt_ID_Xoa";
            this.txt_ID_Xoa.ReadOnly = true;
            this.txt_ID_Xoa.Size = new System.Drawing.Size(100, 32);
            this.txt_ID_Xoa.TabIndex = 1;
            this.txt_ID_Xoa.TextChanged += new System.EventHandler(this.txt_Xoa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID nhân viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_Quyen_Sua);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.txt_DiaChi_Sua);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_Password_Sua);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_Username_Sua);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_ID_Sua);
            this.groupBox3.Controls.Add(this.txt_HoTen_Sua);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(638, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 298);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sửa";
            // 
            // comboBox_Quyen_Sua
            // 
            this.comboBox_Quyen_Sua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Quyen_Sua.FormattingEnabled = true;
            this.comboBox_Quyen_Sua.Location = new System.Drawing.Point(114, 191);
            this.comboBox_Quyen_Sua.Name = "comboBox_Quyen_Sua";
            this.comboBox_Quyen_Sua.Size = new System.Drawing.Size(177, 34);
            this.comboBox_Quyen_Sua.TabIndex = 6;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(69, 248);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(168, 32);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_DiaChi_Sua
            // 
            this.txt_DiaChi_Sua.Location = new System.Drawing.Point(114, 94);
            this.txt_DiaChi_Sua.Name = "txt_DiaChi_Sua";
            this.txt_DiaChi_Sua.Size = new System.Drawing.Size(177, 32);
            this.txt_DiaChi_Sua.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "ID";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ tên:";
            // 
            // txt_Password_Sua
            // 
            this.txt_Password_Sua.Location = new System.Drawing.Point(114, 159);
            this.txt_Password_Sua.Name = "txt_Password_Sua";
            this.txt_Password_Sua.Size = new System.Drawing.Size(177, 32);
            this.txt_Password_Sua.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ:";
            // 
            // txt_Username_Sua
            // 
            this.txt_Username_Sua.Location = new System.Drawing.Point(114, 127);
            this.txt_Username_Sua.Name = "txt_Username_Sua";
            this.txt_Username_Sua.Size = new System.Drawing.Size(177, 32);
            this.txt_Username_Sua.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password:";
            // 
            // txt_ID_Sua
            // 
            this.txt_ID_Sua.Location = new System.Drawing.Point(114, 31);
            this.txt_ID_Sua.Name = "txt_ID_Sua";
            this.txt_ID_Sua.ReadOnly = true;
            this.txt_ID_Sua.Size = new System.Drawing.Size(177, 32);
            this.txt_ID_Sua.TabIndex = 0;
            // 
            // txt_HoTen_Sua
            // 
            this.txt_HoTen_Sua.Location = new System.Drawing.Point(114, 62);
            this.txt_HoTen_Sua.Name = "txt_HoTen_Sua";
            this.txt_HoTen_Sua.Size = new System.Drawing.Size(177, 32);
            this.txt_HoTen_Sua.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Quyền:";
            // 
            // CapNhatDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_NhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CapNhatDuLieu";
            this.Size = new System.Drawing.Size(982, 451);
            this.Load += new System.EventHandler(this.CapNhatDuLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txt_ID_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_DiaChi_Sua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Password_Sua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Username_Sua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_HoTen_Sua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ID_Sua;
        private System.Windows.Forms.ComboBox comboBox_Quyen;
        private System.Windows.Forms.ComboBox comboBox_Quyen_Sua;
    }
}
