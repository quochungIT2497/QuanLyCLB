using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyCLB
{
    internal class Connection //Tạo 1 class connection riêng để dùng cho cả form
    {
        private static string StringConnection = @"Data Source=DESKTOP-6HJIUMS;Initial Catalog=QuanlyCLB;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(StringConnection);
        }
    }
}
