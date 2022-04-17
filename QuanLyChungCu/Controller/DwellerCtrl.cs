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
    class DwellerCtrl
    {
        Model.DwellerManage dwellerMng = new Model.DwellerManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(Object.ObjDweller dweller)
        {
            return dwellerMng.Xoa(dweller);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = dwellerMng.GetDataCustomer().Tables[0];
        }

        public int Update(Object.ObjDweller dweller)
        {
            return dwellerMng.Update(dweller);
        }

        public int UpdateOldDweller(Object.ObjDweller dweller)
        {
            return dwellerMng.UpdateOldDweller(dweller);
        }

        public int Them(Object.ObjDweller dweller)
        {
            if (!KTCMNDNguoiDungTen(dweller.TenantIdCard))
                return 0;
            if (!KTNguoiDungTen(dweller.TenantIdCard))
                return 2;
            return dwellerMng.Save(dweller);
        }

        public bool KTCMNDNguoiDungTen(string cmnd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Tenant WHERE TenantIdCard = @tenantIdCard";
                cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = cmnd;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Người đứng tên: " + e.Message);
                return false;
            }
        }

        public bool KTNguoiDungTen(string cmnd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Tenant " +
                    "INNER JOIN Contract ON Tenant.TenantIdCard = Contract.TenantIdCard " +
                    "WHERE ContractStatus = '2' AND Tenant.TenantIdCard = @tenantIdCard";
                cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = cmnd;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Người đứng tên: " + e.Message);
                return false;
            }
        }

        public bool KTNguoiThue(string cmnd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Dweller WHERE DwellerIdCard = @dwellerIdCard";
                cmd.Parameters.Add("dwellerIdCard", SqlDbType.VarChar).Value = cmnd;
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

        public bool KTTrangThaiNguoiThue(string cmnd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Dweller WHERE DwellerIdCard = @dwellerIdCard AND DwellerStatus = '0'";
                cmd.Parameters.Add("dwellerIdCard", SqlDbType.VarChar).Value = cmnd;
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

        public bool KTSoHuuHopDong(string cmnd)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Tenant INNER JOIN Contract ON Contract.TenantIdCard = Tenant.TenantIdCard " +
                    "WHERE ContractStatus = '2' AND Tenant.TenantIdCard = @tenantIdCard";
                cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = cmnd;
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
            dgv.DataSource = dwellerMng.getListCustomerDetail(tukhoa, tieuchi).Tables[0];
        }
    }
}
