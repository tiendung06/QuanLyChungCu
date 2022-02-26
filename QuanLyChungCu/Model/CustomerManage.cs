using QuanLyChungCu.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.Model
{
    class CustomerManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataCustomer(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Customer");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataCustomer(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Customer WHERE CustomerId = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjCustomerDetail customerDetail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Customer SET CustomerName = @name, CustomerEmail = @email, CustomerGender = @gender, CustomerBirthday = @birthday, CustomerIdentityCard = @identity, RoomId = @roomid WHERE CustomerId = @customerid;";

            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = customerDetail.CustomerName;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = customerDetail.CustomerEmail;
            cmd.Parameters.Add("gender", SqlDbType.NVarChar).Value = customerDetail.CustomerGender;
            cmd.Parameters.Add("birthday", SqlDbType.Date).Value = customerDetail.CustomerBirthday;
            cmd.Parameters.Add("identity", SqlDbType.NVarChar).Value = customerDetail.CustomerIdentityCard;
            cmd.Parameters.Add("roomid", SqlDbType.Int).Value = customerDetail.RoomId;
            cmd.Parameters.Add("customerid", SqlDbType.Int).Value = customerDetail.CustomerId;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjCustomerDetail cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO " +
                "Customer(CustomerId, CustomerName, CustomerEmail, CustomerGender, CustomerBirthday, CustomerIdentityCard, RoomId) " +
                "VALUES (@id, @name, @email, @gender, @birthday, @identity, @roomid)";

            cmd.Parameters.Add("id", SqlDbType.Int).Value = cdt.CustomerId;
            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = cdt.CustomerName;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = cdt.CustomerEmail;
            cmd.Parameters.Add("gender", SqlDbType.NVarChar).Value = cdt.CustomerGender;
            cmd.Parameters.Add("birthday", SqlDbType.Date).Value = cdt.CustomerBirthday;
            cmd.Parameters.Add("identity", SqlDbType.NVarChar).Value = cdt.CustomerIdentityCard;
            cmd.Parameters.Add("roomid", SqlDbType.Int).Value = cdt.RoomId;

            return cls.CapNhatDL(cmd);
        }

        public DataSet getListCustomerDetail(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Customer WHERE ";

            switch (tieuchi)
            {
                case "CustomerId":
                    sql += "CustomerId = " + key + "";
                    break;
                default:
                    sql += "CustomerName like N'%" + key + "%'";
                    break;
            }
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sql);
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception ce)
            {
                MessageBox.Show("Null " + ce.Message);
                return null;
            }

        }
    }
}
