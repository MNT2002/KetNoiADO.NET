using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiADO.NET.ChucNang
{
    public partial class LinQtoSQLQuanLyMatHang : UserControl
    {
        public LinQtoSQLQuanLyMatHang()
        {
            InitializeComponent();
        }

        private void LinQtoSQLQuanLyMatHang_Load(object sender, EventArgs e)
        {
            clConnect cl = new clConnect();
            string sql = "SELECT * from MatHang";
            DataTable MatHang = cl.LoadData(sql);
            dgv_MatHang.DataSource = MatHang;

            foreach (DataGridViewColumn dgvc in dgv_MatHang.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgv_MatHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                                      e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 15,
                                      e.RowBounds.Location.Y + 4
                    );
            }
        }

        private void dgv_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[0].Value.ToString();
            txt_TenHang_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[1].Value.ToString();
            txt_SoLuong_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[2].Value.ToString();
            txt_DonGia_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
