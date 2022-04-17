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

        public int Xoa(Object.ObjContract contract)
        {
            return contractMng.Xoa(contract);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = contractMng.GetDataContract().Tables[0];
        }

        public int Update(Object.ObjContract contract)
        {
            return contractMng.Update(contract);
        }

        public int ThemHopDong(Object.ObjContract contract)
        {
            if (!KTTrangThaiPhong(Convert.ToInt32(contract.RoomId)))
                return 0;
            if (!KTHopDongCoSan(contract.TenantIdCard))
                return 2;
            return 1;
        }

        public int CapNhatPhong(Object.ObjRoom room)
        {
            return contractMng.UpdateRoom(room);
        }

        public bool KTTrangThaiPhong(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Room WHERE RoomId = @id AND RoomStatus = '1'";
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

        public bool KTHopDongCoSan(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Tenant INNER JOIN Contract ON Tenant.TenantIdCard = Contract.TenantIdCard " +
                    "WHERE ContractStatus = '2' AND Tenant.TenantIdCard = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hợp đồng: " + e.Message);
                return false;
            }
        }

        public bool KTNguoiThue(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Tenant WHERE TenantIdCard = @id";
                cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Người thuê: " + e.Message);
                return false;
            }
        }

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = contractMng.getListContract(tukhoa, tieuchi).Tables[0];
        }
    }
}
