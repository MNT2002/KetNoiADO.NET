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
        string username_current;
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
            //dataAdapter = new SqlDataAdapter(sql, connStr);
            //dataSet = new DataSet();
            //dataAdapter.Fill(dataSet, "NhanVien");
            //DataView dataView = new DataView(dataSet.Tables["NhanVien"]);
            ////Load dữ liệu từ dataView vào GridView
            //dgv_NhanVien.DataSource = dataView;
            ////Tắt chức năng Sort dữ liệu theo cột
            //foreach (DataGridViewColumn dgvc in dgv_NhanVien.Columns)
            //{
            //    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}


            clConnect cl = new clConnect();
            DataTable NhanVien = cl.LoadData(sql);
            dgv_NhanVien.DataSource = NhanVien;

            foreach (DataGridViewColumn dgvc in dgv_NhanVien.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void CapNhatDuLieu_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                comboBox_Quyen.Items.Add(i.ToString());
                comboBox_Quyen_Sua.Items.Add(i.ToString());
            }
            // Cài đặt giá trị mặc định
            comboBox_Quyen.SelectedIndex = 0;
            LoadGrid();
        }

        //Hàm kiểm tra username đã tồn tại hay chưa
        private bool IsUsernameExist(string username)
        {
            clConnect cl = new clConnect();
            string sql = "SELECT * FROM NhanVien WHERE Username = @Username";
            string[] name = { "@Username" }; object[] values = { username };

            DataTable countTable = cl.LoadData(sql, name, values, 1);
            return countTable.Rows.Count > 0; //True nếu truy vấn thành công <=> countTable = 1
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ////Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            //SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            ////Thêm dữ liệu mới
            //DataTable dataTable = dataSet.Tables["NhanVien"];
            //DataRow dataRow = dataTable.NewRow();
            //dataRow["HoTen"] = txt_HoTen.Text;
            //dataRow["DiaChi"] = txt_DiaChi.Text;
            //dataRow["Username"] = txt_Username.Text;
            //dataRow["Password"] = txt_Password.Text;
            //dataRow["Quyen"] = txt_Quyen.Text;
            //dataTable.Rows.Add(dataRow);
            ////Cập nhật CSDL vào bảng NhanVien
            //dataAdapter.Update(dataSet, "NhanVien");
            ////LoadGrid();

            if (IsUsernameExist(txt_Username.Text))
            {
                MessageBox.Show("Username đã tồn tại. Vui lòng chọn username khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clConnect cl = new clConnect();
            int m_Prm = 5;
            string[] name = new string[m_Prm];
            object[] value = new object[m_Prm];
            string sql = "INSERT INTO NhanVien(HoTen, DiaChi, Username, Password, Quyen) Values (@Hoten, @DiaChi, @Username, @Password, @Quyen) ";
            name[0] = "@Hoten"; value[0] = txt_HoTen.Text;
            name[1] = "@DiaChi"; value[1] = txt_DiaChi.Text;
            name[2] = "@Username"; value[2] = txt_Username.Text;
            name[3] = "@Password"; value[3] = txt_Password.Text;
            name[4] = "@Quyen"; value[4] = comboBox_Quyen.SelectedItem;
            if (cl.UpdateData(sql, name, value, m_Prm) > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //int dong_can_xoa = int.Parse(txt_ID_Xoa.Text);
            ////Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            //SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            ////Xóa dòng
            //DataTable dataTable = dataSet.Tables["NhanVien"];
            //try
            //{
            //    dataTable.Rows[dong_can_xoa].Delete();
            //    //Cập nhật CSDL vào bảng NhanVien
            //    dataAdapter.Update(dataSet, "NhanVien");
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //LoadGrid();

            clConnect cl = new clConnect();
            string sql = "DELETE NhanVien where ID = @IDNhanVien";
            int n_prm = 1;
            string[] name = new string[n_prm];
            object[] value = new object[n_prm];
            name[0] = "@IDNhanVien"; value[0] = txt_ID_Xoa.Text;
            if (cl.UpdateData(sql, name, value, n_prm) > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại, không tìm thấy ID nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_NhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Lấy vị trí hiện tại của dòng được chọn trên Gridview
            //int ID_sua = dgv_NhanVien.CurrentRow.Index;
            //DataTable dataTable = dataSet.Tables["NhanVien"];
            //txt_HoTen_Sua.Text = dataTable.Rows[ID_sua]["HoTen"].ToString();
            //txt_DiaChi_Sua.Text = dataTable.Rows[ID_sua]["DiaChi"].ToString();
            //txt_Username_Sua.Text = dataTable.Rows[ID_sua]["Username"].ToString();
            //txt_Password_Sua.Text = dataTable.Rows[ID_sua]["Password"].ToString();
            //txt_Quyen_Sua.Text = dataTable.Rows[ID_sua]["Quyen"].ToString();
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID_Xoa.Text = dgv_NhanVien.SelectedRows[0].Cells[0].Value.ToString();

            txt_ID_Sua.Text = dgv_NhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txt_HoTen_Sua.Text = dgv_NhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txt_DiaChi_Sua.Text = dgv_NhanVien.SelectedRows[0].Cells[2].Value.ToString();
            txt_Username_Sua.Text = dgv_NhanVien.SelectedRows[0].Cells[3].Value.ToString();
            txt_Password_Sua.Text = dgv_NhanVien.SelectedRows[0].Cells[4].Value.ToString();
            comboBox_Quyen_Sua.SelectedItem = dgv_NhanVien.SelectedRows[0].Cells[5].Value.ToString();

            username_current = txt_Username_Sua.Text;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ////Khởi tạo CommanBuilder cho phép cập nhập CSDL thông qua dataAdapter
            //SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            ////Sửa dữ liệu
            //DataTable dataTable = dataSet.Tables["NhanVien"];
            ////Lấy vị trí hiện tại của dòng được chọn trên Gridview
            //int ID_sua = dgv_NhanVien.CurrentRow.Index;
            //DataRow dataRow = dataTable.Rows[ID_sua];
            //dataRow["HoTen"] = txt_HoTen_Sua.Text;
            //dataRow["DiaChi"] = txt_DiaChi_Sua.Text;
            //dataRow["Username"] = txt_Username_Sua.Text;
            //dataRow["Password"] = txt_Password_Sua.Text;
            //dataRow["Quyen"] = txt_Quyen_Sua.Text;
            ////Cập nhật CSDL vào bảng NhanVien
            //dataAdapter.Update(dataSet, "NhanVien");
            //LoadGrid();

            if (username_current != txt_Username_Sua.Text) //Kiểm tra username có thay đổi so với mặc định hay ko
            {
                if (IsUsernameExist(txt_Username_Sua.Text))
                {
                    MessageBox.Show("Username đã tồn tại. Vui lòng chọn username khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            clConnect cl = new clConnect();
            string sql = "UPDATE NhanVien SET HoTen=@HoTen,DiaChi=@DiaChi,Username=@Username,Password=@Password,Quyen=@Quyen WHERE ID = @IDNhanVien";
            int n_prm = 6;
            string[] name = new string[n_prm];
            object[] value = new object[n_prm];
            name[0] = "@IDNhanVien"; value[0] = txt_ID_Sua.Text;
            name[1] = "@HoTen"; value[1] = txt_HoTen_Sua.Text;
            name[2] = "@DiaChi"; value[2] = txt_DiaChi_Sua.Text;
            name[3] = "@Username"; value[3] = txt_Username_Sua.Text;
            name[4] = "@Password"; value[4] = txt_Password_Sua.Text;
            name[5] = "@Quyen"; value[5] = comboBox_Quyen_Sua.SelectedItem;
            if (cl.UpdateData(sql, name, value, n_prm) > 0)
            {
                MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_Xoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
