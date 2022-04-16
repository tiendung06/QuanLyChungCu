using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.View
{
    public partial class BaoCaoThongKe : Form
    {
        Model.ReportManage reportManage = new Model.ReportManage();
        Controller.ReportCtrl reportCtrl = new Controller.ReportCtrl();
        public static string totalUsed;
        public static string totalLiqui;
        int option = 0;

        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            loadThongKe();
            reportCtrl.ThongKeTheoHoaDon(dgvDSChiTietHoaDon);
        }

        private void loadThongKe()
        {
            DataTable dataTable1 = reportManage.HTTongHoaDon();
            billCount.Text = dataTable1.Rows[0]["RentId"].ToString();
            DataTable dataTable2 = reportManage.HTTongDoanhThu();
            turnover.Text = dataTable2.Rows[0]["Cost"].ToString();
        }

        private void btnThongKeKhachHang_Click(object sender, EventArgs e)
        {
            option = 1;
            panelHoaDon.Visible = false;
            dgvDSChiTietHoaDon.Visible = false;
            panelNguoiThue.Visible = true;
            dgvDSChiTietNguoiThue.Visible = true;
            reportCtrl.ThongKeNguoiThue(dgvDSChiTietNguoiThue);
            DataTable dataTable = reportManage.HTTongNguoiThue();
            dwellerCount.Text = dataTable.Rows[0]["Tong"].ToString();
        }

        private void btnThongKeHoaDon_Click(object sender, EventArgs e)
        {
            option = 0;
            panelNguoiThue.Visible = false;
            dgvDSChiTietNguoiThue.Visible = false;
            panelHoaDon.Visible = true;
            dgvDSChiTietHoaDon.Visible = true;
            panelHoaDon.BringToFront();
            dgvDSChiTietHoaDon.BringToFront();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            if (option == 0)
            {
                for (int i = 1; i < dgvDSChiTietHoaDon.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDSChiTietHoaDon.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvDSChiTietHoaDon.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDSChiTietHoaDon.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDSChiTietHoaDon.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            else
            {
                for (int i = 1; i < dgvDSChiTietNguoiThue.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDSChiTietNguoiThue.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvDSChiTietNguoiThue.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDSChiTietNguoiThue.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDSChiTietNguoiThue.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            try
            {
                workbook.SaveAs("C:\\Users\\Administrator\\Desktop\\ExportStatistical.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception)
            {

            }
            app.Quit();
        }
    }
}
