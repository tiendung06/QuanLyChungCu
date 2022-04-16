using QuanLyChungCu.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Model
{
    class ReportManage
    {
        DataConfig cls = new DataConfig();

        public DataTable HTTongHoaDon()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT COUNT(*) AS RentId FROM Rent WHERE RentStatus = N'Đã thanh toán'";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                sqldata.Fill(result);
            }
            catch (Exception)
            {

            }
            return result;
        }

        public DataTable HTTongDoanhThu()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT SUM(Room.Cost) AS Cost FROM Contract " +
                "INNER JOIN Rent ON Contract.ContractId = Rent.ContractId " +
                "INNER JOIN Room ON Contract.RoomId = Room.RoomId " +
                "WHERE Rent.RentStatus = N'Đã thanh toán'";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
                sqldata.Fill(result);
            }
            catch (Exception)
            {
            }
            return result;
        }

        public DataTable HTTongNguoiThue()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT COUNT(Dweller.DwellerId) AS Tong " +
                "FROM Dweller INNER JOIN Tenant ON Tenant.TenantIdCard = Dweller.TenantIdCard " +
                "INNER JOIN Contract ON Tenant.TenantIdCard = Contract.TenantIdCard";
            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
                sqldata.Fill(result);
            }
            catch (Exception)
            {
            }
            return result;
        }

        public DataSet getListBill()
        {
            SqlCommand sqlcmd = new SqlCommand("SELECT Contract.RoomId, Rent.RentId, Dweller.DwellerName, " +
                "Rent.Month, Rent.SettlementDay, Room.Cost " +
                "FROM Contract INNER JOIN Rent ON Contract.ContractId = Rent.ContractId " +
                "INNER JOIN Room ON Contract.RoomId = Room.RoomId " +
                "INNER JOIN Tenant ON Contract.TenantIdCard = Tenant.TenantIdCard " +
                "INNER JOIN Dweller ON Dweller.DwellerIdCard = Tenant.TenantIdCard " +
                "WHERE Rent.RentStatus = N'Đã thanh toán'");
            try
            {
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet getListDweller()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT Dweller.DwellerName, Dweller.DwellerGender, Dweller.DwellerBirthday, " +
                    "Dweller.DwellerIdCard, Contract.RoomId, Dweller.DwellerStatus " +
                    "FROM Dweller INNER JOIN Tenant ON Tenant.TenantIdCard = Dweller.TenantIdCard " +
                    "INNER JOIN Contract ON Tenant.TenantIdCard = Contract.TenantIdCard " +
                    "ORDER BY Dweller.DwellerStatus ASC");
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public DataSet getDeviceToChar()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT DATEPART(yyyy, Date_Liqui) AS 'Year', SUM(Id_Liqui) AS 'Total' FROM Liquidate GROUP BY DATEPART(yyyy, Date_Liqui)";

            //action get database
            DataSet result = new DataSet();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                sqldata.Fill(result);
            }
            catch (Exception)
            {

            }
            return result;
        }
    }
}
