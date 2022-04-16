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
    class TenantCtrl
    {
        Model.TenantManage tenantManage = new Model.TenantManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Update(Object.ObjTenant tenant)
        {
            return tenantManage.Update(tenant);
        }

        public int Them(Object.ObjTenant tenant)
        {
            return tenantManage.Save(tenant);
        }

        public bool KTCMNDNguoiThue(string cmnd)
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
    }
}
