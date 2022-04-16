using QuanLyChungCu.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.View
{
    public partial class QuanLyThuTien : Form
    {
        public static string text = "";
        string[] optionFind = { "Mã hóa đơn", "Mã hợp đồng" };
        Model.RentManage rentManage = new Model.RentManage();
        Object.ObjRent rent = new Object.ObjRent();
        RentCtrl rentCtrl = new RentCtrl();
        ArrayList list = new ArrayList();

        public QuanLyThuTien()
        {
            InitializeComponent();
            AddBill();
        }

        private void QuanLyThuTien_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXuatHoaDon.Visible = false;
                btnHuyThanhToan.Visible = false;
                btnThanhToan.Visible = false;
            }
            rentManage.HienThi(dgvDSChiTietThuTien);
            HienThiThongTin();
            optionCombobox.DataSource = optionFind;
            txtRentId.Enabled = false;
            txtContractId.Enabled = false;
            txtRentStatus.Enabled = false;
            txtPayday.Enabled = false;
            txtSettlementDay.Enabled = false;
            txtCost.Enabled = false;
            txtMonth.Enabled = false;
        }

        private void HienThiThongTin()
        {
            if (dgvDSChiTietThuTien.CurrentRow != null)
            {
                txtRentId.Text = dgvDSChiTietThuTien.CurrentRow.Cells["RentId"].Value.ToString();
                txtContractId.Text = dgvDSChiTietThuTien.CurrentRow.Cells["ContractId"].Value.ToString();
                txtPayday.Text = dgvDSChiTietThuTien.CurrentRow.Cells["Payday"].Value.ToString();
                txtSettlementDay.Text = dgvDSChiTietThuTien.CurrentRow.Cells["SettlementDay"].Value.ToString();
                txtRentStatus.Text = dgvDSChiTietThuTien.CurrentRow.Cells["RentStatus"].Value.ToString();
                txtCost.Text = dgvDSChiTietThuTien.CurrentRow.Cells["Cost"].Value.ToString();
                txtMonth.Text = dgvDSChiTietThuTien.CurrentRow.Cells["Month"].Value.ToString();
            }
        }

        private void dgvDSChiTietThuTien_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtRentId.Clear();
            txtContractId.Clear();
            txtRentStatus.Clear();
            txtPayday.Clear();
            txtSettlementDay.Clear();
            txtCost.Clear();
            txtMonth.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn thanh toán hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                if (txtRentStatus.Text == "Chưa thanh toán")
                {
                    setDataRent(rent);
                    rent.RentStatus = "Đã thanh toán";
                    DateTime dateTime = DateTime.Now;
                    rent.SettlementDay = dateTime.ToString("yyyy-MM-dd");
                    string text = "Bạn có muốn thanh toán hóa đơn này?";
                    changeStatus(text);
                }
                else
                {
                    ThongBao("Hợp đồng đã được thanh toán");
                }
            }
        }

        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn hủy thanh toán hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                if (txtRentStatus.Text == "Đã thanh toán")
                {
                    setDataRent(rent);
                    rent.RentStatus = "Chưa thanh toán";
                    string text = "Bạn có muốn hủy thanh toán hóa đơn này?";
                    changeStatus(text);
                    rentCtrl.Huy(rent);
                    rentManage.HienThi(dgvDSChiTietThuTien);
                    HienThiThongTin();
                }
                else
                {
                    ThongBao("Hợp đồng chưa được thanh toán");
                }
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                if (txtRentStatus.Text == "Đã thanh toán")
                {
                    string rentId = dgvDSChiTietThuTien.CurrentRow.Cells[0].Value.ToString();
                    ExportWord export = new ExportWord();
                    export.GetDataBill(rentId);
                    export.FillDataBill();
                }
                else
                {
                    ThongBao("Hợp đồng chưa được thanh toán!");
                }
            }
            else
            {
                ThongBao("Chọn hợp đồng cần xuất!");
            }
        }

        private void setDataRent(Object.ObjRent rent)
        {
            rent.RentId = txtRentId.Text;
            rent.ContractId = txtContractId.Text;
            rent.RentStatus = txtRentStatus.Text;
            rent.Payday = txtPayday.Text;
            rent.SettlementDay = txtSettlementDay.Text;
            rent.Month = txtMonth.Text;
        }

        private bool checkNull()
        {
            if (txtRentId.Text == "")
            {
                return false;
            }
            if (txtContractId.Text == "")
            {
                return false;
            }
            if (txtRentStatus.Text == "")
            {
                return false;
            }
            if (txtPayday.Text == "")
            {
                return false;
            }
            return true;
        }

        private void changeStatus(string text)
        {
            if (checkNull())
            {
                DialogResult dlg = MessageBox.Show(text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (rentCtrl.Update(rent) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rentManage.HienThi(dgvDSChiTietThuTien);
                        HienThiThongTin();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            string option = (string)optionCombobox.SelectedItem;
            if (option == optionFind[1])
            {
                tieuchi = "ContractId";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        rentCtrl.HienThiHoaDon(dgvDSChiTietThuTien, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    ThongBao("Vui lòng nhập vào một số nếu tìm kiếm theo mã hợp đồng!");
                }
            }
            else
            {
                tieuchi = "RentId";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    rentCtrl.HienThiHoaDon(dgvDSChiTietThuTien, txtTimKiem.Text, tieuchi);
                }
            }
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void getDataContract()
        {
            string maHopDong;
            SqlConnection conn = ConnectDatabase.connect;
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT ContractId FROM Contract WHERE ContractStatus = N'Đang hiệu lực'";
            sqlcmd.Connection = conn;
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                maHopDong = dataReader.GetInt32(0).ToString();
                list.Add(maHopDong);
            }
            conn.Close();
        }

        public void AddBill()
        {
            string maHoaDon, ngay;
            DateTime date = DateTime.Now;
            ngay = date.ToString("MMyy");
            if (date.Day == 01)
            {
                getDataContract();
                for (int i = 0; i < list.Count; i++)
                {
                    maHoaDon = ngay + list[i].ToString();
                    rent.RentId = maHoaDon;
                    rent.Month = date.Month.ToString();
                    rent.ContractId = list[i].ToString();
                    rent.RentStatus = "Chưa thanh toán";
                    rent.Payday = date.ToString("yyyy-MM-dd");
                    rentCtrl.Add(rent);
                }
            }
        }
    }
}
