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
    class ContractManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataCustomer(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Contract");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataCustomer(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Contract WHERE ContractId = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public int XoaNguoiDung(string roomId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Customer WHERE RoomId = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(roomId);
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjContract contract)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Contract SET RoomId = @roomId, CustomerId = @customerId, DateStart = @dateStart, DateEnd = @dateEnd WHERE ContractId = @contractId;";

            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = contract.RoomId;
            cmd.Parameters.Add("customerId", SqlDbType.Int).Value = contract.CustomerId;
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = contract.DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = contract.DateEnd;
            cmd.Parameters.Add("contractId", SqlDbType.Int).Value = contract.ContractId;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjContract contract)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Contract(RoomId, CustomerId, DateStart, DateEnd)" +
                "VALUES (@roomId, @customerId, @dateStart, @dateEnd);"; 
            
            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = contract.RoomId;
            cmd.Parameters.Add("customerId", SqlDbType.Int).Value = contract.CustomerId;
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = contract.DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = contract.DateEnd;

            return cls.CapNhatDL(cmd);
        }

        public int SaveCustomer(Object.ObjCustomerDetail cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO " +
                "Customer(CustomerId, CustomerName, CustomerEmail, CustomerGender, CustomerBirthday, CustomerIdentityCard, RoomId) " +
                "VALUES (@customerId, @name, @email, @gender, @birthday, @identity, @roomId)";

            cmd.Parameters.Add("customerId", SqlDbType.Int).Value = cdt.CustomerId;
            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = cdt.CustomerName;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = cdt.CustomerEmail;
            cmd.Parameters.Add("gender", SqlDbType.NVarChar).Value = cdt.CustomerGender;
            cmd.Parameters.Add("birthday", SqlDbType.Date).Value = cdt.CustomerBirthday;
            cmd.Parameters.Add("identity", SqlDbType.NVarChar).Value = cdt.CustomerIdentityCard;
            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = cdt.RoomId;

            return cls.CapNhatDL(cmd);
        }

        public int UpdateRoom(Object.ObjRoom room)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Room SET RoomStatus = @status WHERE RoomId = @roomId;";

            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = room.RoomStatus;
            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = room.RoomId;

            return cls.CapNhatDL(cmd);
        }

        public DataSet getListCustomerDetail(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Contract WHERE ";

            switch (tieuchi)
            {
                case "RoomId":
                    sql += "RoomId = " + key + "";
                    break;
                default:
                    sql += "ContractId = " + key + "";
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
