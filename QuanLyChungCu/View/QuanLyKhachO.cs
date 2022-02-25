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
    public partial class QuanLyKhachO : Form
    {
        public static string text = "";
        string[] optionFind = { "Mã người dùng", "Tên người dùng" };
        Model.CustomerManage CustomerManage = new Model.CustomerManage();
        Controller.CustomerDetailCtrl cutomerDetailCtrl = new Controller.CustomerDetailCtrl();

        public QuanLyKhachO()
        {
            InitializeComponent();
        }

        private void QuanLyKhachO_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            CustomerManage.HienThi(dgvDSChiTietNguoiO);
            HienThiThongTin();
            optionCombobox.DataSource = optionFind;
            txtId_Customer.Enabled = false;
            txtBirthday_Customer.Enabled = false;
        }

        private void HienThiThongTin()
        {
            if (dgvDSChiTietNguoiO.CurrentRow != null)
            {
                txtId_Customer.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["CustomerId"].Value.ToString();
                txtName_Customer.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtEmail_Customer.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["CustomerEmail"].Value.ToString();
                cbbGioiTinh.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["CustomerGender"].Value.ToString();
                txtBirthday_Customer.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["CustomerBirthday"].Value.ToString();
                txtIdentity_Customer.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["CustomerIdentityCard"].Value.ToString();
                txtId_Room.Text = dgvDSChiTietNguoiO.CurrentRow.Cells["RoomId"].Value.ToString();
            }
        }

        private void dgvDSChiTietNguoiO_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CustomerManage.HienThi(dgvDSChiTietNguoiO);
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtEmail_Customer.Clear();
            cbbGioiTinh.Text = "";
            txtBirthday_Customer.Clear();
            txtIdentity_Customer.Clear();
            txtId_Room.Clear();
            txtTimKiem.Clear();
        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mntNgaySinh.Visible = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjCustomerDetail objCustoDetail = new Object.ObjCustomerDetail();
                SetDataCustomerDetail(objCustoDetail);

                string Id_Customer = dgvDSChiTietNguoiO.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (cutomerDetailCtrl.Update(objCustoDetail) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustomerManage.HienThi(dgvDSChiTietNguoiO);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Mã phòng không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string id_customer = dgvDSChiTietNguoiO.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (cutomerDetailCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cutomerDetailCtrl.HienThi(dgvDSChiTietNguoiO, id_customer);
                        HienThiThongTin();                  
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool checkNullTextBox()
        {
            if (txtId_Customer.Text.Trim() == "")
            {
                errId_Customer.SetError(txtId_Customer, "Nhập vào mã người dùng");
                return false;
            }
            if (txtName_Customer.Text.Trim() == "")
            {
                errName.SetError(txtName_Customer, "Nhập vào tên người dùng");
                return false;
            }
            if (txtEmail_Customer.Text.Trim() == "")
            {
                errEmail_Customer.SetError(txtEmail_Customer, "Nhập vào email người dùng");
                return false;
            }
            if (cbbGioiTinh.Text.Trim() == "")
            {
                errorGender.SetError(cbbGioiTinh, "Nhập vào giới tính người dùng");
                return false;
            }
            if (txtBirthday_Customer.Text.Trim() == "")
            {
                errorBirthday_Customer.SetError(txtBirthday_Customer, "Nhập vào ngày sinh người dùng");
                return false;
            }
            if (txtIdentity_Customer.Text.Trim() == "")
            {
                errorIdentity_Card.SetError(txtIdentity_Customer, "Nhập vào chứng minh thư người dùng");
                return false;
            }
            if (txtIdentity_Customer.Text.Trim() == "")
            {
                errorId_Room.SetError(txtIdentity_Customer, "Nhập vào mã phòng");
                return false;
            }
            else
            {
                errId_Customer.SetError(txtId_Customer, "");
                errName.SetError(txtName_Customer, "");
                errEmail_Customer.SetError(txtEmail_Customer, "");
                errorGender.SetError(cbbGioiTinh, "");
                errorBirthday_Customer.SetError(txtBirthday_Customer, "");
                errorIdentity_Card.SetError(txtIdentity_Customer, "");
                errorId_Room.SetError(txtId_Room, "");
                return true;
            }
        }
        private void SetDataCustomerDetail(Object.ObjCustomerDetail customerDetail)
        {
            customerDetail.CustomerId = txtId_Customer.Text;
            customerDetail.CustomerName = txtName_Customer.Text;
            customerDetail.CustomerEmail = txtEmail_Customer.Text;
            customerDetail.CustomerGender = cbbGioiTinh.Text;
            customerDetail.CustomerBirthday = txtBirthday_Customer.Text;
            customerDetail.CustomerIdentityCard = txtIdentity_Customer.Text;
            customerDetail.RoomId = txtId_Room.Text;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewCustomerDetail addNewCustomerDetail = new AddNewCustomerDetail();
            addNewCustomerDetail.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            string option = (string)optionCombobox.SelectedItem;
            if (option == optionFind[1])
            {
                tieuchi = "CustomerName";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    cutomerDetailCtrl.HienThiNguoiDung(dgvDSChiTietNguoiO, txtTimKiem.Text, tieuchi);
                }
            }
            else
            {
                tieuchi = "CustomerId";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        cutomerDetailCtrl.HienThiNguoiDung(dgvDSChiTietNguoiO, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo mã người ở!";
                    ThongBao(text);
                }
            }
        }
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
