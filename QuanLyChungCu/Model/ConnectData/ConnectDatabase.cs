using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu
{
    class ConnectDatabase
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-S9KH54F\SQLEXPRESS;Initial Catalog=QuanLyChungCuMini;Integrated Security=True");
    }
}
