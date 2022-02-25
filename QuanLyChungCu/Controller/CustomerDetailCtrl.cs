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
    class CustomerDetailCtrl
    {
        Model.CustomerManage customerDetailMng = new Model.CustomerManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return customerDetailMng.Xoa(id);
        }

        public void HienThi(DataGridView dgv, string id_customer)
        {
            dgv.DataSource = customerDetailMng.GetDataCustomer(id_customer).Tables[0];
        }

        public int Update(Object.ObjCustomerDetail customerDetail)
        {
            return customerDetailMng.Update(customerDetail);
        }

        public int Them(Object.ObjCustomerDetail customerDetail)
        {
            if (!KTMaNguoiDung(Convert.ToInt32(customerDetail.CustomerId)))
                return 0;
            if (!KTMaPhong(Convert.ToInt32(customerDetail.RoomId)))
                return 2;
            if (!KTTrangThaiPhong(Convert.ToInt32(customerDetail.RoomId)))
                return 3;
            return customerDetailMng.Save(customerDetail);
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

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = customerDetailMng.getListCustomerDetail(tukhoa, tieuchi).Tables[0];
        }
    }
}
