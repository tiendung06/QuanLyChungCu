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
    class DwellerManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataCustomer()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT Dweller.DwellerId, DwellerName, DwellerGender, DwellerBirthday, " +
                "DwellerIdCard, Contract.RoomId " +
                "FROM Dweller " +
                "LEFT JOIN Tenant " +
                "ON Dweller.TenantIdCard = Tenant.TenantIdCard " +
                "INNER JOIN Contract " +
                "ON Tenant.TenantIdCard = Contract.TenantIdCard " +
                "WHERE DwellerStatus = '1' AND ContractStatus = '2'";
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataCustomer().Tables[0];
        }

        public int Xoa(Object.ObjDweller dweller)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Dweller SET DwellerStatus = @status, DwellerStatusTitle = @title WHERE DwellerId = @id";
            cmd.Parameters.Add("status", SqlDbType.Int).Value = dweller.DwellerStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = dweller.DwellerStatusTitle;
            cmd.Parameters.Add("id", SqlDbType.Int).Value = dweller.DwellerId;
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjDweller dweller)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Dweller SET DwellerName = @name, DwellerGender = @gender, DwellerBirthday = @birthday, " +
                "DwellerIdCard = @dwellerIdCard, DwellerStatus = @status DwellerStatusTitle = @title WHERE DwellerId = @id;";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = dweller.DwellerId;
            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = dweller.DwellerName;
            cmd.Parameters.Add("gender", SqlDbType.NVarChar).Value = dweller.DwellerGender;
            cmd.Parameters.Add("birthday", SqlDbType.Date).Value = dweller.DwellerBirthday;
            cmd.Parameters.Add("dwellerIdCard", SqlDbType.VarChar).Value = dweller.DwellerIdCard;
            cmd.Parameters.Add("status", SqlDbType.Int).Value = dweller.DwellerStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = dweller.DwellerStatusTitle;
            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjDweller dweller)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO " +
                "Dweller(DwellerName, DwellerGender, DwellerBirthday, DwellerIdCard, DwellerStatus, DwellerStatusTitle, TenantIdCard) " +
                "VALUES (@name, @gender, @birthday, @dwellerIdCard, @status, @title, @tenantIdCard)";
            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = dweller.DwellerName;
            cmd.Parameters.Add("gender", SqlDbType.NVarChar).Value = dweller.DwellerGender;
            cmd.Parameters.Add("birthday", SqlDbType.Date).Value = dweller.DwellerBirthday;
            cmd.Parameters.Add("dwellerIdCard", SqlDbType.VarChar).Value = dweller.DwellerIdCard;
            cmd.Parameters.Add("status", SqlDbType.Int).Value = dweller.DwellerStatus;
            cmd.Parameters.Add("title", SqlDbType.NVarChar).Value = dweller.DwellerStatusTitle;
            cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = dweller.TenantIdCard;
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListCustomerDetail(string key, string tieuchi)
        {
            string sql = "SELECT Dweller.DwellerId, DwellerName, DwellerGender, DwellerBirthday, " +
                "DwellerIdCard, Contract.RoomId " +
                "FROM Dweller " +
                "LEFT JOIN Tenant " +
                "ON Dweller.TenantIdCard = Tenant.TenantIdCard " +
                "INNER JOIN Contract " +
                "ON Tenant.TenantIdCard = Contract.TenantIdCard WHERE DwellerStatus = '1' AND ContractStatus = '2' AND ";
            switch (tieuchi)
            {
                case "DwellerId":
                    sql += "DwellerId = " + key + "";
                    break;
                default:
                    sql += "DwellerName like N'%" + key + "%'";
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
