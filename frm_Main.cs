using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiADO.NET
{
    public partial class frm_Main : Form
    {
        String us;
        public frm_Main(String username)
        {
            us = username;
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            label1.Text = us;
        }

        private void VD_1_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.MoHinhNgatKetNoi();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);

        }

        private void VD_2_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.CapNhatDuLieu();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);
        }

        private void VD_3_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.ThemSuaXoaMatHang();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);
        }

        private void VD_4_Click(object sender, EventArgs e)
        {
            UserControl frm = new UserControl();
            frm = new ChucNang.LinQtoSQLQuanLyMatHang();
            panel_ChucNang.Controls.Clear();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_ChucNang.Controls.Add(frm);
        }

        private void panel_ChucNang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void log_out_btn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            frm_Login frmLogin = new frm_Login();
            frmLogin.ShowDialog();
        }
    }
}
