using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.Controller
{
    class StaisticalCtr
    {
        Model.StatisticalMng StatisticalMng = new Model.StatisticalMng();

        public void ThongKeTheoTime(DataGridView dgv, DateTime start, DateTime end)
        {
            dgv.DataSource = StatisticalMng.getListDeviceByTime(start, end).Tables[0];
        }

        public void ThongKeTheoTen(DataGridView dgv, string name)
        {
            dgv.DataSource = StatisticalMng.getListDeviceByName(name).Tables[0];
        }
    }
}
