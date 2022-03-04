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
    class ContractCtrl
    {
        Model.ContractManage contractMng = new Model.ContractManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return contractMng.Xoa(id);
        }

        public int XoaNguoiDung(string roomId)
        {
            return contractMng.XoaNguoiDung(roomId);
        }

        public void HienThi(DataGridView dgv, string id_contract)
        {
            dgv.DataSource = contractMng.GetDataCustomer(id_contract).Tables[0];
        }

        public int Update(Object.ObjContract contract)
        {
            return contractMng.Update(contract);
        }

        public int ThemHopDong(Object.ObjContract contract)
        {
            if (!KTMaPhong(Convert.ToInt32(contract.RoomId)))
                return 0;
            if (!KTTrangThaiPhong(Convert.ToInt32(contract.RoomId)))
                return 2;
            return 1;
        }

        public int ThemNguoiDung(Object.ObjCustomerDetail customer)
        {
            if (!KTMaNguoiDung(Convert.ToInt32(customer.CustomerId)))
                return 0;
            return 1;
        }

        public int KiemTraNguoiDung(Object.ObjContract contract)
        {
            if (!KTNguoiDung(Convert.ToInt32(contract.CustomerId), Convert.ToInt32(contract.RoomId)))
                return 0;
            return 1;
        }

        public int CapNhatPhong(Object.ObjRoom room)
        {
            return contractMng.UpdateRoom(room);
        }

        public bool KTMaNguoiDung(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer WHERE CustomerId = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã tài khoản: " + e.Message);
                return false;
            }

        }

        public bool KTNguoiDung(int id, int roomId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer WHERE CustomerId = @id AND RoomId = @roomId";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("roomId", SqlDbType.Int).Value = roomId;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã tài khoản: " + e.Message);
                return false;
            }
        }

        public bool KTMaPhong(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Room WHERE RoomId = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
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

        public bool KTTrangThaiPhong(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Room WHERE RoomId = @id AND RoomStatus = N'Đã được thuê'";
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
            dgv.DataSource = contractMng.getListCustomerDetail(tukhoa, tieuchi).Tables[0];
        }
    }
}
