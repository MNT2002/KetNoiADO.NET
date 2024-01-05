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
    public partial class ThemSuaXoaMatHang : UserControl
    {
        public ThemSuaXoaMatHang()
        {
            InitializeComponent();
        }

        private void ThemSuaXoaMatHang_Load(object sender, EventArgs e)
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            clConnect cl = new clConnect();
            string sql = "INSERT INTO MatHang(TenHang,SoLuong,DonGia) VALUES (@TenHang,@SoLuong,@DonGia)";
            int n_prm = 3;
            string[] name = new string[n_prm];
            object[] value = new object[n_prm];
            name[0] = "@TenHang"; value[0] = txt_TenHang.Text;
            name[1] = "@SoLuong"; value[1] = txt_SoLuong.Text;
            name[2] = "@DonGia"; value[2] = txt_DonGia.Text;
            if(cl.UpdateData(sql, name, value, n_prm) > 0)
            {
                MessageBox.Show("Thêm mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemSuaXoaMatHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm mặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            clConnect cl = new clConnect();
            string sql = "DELETE MatHang where IDHang = @IDHang";
            int n_prm = 1;
            string[] name = new string[n_prm];
            object[] value = new object[n_prm];
            name[0] = "@IDHang"; value[0] = txt_Xoa.Text;
            if (cl.UpdateData(sql, name, value, n_prm) > 0)
            {
                MessageBox.Show("Xóa hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemSuaXoaMatHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa mặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[0].Value.ToString();
            txt_TenHang_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[1].Value.ToString();
            txt_SoLuong_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[2].Value.ToString();
            txt_DonGia_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            clConnect cl = new clConnect();
            string sql = "UPDATE MatHang SET TenHang=@TenHang,SoLuong=@SoLuong,DonGia=@DonGia WHERE IDHang = @IDHang";
            int n_prm = 4;
            string[] name = new string[n_prm];
            object[] value = new object[n_prm];
            name[0] = "@TenHang"; value[0] = txt_TenHang_Sua.Text;
            name[1] = "@SoLuong"; value[1] = txt_SoLuong_Sua.Text;
            name[2] = "@DonGia"; value[2] = txt_DonGia_Sua.Text;
            name[3] = "@IDHang"; value[3] = txt_ID_Sua.Text;
            if (cl.UpdateData(sql, name, value, n_prm) > 0)
            {
                MessageBox.Show("Sửa mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ThemSuaXoaMatHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa mặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
