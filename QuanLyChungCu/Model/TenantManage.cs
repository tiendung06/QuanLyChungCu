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
    class TenantManage
    {
        DataConfig cls = new DataConfig();

        public int Update(Object.ObjTenant tenant)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Tenant SET TenantEmail = @email, TenantPhoneNumber = @phone, CreditNumber = @crdNumber, " +
                "Bank = @bank, TenantIdCard = @tenantIdCard WHERE TenantIdCard = @tenantIdCard;";
            cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = tenant.TenantIdCard;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = tenant.TenantEmail;
            cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = tenant.TenantPhoneNumber;
            cmd.Parameters.Add("crdNumber", SqlDbType.VarChar).Value = tenant.CreditNumber;
            cmd.Parameters.Add("bank", SqlDbType.VarChar).Value = tenant.Bank;
            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjTenant tenant)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO " +
                "Tenant(TenantIdCard, TenantEmail, TenantPhoneNumber, CreditNumber, Bank) " +
                "VALUES (@tenantIdCard, @email, @phone, @crdNumber, @bank)";
            cmd.Parameters.Add("tenantIdCard", SqlDbType.VarChar).Value = tenant.TenantIdCard;
            cmd.Parameters.Add("email", SqlDbType.VarChar).Value = tenant.TenantEmail;
            cmd.Parameters.Add("phone", SqlDbType.VarChar).Value = tenant.TenantPhoneNumber;
            cmd.Parameters.Add("crdNumber", SqlDbType.VarChar).Value = tenant.CreditNumber;
            cmd.Parameters.Add("bank", SqlDbType.NVarChar).Value = tenant.Bank;
            return cls.CapNhatDL(cmd);
        }
    }
}
