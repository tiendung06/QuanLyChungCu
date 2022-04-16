using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.Controller
{
    class ReportCtrl
    {
        Model.ReportManage reportManage = new Model.ReportManage();

        public void ThongKeTheoHoaDon(DataGridView dgv)
        {
            dgv.DataSource = reportManage.getListBill().Tables[0];
        }

        public void ThongKeNguoiThue(DataGridView dgv)
        {
            dgv.DataSource = reportManage.getListDweller().Tables[0];
        }

    }
}
