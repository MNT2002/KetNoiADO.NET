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
namespace KetNoiADO.NET
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM NhanVien Where Username = '"+
                txt_Username.Text+"' AND Password = '" +
                txt_Password.Text+"'";
            //Kết nối CSDL và truy vấn câu lệnh sql
            txt_sql.Text = sql;
            string connStr = "Data Source = .\\;Initial Catalog=QLCuaHang; " +
                "User Id = sa; Password = 123456";
            
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connStr);
            //Đổ dữ liệu từ dataAdapter vào dataSet, bảng NhanVien
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "NhanVien");
            DataTable tableNV = dataSet.Tables["NhanVien"];
            if(tableNV.Rows.Count >= 1)
            {
                MessageBox.Show("Đăng nhập thành công!!!");
            }
            else
            {
                MessageBox.Show("Sai username hoặc mật khẩu", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m_Prm = 2;
            string[] name = new string[m_Prm];
            object[] value = new object[m_Prm];
            string sql = "select * from NhanVien where username = @username and password = @password";
            name[0] = "@username"; value[0] = txt_Username.Text;
            name[1] = "@password"; value[1] = txt_Password.Text;
            clConnect cl = new clConnect();
            DataTable NhanVien =  cl.LoadData(sql, name, value, m_Prm);
            if(NhanVien.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công!!!");
                this.Hide();
                frm_Main frmMain = new frm_Main(NhanVien.Rows[0]["HoTen"].ToString());
                frmMain.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai username hoặc mật khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //SqlParameter username = new SqlParameter("@username", txt_Username.Text);
            //SqlParameter password = new SqlParameter("@password", txt_Password.Text);
            //string sql = "select * from NhanVien where username = @username and password = @password";
            //string connStr = "Data Source = ADMIN\\SQL2008R2;Initial Catalog=QLCuaHang; User Id = sa; Password = 123456";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connStr);
            //sqlDataAdapter.SelectCommand.Parameters.Add(username);
            //sqlDataAdapter.SelectCommand.Parameters.Add(password);

            //DataSet dataSet = new DataSet();
            //sqlDataAdapter.Fill(dataSet, "NhanVien");
            //DataTable tableNV = dataSet.Tables["NhanVien"];
            //if (tableNV.Rows.Count >= 1)
            //{
            //    MessageBox.Show("Đăng nhập thành công!!!");
            //}
            //else
            //{
            //    MessageBox.Show("Sai username hoặc mật khẩu", "Thông báo",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.button2_Click(sender, e);
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.button2_Click(sender, e);
            }
        }
    }
}
