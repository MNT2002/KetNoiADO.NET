using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KetNoiADO.NET
{
    class clConnect
    {
        SqlConnection con = new SqlConnection();
        //KetNoi;
        //Kết nối SQL

        public clConnect()
        {
            try
            {
                con.ConnectionString = "Data Source = .\\;Initial Catalog=QLCuaHang; User Id = sa; Password = 123456"; ;
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
                //Sử dụng ChuoiKetNoi trong App.config
                Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {

            }
            //Kiểm tra trạng thái Kết nối
        }
        public void Close()
        {
            con.Dispose();
            //Đóng kết nối
        }
        public DataTable LoadData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            //Truy vấn câu lệnh sql trong kết nối con
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Đưa kq vào DataAdapter
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            //Đưa kq vào Datatable thông qua DataAdapter
            return dt;

        }
        public DataTable LoadData(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            // Close();
            return dt;
        }
        public int UpdateData(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }

        public int UpdateData(string sql, string[] name, object[] value, int Nparameter)
        {
            SqlCommand command = new SqlCommand(sql, con);
            for (int i = 0; i < Nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }

    }
}
