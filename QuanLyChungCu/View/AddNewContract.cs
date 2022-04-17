using ComponentFactory.Krypton.Toolkit;
using System;
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
    public partial class AddNewContract : Form
    {
        public static string text = "";
        Controller.ContractCtrl contractCtrl = new Controller.ContractCtrl();
        Controller.TenantCtrl tenantCtrl = new Controller.TenantCtrl();
        Model.ContractManage contractMng = new Model.ContractManage();
        Model.DwellerManage dwellerManage = new Model.DwellerManage();
        Object.ObjContract contract = new Object.ObjContract();
        Object.ObjDweller dweller = new Object.ObjDweller();
        Controller.DwellerCtrl dwellerCtrl = new Controller.DwellerCtrl();
        Object.ObjRoom room = new Object.ObjRoom();
        Object.ObjTenant tenant = new Object.ObjTenant();

        public AddNewContract()
        {
            InitializeComponent();
        }

        private void AddNewContract_Load(object sender, EventArgs e)
        {
            txtTenantBirthday.Enabled = false;
            txtDateStart.Enabled = false;
            txtDateEnd.Enabled = false;
            btnDateEnd.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            if (checkNullItem())
            {
                GanDuLieu(contract, dweller, tenant);
                CapNhatTrangThaiPhong(room);
                int resultContract = contractCtrl.ThemHopDong(contract);
                DateTime dateStart = DateTime.Parse(txtDateStart.Text);
                DateTime dateEnd = DateTime.Parse(txtDateEnd.Text);
                int resultDate = DateTime.Compare(dateStart, dateEnd);
                if (resultContract == 0 || resultContract == 2 || resultDate >= 0)
                {
                    if (resultContract == 0)
                    {
                        text = "Vui lòng chọn mã phòng khác!";
                        ThongBao(text);
                        return;
                    }
                    else if (resultContract == 2)
                    {
                        text = "Người thuê đang sở hữu một hợp đồng khác!";
                        ThongBao(text);
                        return;
                    }
                    if (resultDate >= 0)
                    {
                        ThongBao("Vui lòng chọn ngày hết hạn lớn hơn ngày đăng ký!");
                        return;
                    }
                }
                else
                {
                    if (contractCtrl.KTNguoiThue(contract.TenantIdCard))
                    {
                        tenantCtrl.Them(tenant);
                    }
                    else
                    {
                        tenantCtrl.Update(tenant);
                    }

                    if (dwellerCtrl.KTNguoiThue(dweller.DwellerIdCard))
                    {
                        dwellerManage.Save(dweller);
                    }
                    else
                    {
                        if (!dwellerCtrl.KTTrangThaiNguoiThue(dweller.DwellerIdCard))
                        {
                            dweller.DwellerStatus = "1";
                            dweller.DwellerStatusTitle = "Đang ở";
                            dwellerManage.Update(dweller);
                        }
                        else
                        {
                            ThongBao("Nguời thuê hiện đang ở tại một phòng khác");
                        }
                    }
                    contractMng.Save(contract);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    contractCtrl.CapNhatPhong(room);
                    LamMoi();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private bool checkNullItem()
        {
            if (txtTenantPhoneNumber.Text == " " || txtTenantName.Text == "" || txtTenantEmail.Text == "" ||
                cbbTenantGender.Text == "" || txtTenantBirthday.Text == "" || txtTenantIdCard.Text == "" ||
                txtRoomId.Text == "" || txtDateStart.Text == "" || txtDateEnd.Text == "" ||
                txtBank.Text == "" || txtCreditNumber.Text == "")
            {
                return false;
            }
            return true;
        }

        private void GanDuLieu(Object.ObjContract contract, Object.ObjDweller dweller, Object.ObjTenant tenant)
        {
            dweller.DwellerName = txtTenantName.Text.Trim();
            dweller.DwellerGender = cbbTenantGender.Text.Trim();
            dweller.DwellerBirthday = txtTenantBirthday.Text.Trim();
            dweller.DwellerIdCard = txtTenantIdCard.Text.Trim();
            dweller.DwellerStatus = "1";
            dweller.DwellerStatusTitle = "Đang ở";
            dweller.TenantIdCard = txtTenantIdCard.Text.Trim();

            contract.TenantIdCard = txtTenantIdCard.Text.Trim();
            contract.RoomId = txtRoomId.Text.Trim();
            contract.DateStart = txtDateStart.Text.Trim();
            contract.DateEnd = txtDateEnd.Text.Trim();
            contract.ContractStatus = "2";
            contract.ContractStatusTitle = "Đang hiệu lực";

            tenant.TenantIdCard = txtTenantIdCard.Text.Trim();
            tenant.TenantEmail = txtTenantEmail.Text.Trim();
            tenant.TenantPhoneNumber = txtTenantPhoneNumber.Text.Trim();
            tenant.CreditNumber = txtCreditNumber.Text.Trim();
            tenant.Bank = txtBank.Text.Trim();
        }

        private void CapNhatTrangThaiPhong(Object.ObjRoom room)
        {
            room.RoomId = txtRoomId.Text.Trim();
            room.RoomStatus = "1";
            room.RoomStatusTitle = "Phòng có người thuê";
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtTenantPhoneNumber.Clear();
            txtTenantName.Clear();
            txtTenantEmail.Clear();
            txtTenantBirthday.Clear();
            txtTenantIdCard.Clear();
            txtRoomId.Clear();
            txtDateStart.Clear();
            txtDateEnd.Clear();
            txtCreditNumber.Clear();
            txtBank.Clear();
        }

        private void setCalendar(KryptonTextBox textBox, MonthCalendar monthCalendar)
        {
            if (textBox.Text != "")
            {
                DateTime time = DateTime.Parse(textBox.Text);
                monthCalendar.SelectionStart = time;
            }
            monthCalendar.Visible = true;
        }

        private void mntDateStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateStart.Text = mntDateStart.SelectionStart.ToShortDateString();
            mntDateStart.Visible = false;
            btnDateEnd.Enabled = true;
        }

        private void mntDateStart_MouseLeave(object sender, EventArgs e)
        {
            mntDateStart.Visible = false;
        }

        private void mntDateEnd_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateEnd.Text = mntDateEnd.SelectionStart.ToShortDateString();
            mntDateEnd.Visible = false;
        }

        private void mntDateEnd_MouseLeave(object sender, EventArgs e)
        {
            mntDateEnd.Visible = false;
        }

        private void ValidNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTenantBirthday_Click(object sender, EventArgs e)
        {
            setCalendar(txtTenantBirthday, mntTenantBirthday);
        }

        private void mntTenantBirthday_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtTenantBirthday.Text = mntTenantBirthday.SelectionStart.ToShortDateString();
            mntTenantBirthday.Visible = false;
        }

        private void mntTenantBirthday_MouseLeave(object sender, EventArgs e)
        {
            mntTenantBirthday.Visible = false;
        }

        private void btnDateStart_Click(object sender, EventArgs e)
        {
            mntDateStart.MinDate = DateTime.Today;
            setCalendar(txtDateStart, mntDateStart);
        }

        private void btnDateEnd_Click(object sender, EventArgs e)
        {
            if (txtDateStart.Text == "")
            {
                mntDateEnd.MinDate = DateTime.Now;
            }
            else
            {
                DateTime dateEnd = DateTime.Parse(txtDateStart.Text);
                DateTime date;
                date = dateEnd.AddMonths(1);
                mntDateEnd.MinDate = date;
                setCalendar(txtDateEnd, mntDateEnd);
            }
        }

        private void txtTenantIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtTenantPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtCreditNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtTenantIdCard_Leave(object sender, EventArgs e)
        {
            //In Progres: Fill Date
            //FillDwellerData();
            //FillTenantData();
        }

        public void FillDwellerData()
        {
            SqlConnection conn = ConnectDatabase.connect;
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand();
            conn.Close();
            conn.Open();
            sqlcmd.CommandText = "SELECT DwellerName, DwellerGender, DwellerBirthday FROM Dweller WHERE DwellerIdCard = @cmnd";
            sqlcmd.Parameters.Add("cmnd", SqlDbType.VarChar).Value = txtTenantIdCard.Text;
            sqlcmd.Connection = conn;
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtTenantName.Text = dataReader.GetString(0).ToString();
                cbbTenantGender.Text = dataReader.GetString(1).ToString();
                txtTenantBirthday.Text = dataReader.GetDateTime(2).ToString("MM/dd/yyyy");
            }
            conn.Close();
        }

        public void FillTenantData()
        {
            SqlConnection conn = ConnectDatabase.connect;
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand();
            conn.Close();
            conn.Open();
            sqlcmd.CommandText = "SELECT TenantPhoneNumber, TenantEmail, CreditNumber, Bank From Tenant WHERE TenantIdCard = @cmnd";
            sqlcmd.Parameters.Add("cmnd", SqlDbType.VarChar).Value = txtTenantIdCard.Text;
            sqlcmd.Connection = conn;
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                txtTenantPhoneNumber.Text = dataReader.GetString(0).ToString();
                txtTenantEmail.Text = dataReader.GetString(1).ToString();
                txtCreditNumber.Text = dataReader.GetString(2).ToString();
                txtBank.Text = dataReader.GetString(3).ToString();
            }
            conn.Close();
        }
    }
}
