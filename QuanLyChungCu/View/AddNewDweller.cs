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
    public partial class AddNewDweller : Form
    {
        public static string text = "";
        Controller.DwellerCtrl dwellerCtrl = new Controller.DwellerCtrl();
        Object.ObjDweller dweller = new Object.ObjDweller();

        public AddNewDweller()
        {
            InitializeComponent();
        }

        private bool checkNullItem()
        {
            if (txtDwellerName.Text == "" || cbbDwellerGender.Text == "" ||
                txtDwellerBirthday.Text == "" || txtDwellerIdCard.Text == "" ||
                txtTenantIdCard.Text == "")
            {
                return false;
            }
            return true;
        }

        private void GanDuLieu(Object.ObjDweller dweller)
        {
            dweller.DwellerName = txtDwellerName.Text;
            dweller.DwellerGender = cbbDwellerGender.Text;
            dweller.DwellerBirthday = txtDwellerBirthday.Text;
            dweller.DwellerIdCard = txtDwellerIdCard.Text;
            dweller.DwellerStatus = "1";
            dweller.DwellerStatusTitle = "Đang ở";
            dweller.TenantIdCard = txtTenantIdCard.Text;
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtDwellerName.Clear();
            cbbDwellerGender.Text = "";
            txtDwellerBirthday.Clear();
            txtDwellerIdCard.Clear();
            txtTenantIdCard.Clear();
        }

        private void AddNewDweller_Load(object sender, EventArgs e)
        {
            txtDwellerBirthday.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThemNguoiThue_Click(object sender, EventArgs e)
        {
            if (checkNullItem())
            {
                GanDuLieu(dweller);
                if (dwellerCtrl.KTNguoiThue(dweller.DwellerIdCard))
                {

                    switch (dwellerCtrl.Them(dweller))
                    {
                        case 0:
                            ThongBao("Mã người đứng tên hợp đồng không tồn tại");
                            break;
                        case 2:
                            ThongBao("Nguời đứng tên đang không sở hữu hợp đồng nào");
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                    }
                }
                else
                {
                    if (!dwellerCtrl.KTTrangThaiNguoiThue(dweller.DwellerIdCard))
                    {
                        dweller.DwellerStatus = "1";
                        dweller.DwellerStatusTitle = "Đang ở";
                        switch (dwellerCtrl.UpdateOldDweller(dweller))
                        {
                            case 1:
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LamMoi();
                                break;
                        }
                    }
                    else
                    {
                        ThongBao("Nguời thuê hiện đang ở tại một phòng khác");
                    }
                }
            }
            else
            {
                ThongBao("Vui lòng điền đầy đủ thông tin");
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

        private void btnDwellerBirthday_Click(object sender, EventArgs e)
        {
            DateTime time;
            if (txtDwellerBirthday.Text != "")
            {
                time = DateTime.Parse(txtDwellerBirthday.Text);
                mntDwellerBirthday.SelectionStart = time;
            }
            mntDwellerBirthday.Visible = true;
        }

        private void mntDwellerBirthday_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDwellerBirthday.Text = mntDwellerBirthday.SelectionStart.ToShortDateString();
            mntDwellerBirthday.Visible = false;
        }

        private void mntDwellerBirthday_MouseLeave(object sender, EventArgs e)
        {
            mntDwellerBirthday.Visible = false;
        }

        private void txtDwellerIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtTenantIdCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void ValidNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //On Progress: Auto Fill Data
        private void txtDwellerIdCard_Leave(object sender, EventArgs e)
        {
            //SqlConnection conn = ConnectDatabase.connect;
            //SqlCommand sqlcmd;
            //sqlcmd = new SqlCommand();
            //if (conn.State == ConnectionState.Closed)
            //    conn.Open();
            //sqlcmd.CommandText = "SELECT DwellerName, DwellerGender, DwellerBirthday FROM Dweller WHERE DwellerIdCard = @cmnd";
            //sqlcmd.Parameters.Add("cmnd", SqlDbType.VarChar).Value = txtDwellerIdCard.Text;
            //sqlcmd.Connection = conn;
            //SqlDataReader dataReader = sqlcmd.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    txtDwellerName.Text = dataReader.GetString(0).ToString();
            //    cbbDwellerGender.Text = dataReader.GetString(1).ToString();
            //    txtDwellerBirthday.Text = dataReader.GetDateTime(2).ToString("MM/dd/yyyy");
            //}
            //conn.Close();
        }
    }
}
