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
    class RoomManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataRoom(string idRoom)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Room");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataRoom(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Room WHERE RoomId = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjRoom room)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Room SET Cost = @cost, RoomFloor = @floor, RoomStatus = @status WHERE RoomId = @id";

            cmd.Parameters.Add("cost", SqlDbType.NVarChar).Value = room.Cost;
            cmd.Parameters.Add("floor", SqlDbType.NVarChar).Value = room.RoomFloor;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = room.RoomStatus;
            cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = room.RoomId;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjRoom cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO " +
                "Room(RoomId, Cost, RoomFloor, RoomStatus) " +
                "VALUES (@id, @cost, @floor, @status)";

            cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = cdt.RoomId;
            cmd.Parameters.Add("cost", SqlDbType.NVarChar).Value = cdt.Cost;
            cmd.Parameters.Add("floor", SqlDbType.NVarChar).Value = cdt.RoomFloor;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = cdt.RoomStatus;

            return cls.CapNhatDL(cmd);
        }

        public DataSet getListCustomerDetail(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Room WHERE ";

            switch (tieuchi)
            {
                case "RoomId":
                    sql += "RoomId = " + key + "";
                    break;
                default:
                    sql += "RoomId = " + key + "";
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
