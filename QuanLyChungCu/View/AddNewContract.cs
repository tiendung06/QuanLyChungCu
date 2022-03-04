using ComponentFactory.Krypton.Toolkit;
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
    public partial class AddNewContract : Form
    {
        public static string text = "";
        Controller.ContractCtrl contractCtrl = new Controller.ContractCtrl();
        Model.ContractManage contractMng = new Model.ContractManage();
        Object.ObjContract contract = new Object.ObjContract();
        Object.ObjCustomerDetail customer = new Object.ObjCustomerDetail();
        Object.ObjRoom room = new Object.ObjRoom();

        public AddNewContract()
        {
            InitializeComponent();
        }

        private void AddNewContract_Load(object sender, EventArgs e)
        {
            txtBirthdayCustomer.Enabled = false;
            txtDateStart.Enabled = false;
            txtDateEnd.Enabled = false;
            button3.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (checkNullItem())
            {
                GanDuLieu(contract, customer);
                CapNhatTrangThaiPhong(room);
                int resultCustomer = contractCtrl.ThemNguoiDung(customer);
                int resultContract = contractCtrl.ThemHopDong(contract);
                DateTime dateStart = DateTime.Parse(txtDateStart.Text);
                DateTime dateEnd = DateTime.Parse(txtDateEnd.Text);
                int resultDate = DateTime.Compare(dateStart, dateEnd);
                if (resultCustomer == 0 || resultContract == 0 || resultContract == 2 || resultDate >= 0)
                {
                    if (resultCustomer == 0)
                    {
                        text = "Vui lòng chọn mã người dùng khác!";
                        ThongBao(text);
                        return;
                    }

                    if (resultContract == 0)
                    {
                        text = "Vui lòng chọn mã phòng khác!";
                        ThongBao(text);
                        return;
                    }
                    else if (resultContract == 2)
                    {
                        text = "Phòng đã được thuê, vui lòng chọn mã phòng khác!";
                        ThongBao(text);
                        return;
                    }

                    if (resultDate >= 0)
                    {
                        text = "Vui lòng chọn ngày hết hạn lớn hơn ngày đăng ký!";
                        ThongBao(text);
                        return;
                    }
                }
                else
                {
                    contractMng.SaveCustomer(customer);
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
            if (txtCustomerId.Text == " " || txtNameCustomer.Text == "" || txtEmailCustomer.Text == "" ||
                cbbGioiTinh.Text == "" || txtBirthdayCustomer.Text == "" || txtIdentityCustomer.Text == "" ||
                txtRoomId.Text == "" || txtDateStart.Text == "" || txtDateEnd.Text == "")
            {
                return false;
            }
            return true;
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjContract contract, Object.ObjCustomerDetail customer)
        {
            customer.CustomerId = txtCustomerId.Text.Trim();
            customer.CustomerName = txtNameCustomer.Text.Trim();
            customer.CustomerEmail = txtEmailCustomer.Text.Trim();
            customer.CustomerGender = cbbGioiTinh.Text.Trim();
            customer.CustomerBirthday = txtBirthdayCustomer.Text.Trim();
            customer.CustomerIdentityCard = txtIdentityCustomer.Text.Trim();
            customer.RoomId = txtRoomId.Text.Trim();

            contract.RoomId = txtRoomId.Text.Trim();
            contract.DateStart = txtDateStart.Text.Trim();
            contract.DateEnd = txtDateEnd.Text.Trim();
            contract.CustomerId = txtCustomerId.Text.Trim();
        }

        private void CapNhatTrangThaiPhong(Object.ObjRoom room)
        {
            room.RoomId = txtRoomId.Text.Trim();
            room.RoomStatus = "Đã được thuê";
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
            txtDateStart.Clear();
            txtDateEnd.Clear();
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setCalendar(txtBirthdayCustomer, mntNgaySinh);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mntDateStart.MinDate = DateTime.Today;
            setCalendar(txtDateStart, mntDateStart);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void setCalendar(KryptonTextBox textBox, MonthCalendar monthCalendar)
        {
            if (textBox.Text != "")
            {
                DateTime time = DateTime.Parse(textBox.Text);
                monthCalendar.SelectionStart = time;
            }
            monthCalendar.Visible = true;
        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthdayCustomer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }

        private void mntNgaySinh_MouseLeave(object sender, EventArgs e)
        {
            mntNgaySinh.Visible = false;
        }

        private void mntDateStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateStart.Text = mntDateStart.SelectionStart.ToShortDateString();
            mntDateStart.Visible = false;
            button3.Enabled = true;
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

        private void txtCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

    }
}
