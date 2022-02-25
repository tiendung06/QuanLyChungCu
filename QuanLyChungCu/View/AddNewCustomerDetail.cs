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
    public partial class AddNewCustomerDetail : Form
    {
        public static string text = "";
        Controller.CustomerDetailCtrl customerDetailCtrl = new Controller.CustomerDetailCtrl();
        public AddNewCustomerDetail()
        {
            InitializeComponent();
        }

        private bool checkNullItem()
        {
            if (txtCustomerId.Text == " " || txtNameCustomer.Text == "" || txtEmailCustomer.Text == "" || cbbGioiTinh.Text == "" || txtBirthdayCustomer.Text == "" || txtIdentityCustomer.Text == "" || txtRoomId.Text == "")
            {
                return false;
            }
            else return true;
        }          

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjCustomerDetail customerDetail)
        {
            customerDetail.CustomerId = txtCustomerId.Text.Trim();
            customerDetail.CustomerName = txtNameCustomer.Text.Trim();
            customerDetail.CustomerEmail = txtEmailCustomer.Text.Trim();
            customerDetail.CustomerGender = cbbGioiTinh.Text.Trim();
            customerDetail.CustomerBirthday = txtBirthdayCustomer.Text.Trim();
            customerDetail.CustomerIdentityCard = txtIdentityCustomer.Text.Trim();
            customerDetail.RoomId = txtRoomId.Text.Trim();
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtCustomerId.Clear();
            txtNameCustomer.Clear();
            txtEmailCustomer.Clear();
            cbbGioiTinh.Text = "";
            txtBirthdayCustomer.Clear();
            txtIdentityCustomer.Clear();
            txtRoomId.Clear();
        }

        private void cbbGrender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void AddNewCustomerDetail_Load(object sender, EventArgs e)
        {
            txtBirthdayCustomer.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtNameCustomer.Clear();
            txtEmailCustomer.Clear();
            cbbGioiTinh.Text = "";
            txtBirthdayCustomer.Clear();
            txtIdentityCustomer.Clear();
            txtRoomId.Clear();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            Object.ObjCustomerDetail customerDetail = new Object.ObjCustomerDetail();
            if (checkNullItem())
            {
                GanDuLieu(customerDetail);
                {
                    switch (customerDetailCtrl.Them(customerDetail))
                    {
                        case 0:
                            text = "Vui lòng chọn mã người dùng khác!";
                            ThongBao(text);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                        case 2:
                            text = "Vui lòng chọn mã phòng khác!";
                            ThongBao(text);
                            break;
                        case 3:
                            text = "Phòng chưa được tạo hợp đồng";
                            ThongBao(text);
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

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthdayCustomer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mntNgaySinh.Visible = true;
        }

        private void cbbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentityCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRoomId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
