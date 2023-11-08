using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCLB
{
    internal class Modify//class dùng để thực hiện lệnh sql
    {
        public Modify()
        {

        }
        SqlDataAdapter adapter; //gọi các hàm sql và gắn tên tạm
        SqlCommand cmd;
        public DataTable DT(string query) //Trả về bảng
        {
            DataTable dt = new DataTable(); //tạo bảng data mới
            using(SqlConnection conn = Connection.GetSqlConnection())//trỏ sqlconnection vào class connection để lấy source
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn); //Qúet CSDL = string query(Thêm vào sau) và source conn
                adapter.Fill(dt);//Thêm csdl vào bảng
                conn.Close();
            }
            return dt;
        }
        public void Command(string query)
        {
            using(SqlConnection conn = Connection.GetSqlConnection()) 
            { 
                conn.Open();
                cmd = new SqlCommand(query, conn);//Tương tự adapter nhưng thay = sqlcommand 
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
