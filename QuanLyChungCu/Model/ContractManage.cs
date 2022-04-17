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

        public DataSet GetDataContract()
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT ContractId, RoomId, TenantIdCard, DateStart, DateEnd, ContractStatusTitle FROM Contract");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataContract().Tables[0];
        }

        public int Xoa(Object.ObjContract contract)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Contract SET ContractStatus = @status, ContractStatusTitle = @title ContractId = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = contract.ContractId;
            cmd.Parameters.Add("status", SqlDbType.Int).Value = contract.ContractStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = contract.ContractStatusTitle;
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjContract contract)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Contract SET RoomId = @roomId, TenantIdCard = @tenantIdCard, DateStart = @dateStart, DateEnd = @dateEnd, " +
                "ContractStatusTitle = @title " +
                "WHERE ContractId = @contractId;";
            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = contract.RoomId;
            cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = contract.TenantIdCard;
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = contract.DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = contract.DateEnd;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = contract.ContractStatusTitle;
            cmd.Parameters.Add("contractId", SqlDbType.Int).Value = contract.ContractId;
            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjContract contract)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Contract(RoomId, TenantIdCard, DateStart, DateEnd, ContractStatus, ContractStatusTitle)" +
                "VALUES (@roomId, @tenantIdCard, @dateStart, @dateEnd, @status, @title);";
            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = contract.RoomId;
            cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = contract.TenantIdCard;
            cmd.Parameters.Add("dateStart", SqlDbType.Date).Value = contract.DateStart;
            cmd.Parameters.Add("dateEnd", SqlDbType.Date).Value = contract.DateEnd;
            cmd.Parameters.Add("status", SqlDbType.Int).Value = contract.ContractStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = contract.ContractStatusTitle;
            return cls.CapNhatDL(cmd);
        }

        public int UpdateRoom(Object.ObjRoom room)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Room SET RoomStatus = @status, RoomStatusTitle = @title WHERE RoomId = @roomId;";
            cmd.Parameters.Add("status", SqlDbType.Int).Value = room.RoomStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = room.RoomStatusTitle;
            cmd.Parameters.Add("roomId", SqlDbType.Int).Value = room.RoomId;
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListContract(string key, string tieuchi)
        {
            string sql = "SELECT ContractId, RoomId, TenantIdCard, DateStart, DateEnd, ContractStatusTitle " +
                "FROM Contract WHERE ";
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
