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
        string tenHangCurrent;
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

        private void resetText()
        {
            txt_TenHang.Clear();
            txt_SoLuong.Clear();
            txt_DonGia.Clear();

            txt_ID_Sua.Clear();
            txt_TenHang_Sua.Clear();
            txt_SoLuong_Sua.Clear();
            txt_DonGia_Sua.Clear();

            txt_Xoa.Clear();

        }

        //Hàm kiểm tra username đã tồn tại hay chưa
        private bool IsTenHangExist(string Tenhang)
        {

            foreach (DataGridViewRow row in dgv_MatHang.Rows)
            {
                if (row.Cells["Tenhang"].Value.ToString() == Tenhang)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenHang.Text == "" || txt_SoLuong.Text == "" || txt_DonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đẩy các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsTenHangExist(txt_TenHang.Text))
            {
                MessageBox.Show("Mặt hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(txt_SoLuong.Text, out int soLuong_convert);
            int.TryParse(txt_DonGia.Text, out int donGia_convert);
            if (soLuong_convert == 0 || donGia_convert == 0)
            {
                MessageBox.Show("Vui lòng nhập \"Số lượng\" và \"Đơn giá\n là kiểu dữ liệu số và phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                resetText();
                ThemSuaXoaMatHang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm mặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mặt hàng " + tenHangCurrent, "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clConnect cl = new clConnect();
                string sql = "DELETE MatHang where MaHang = @IDHang";
                int n_prm = 1;
                string[] name = new string[n_prm];
                object[] value = new object[n_prm];
                name[0] = "@IDHang"; value[0] = txt_Xoa.Text;
                if (cl.UpdateData(sql, name, value, n_prm) > 0)
                {
                    MessageBox.Show("Xóa hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetText();
                    ThemSuaXoaMatHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa mặt hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                return;
            }
        }

        private void dgv_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[0].Value.ToString();
            txt_TenHang_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[1].Value.ToString();
            txt_SoLuong_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[2].Value.ToString();
            txt_DonGia_Sua.Text = dgv_MatHang.SelectedRows[0].Cells[3].Value.ToString();

            tenHangCurrent = dgv_MatHang.SelectedRows[0].Cells[1].Value.ToString();
            txt_Xoa.Text = dgv_MatHang.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tenHangCurrent != txt_TenHang_Sua.Text) //Kiểm tra Ten hang có thay đổi so với mặc định hay ko
            {
                if (txt_TenHang.Text == "" || txt_SoLuong.Text == "" || txt_DonGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đẩy các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsTenHangExist(txt_TenHang_Sua.Text))
                {
                    MessageBox.Show("Mặt hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int.TryParse(txt_SoLuong_Sua.Text, out int soLuong_convert);
            int.TryParse(txt_DonGia_Sua.Text, out int donGia_convert);
            if (soLuong_convert == 0 || donGia_convert == 0)
            {
                MessageBox.Show("Vui lòng nhập \"Số lượng\" và \"Đơn giá\n là kiểu dữ liệu số và phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có muốn sửa mặt hàng " + tenHangCurrent, "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                clConnect cl = new clConnect();
                string sql = "UPDATE MatHang SET TenHang=@TenHang,SoLuong=@SoLuong,DonGia=@DonGia WHERE Mahang = @IDHang";
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
            } else
            {
                return;
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

        private void txt_TenHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
