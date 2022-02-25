using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.Controller
{
    class RoomCtrl
    {
        Model.RoomManage roomMng = new Model.RoomManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return roomMng.Xoa(id);
        }

        public void HienThi(DataGridView dgv, string id_room)
        {
            dgv.DataSource = roomMng.GetDataRoom(id_room).Tables[0];
        }

        public int Update(Object.ObjRoom room)
        {
            return roomMng.Update(room);
        }

        public int Them(Object.ObjRoom room)
        {          
            if (!KTMaPhong(Convert.ToInt32(room.RoomId)))
                return 0;       
            return roomMng.Save(room);
        }   

        public bool KTMaPhong(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Room WHERE RoomId = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã phòng: " + e.Message);
                return false;
            }

        }    

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = roomMng.getListCustomerDetail(tukhoa, tieuchi).Tables[0];
        }
    }
}
