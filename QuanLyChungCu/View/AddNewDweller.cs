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
            dweller.DwellerName = txtDwellerName.Text.Trim();
            dweller.DwellerGender = cbbDwellerGender.Text.Trim();
            dweller.DwellerBirthday = txtDwellerBirthday.Text.Trim();
            dweller.DwellerIdCard = txtDwellerIdCard.Text.Trim();
            dweller.DwellerStatus = "1";
            dweller.DwellerStatusTitle = "Đang ở";
            dweller.TenantIdCard = txtTenantIdCard.Text.Trim();
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
    }
}
