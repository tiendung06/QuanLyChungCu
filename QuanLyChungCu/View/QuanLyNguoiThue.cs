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
    public partial class QuanLyNguoiThue : Form
    {
        public static string text = "";
        string[] optionFind = { "Mã người dùng", "Tên người dùng" };
        Model.DwellerManage DwellerManage = new Model.DwellerManage();
        Controller.DwellerCtrl dwellerCtrl = new Controller.DwellerCtrl();
        Object.ObjDweller dweller = new Object.ObjDweller();

        public QuanLyNguoiThue()
        {
            InitializeComponent();
        }

        private void QuanLyKhachO_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemNguoiThue.Enabled = false;
            }
            DwellerManage.HienThi(dgvDSChiTietNguoiThue);
            HienThiThongTin();
            optionCombobox.DataSource = optionFind;
            txtDwellerId.Enabled = false;
            txtDwellerBirthday.Enabled = false;
            txtRoomId.Enabled = false;
        }

        private void HienThiThongTin()
        {
            if (dgvDSChiTietNguoiThue.CurrentRow != null)
            {
                txtDwellerId.Text = dgvDSChiTietNguoiThue.CurrentRow.Cells["DwellerId"].Value.ToString();
                txtDwellerName.Text = dgvDSChiTietNguoiThue.CurrentRow.Cells["DwellerName"].Value.ToString();
                cbbDwellerGender.Text = dgvDSChiTietNguoiThue.CurrentRow.Cells["DwellerGender"].Value.ToString();
                txtDwellerBirthday.Text = dgvDSChiTietNguoiThue.CurrentRow.Cells["DwellerBirthday"].Value.ToString();
                txtDwellerIdCard.Text = dgvDSChiTietNguoiThue.CurrentRow.Cells["DwellerIdCard"].Value.ToString();
                txtRoomId.Text = dgvDSChiTietNguoiThue.CurrentRow.Cells["RoomId"].Value.ToString();
            }
        }

        private void dgvDSChiTietNguoiThue_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DwellerManage.HienThi(dgvDSChiTietNguoiThue);
            txtDwellerId.Clear();
            txtDwellerName.Clear();

            cbbDwellerGender.Text = "";
            txtDwellerBirthday.Clear();
            txtDwellerIdCard.Clear();
            txtRoomId.Clear();
            txtTimKiem.Clear();
        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDwellerBirthday.Text = mntDwellerBirthday.SelectionStart.ToShortDateString();
            mntDwellerBirthday.Visible = false;
        }

        private void mntNgaySinh_MouseLeave(object sender, EventArgs e)
        {
            mntDwellerBirthday.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time;
            if (txtDwellerBirthday.Text != "")
            {
                time = DateTime.Parse(txtDwellerBirthday.Text);
                mntDwellerBirthday.SelectionStart = time;
                mntDwellerBirthday.MaxDate = DateTime.Now;
            }
            else
            {
                time = DateTime.Now;
                mntDwellerBirthday.MaxDate = DateTime.Parse("12/31/9998");
                mntDwellerBirthday.SelectionStart = time;
            }
            mntDwellerBirthday.Visible = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                SetDataDweller(dweller);
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn thay đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    switch (dwellerCtrl.Update(dweller))
                    {
                        case 1:
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DwellerManage.HienThi(dgvDSChiTietNguoiThue);
                            HienThiThongTin();
                            break;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                SetDataDweller(dweller);
                dweller.DwellerStatus = "0";
                dweller.DwellerStatusTitle = "Không còn ở";
                string id_customer = dgvDSChiTietNguoiThue.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (dwellerCtrl.Xoa(dweller) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dwellerCtrl.HienThi(dgvDSChiTietNguoiThue, id_customer);
                        HienThiThongTin();
                    }
                    else
                    {
                        ThongBao("Không thể xóa thông tin người thuê này");
                    }
                }
            }
        }
        private bool checkNullTextBox()
        {
            if (txtDwellerId.Text.Trim() == "")
            {
                errDwellerId.SetError(txtDwellerId, "Nhập vào mã người thuê");
                return false;
            }
            if (txtDwellerName.Text.Trim() == "")
            {
                errDwellerName.SetError(txtDwellerName, "Nhập vào tên người thuê");
                return false;
            }

            if (cbbDwellerGender.Text.Trim() == "")
            {
                errGender.SetError(cbbDwellerGender, "Nhập vào giới tính người thuê");
                return false;
            }
            if (txtDwellerBirthday.Text.Trim() == "")
            {
                errDwellerBirthday.SetError(txtDwellerBirthday, "Nhập vào ngày sinh người thuê");
                return false;
            }
            if (txtDwellerIdCard.Text.Trim() == "")
            {
                errDwellerIdCard.SetError(txtDwellerIdCard, "Nhập vào chứng minh thư người dùng");
                return false;
            }
            if (txtRoomId.Text.Trim() == "")
            {
                errRoomId.SetError(txtDwellerIdCard, "Nhập vào mã phòng");
                return false;
            }
            else
            {
                errDwellerId.SetError(txtDwellerId, "");
                errDwellerName.SetError(txtDwellerName, "");
                errGender.SetError(cbbDwellerGender, "");
                errDwellerBirthday.SetError(txtDwellerBirthday, "");
                errDwellerIdCard.SetError(txtDwellerIdCard, "");
                errRoomId.SetError(txtRoomId, "");
                return true;
            }
        }

        private void SetDataDweller(Object.ObjDweller dweller)
        {
            dweller.DwellerId = txtDwellerId.Text;
            dweller.DwellerName = txtDwellerName.Text;
            dweller.DwellerGender = cbbDwellerGender.Text;
            dweller.DwellerBirthday = txtDwellerBirthday.Text;
            dweller.DwellerIdCard = txtDwellerIdCard.Text;
            dweller.DwellerStatus = "1";
            dweller.DwellerStatusTitle = "Đang ở";
        }

        private void btnThemNguoiThue_Click(object sender, EventArgs e)
        {
            View.AddNewDweller addNewCustomerDetail = new AddNewDweller();
            addNewCustomerDetail.TopLevel = false;
            this.Controls.Add(addNewCustomerDetail);
            addNewCustomerDetail.Dock = DockStyle.Fill;
            addNewCustomerDetail.BringToFront();
            addNewCustomerDetail.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            string option = (string)optionCombobox.SelectedItem;
            if (option == optionFind[1])
            {
                tieuchi = "DwellerName";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    dwellerCtrl.HienThiNguoiDung(dgvDSChiTietNguoiThue, txtTimKiem.Text, tieuchi);
                }
            }
            else
            {
                tieuchi = "DwellerId";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        dwellerCtrl.HienThiNguoiDung(dgvDSChiTietNguoiThue, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    ThongBao("Vui lòng nhập vào một số nếu tìm kiếm theo mã người thuê!");
                }
            }
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
