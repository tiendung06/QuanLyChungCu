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
    class RentCtrl
    {
        Model.RentManage rentManage = new Model.RentManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = rentManage.GetDataRent().Tables[0];
        }

        public int Huy(Object.ObjRent rent)
        {
            return rentManage.SetNull(rent);
        }

        public int Update(Object.ObjRent rent)
        {
            return rentManage.Update(rent);
        }

        public void HienThiHoaDon(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = rentManage.getListRent(tukhoa, tieuchi).Tables[0];
        }

        public int Add(Object.ObjRent rent)
        {
            if (!KiemTraHoaDon(rent.RentId))
                return 0;
            return rentManage.Save(rent);

        }

        public bool KiemTraHoaDon(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT RentId FROM Rent";
                cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = id;
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
    }
}
