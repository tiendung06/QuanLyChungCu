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
    class RentManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataRent()
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT Rent.RentId, Rent.ContractId, Rent.RentStatusTitle, Rent.Month, Rent.PayDay, Rent.SettlementDay, Room.Cost " +
                "FROM Rent INNER JOIN Contract ON Rent.ContractId = Contract.ContractId INNER JOIN Room ON Contract.RoomId = Room.RoomId " +
                "ORDER BY RentStatus, Payday ASC");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataRent().Tables[0];
        }

        public int Update(Object.ObjRent rent)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Rent SET RentStatus = @status, RentStatusTitle = @title, SettlementDay = @settlementDay WHERE RentId = @id";
            cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = rent.RentId;
            cmd.Parameters.Add("settlementDay", SqlDbType.Date).Value = rent.SettlementDay;
            cmd.Parameters.Add("status", SqlDbType.Int).Value = rent.RentStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = rent.RentStatusTitle;
            return cls.CapNhatDL(cmd);
        }

        public int SetNull(Object.ObjRent rent)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Rent SET SettlementDay = NULL WHERE RentId = @id";
            cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = rent.RentId;
            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjRent rent)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Rent(RentId, RentStatus, RentStatusTitle, Payday, SettlementDay, ContractId, Month)" +
                "VALUES (@rentId, @status, @title, @payday, @settlementDay, @contractId, @cost, @month);";
            cmd.Parameters.Add("rentId", SqlDbType.NVarChar).Value = rent.RentId;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = rent.RentStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = rent.RentStatusTitle;
            cmd.Parameters.Add("payday", SqlDbType.Date).Value = rent.Payday;
            cmd.Parameters.Add("settlementDay", SqlDbType.Date).Value = rent.SettlementDay;
            cmd.Parameters.Add("contractId", SqlDbType.Int).Value = rent.ContractId;
            cmd.Parameters.Add("month", SqlDbType.Int).Value = rent.Month;
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListRent(string key, string tieuchi)
        {
            string sql = "SELECT Rent.RentId, Rent.ContractId, Rent.RentStatusTitle, Rent.Month, Rent.PayDay, Rent.SettlementDay, Room.Cost " +
                "FROM Rent INNER JOIN Contract ON Rent.ContractId = Contract.ContractId INNER JOIN Room ON Contract.RoomId = Room.RoomId " +
                "WHERE ";
            switch (tieuchi)
            {
                case "RentId":
                    sql += "RentId like N'%" + key + "%'";
                    break;
                default:
                    sql += "Rent.ContractId = " + key + "";
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
