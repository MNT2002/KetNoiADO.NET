using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KetNoiADO.NET.ChucNang
{
    public partial class MoHinhNgatKetNoi : UserControl
    {
        public MoHinhNgatKetNoi()
        {
            InitializeComponent();
        }

        private void MoHinhNgatKetNoi_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NhanVien;";
            //Kết nối CSDL có userid và mật khẩu
            string connStr = "Data Source = .\\;Initial Catalog=QLCuaHang; " +
                "User Id = sa; Password = 123456";
            //Kết nối CSDL sử dụng xác thực của Windows
            //string connStr = "Data Source = .\\MINHNHATTRAN;Initial Catalog=QLCuaHang;Integrated Security = True;";

            // (1) Tao doi tuong DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connStr);
            // (2) Tao doi tuong DataSet
            DataSet dataSet = new DataSet();
            // (3) Tao mot Table co ten “NhanVien” trong DataSet va nap du lieu cho no
            adapter.Fill(dataSet, "NhanVien");
            // (4) Hien thi danh sach ten NhanVien ra combobox
            DataTable dataTable = dataSet.Tables["NhanVien"];

            //Thêm cột Tổng  = ID * 3
            //dataTable.Columns.Add("KetQua",Type.GetType("System.Int16"));
            //dataTable.Columns["KetQua"].Expression = "ID * 3";

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                cbb_NhanVien.Items.Add(row["HoTen"]);
            }

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    cbb_NhanVien.Items.Add(row["KetQua"]);
            //}

            DataView dv = new DataView(dataTable);
            //dv.RowFilter = "Quyen = 9";
            //đổ dữ liệu vào gridview
            dgv_DSNV.DataSource = dv;


            //DataRow dr = dataTable.NewRow();
            //dr["ID"] = '3';
            //dr["HoTen"] = "Trần Thảo";
            //dataTable.Rows.Add(dr);

            //DataView dv = new DataView(dataTable);
            ////Lọc ra các tài khoản có Quyền = 1
            //dv.RowFilter = "Quyen = 1";
            ////Sắp xếp theo username giảm dần
            //dv.Sort = "Username DESC";



        }

        private void dgv_DSNV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                                      e.InheritedRowStyle.Font, brush, e.RowBounds.Location.X + 15,
                                      e.RowBounds.Location.Y + 4
                    );
            }
        }

        private void dgv_DSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
