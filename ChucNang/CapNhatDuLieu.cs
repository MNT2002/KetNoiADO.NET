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
    public partial class CapNhatDuLieu : UserControl
    {
        public CapNhatDuLieu()
        {
            InitializeComponent();
            
        }
        static string sql = "SELECT * FROM NhanVien";
        //Kết nối CSDL có userid và mật khẩu
        static string connStr = "Data Source = .\\;Initial Catalog=QLCuaHang; " +
            "User Id = sa; Password = 123456";
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connStr);
        DataSet dataSet = new DataSet();

        private void LoadGrid()
        {
            dataAdapter = new SqlDataAdapter(sql, connStr);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "NhanVien");
            DataView dataView = new DataView(dataSet.Tables["NhanVien"]);
            //Load dữ liệu từ dataView vào GridView
            dgv_NhanVien.DataSource = dataView;
            //Tắt chức năng Sort dữ liệu theo cột
            foreach (DataGridViewColumn dgvc in dgv_NhanVien.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void CapNhatDuLieu_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            //Thêm dữ liệu mới
            DataTable dataTable = dataSet.Tables["NhanVien"];
            DataRow dataRow = dataTable.NewRow();
            dataRow["HoTen"] = txt_HoTen.Text;
            dataRow["DiaChi"] = txt_DiaChi.Text;
            dataRow["Username"] = txt_Username.Text;
            dataRow["Password"] = txt_Password.Text;
            dataRow["Quyen"] = txt_Quyen.Text;
            dataTable.Rows.Add(dataRow);
            //Cập nhật CSDL vào bảng NhanVien
            dataAdapter.Update(dataSet,"NhanVien");
            LoadGrid();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int dong_can_xoa = int.Parse(txt_Xoa.Text);
            //Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            //Xóa dòng
            DataTable dataTable = dataSet.Tables["NhanVien"];
            try
            {
                dataTable.Rows[dong_can_xoa].Delete();
                //Cập nhật CSDL vào bảng NhanVien
                dataAdapter.Update(dataSet, "NhanVien");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadGrid();
        }

        private void dgv_NhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Lấy vị trí hiện tại của dòng được chọn trên Gridview
            int ID_sua = dgv_NhanVien.CurrentRow.Index;
            DataTable dataTable = dataSet.Tables["NhanVien"];
            txt_HoTen_Sua.Text = dataTable.Rows[ID_sua]["HoTen"].ToString();
            txt_DiaChi_Sua.Text = dataTable.Rows[ID_sua]["DiaChi"].ToString(); 
            txt_Username_Sua.Text = dataTable.Rows[ID_sua]["Username"].ToString();
            txt_Password_Sua.Text = dataTable.Rows[ID_sua]["Password"].ToString();
            txt_Quyen_Sua.Text = dataTable.Rows[ID_sua]["Quyen"].ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            //Sửa dữ liệu
            DataTable dataTable = dataSet.Tables["NhanVien"];
            //Lấy vị trí hiện tại của dòng được chọn trên Gridview
            int ID_sua = dgv_NhanVien.CurrentRow.Index;
            DataRow dataRow = dataTable.Rows[ID_sua];
            dataRow["HoTen"] = txt_HoTen_Sua.Text;
            dataRow["DiaChi"] = txt_DiaChi_Sua.Text;
            dataRow["Username"] = txt_Username_Sua.Text;
            dataRow["Password"] = txt_Password_Sua.Text;
            dataRow["Quyen"] = txt_Quyen_Sua.Text;
            //Cập nhật CSDL vào bảng NhanVien
            dataAdapter.Update(dataSet, "NhanVien");
            LoadGrid();
        }

        private void dgv_NhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
