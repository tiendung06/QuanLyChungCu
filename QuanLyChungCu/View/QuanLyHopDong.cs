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
    public partial class QuanLyHopDong : Form
    {
        public static string text = "";
        string[] optionFind = { "Mã hợp đồng", "Mã phòng" };
        Model.ContractManage ContractManage = new Model.ContractManage();
        Controller.ContractCtrl contractCtrl = new Controller.ContractCtrl();
        Object.ObjRoom room = new Object.ObjRoom();
        DateTime currentDate = DateTime.Today;

        public QuanLyHopDong()
        {
            InitializeComponent();
        }

        private void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
            }
            ContractManage.HienThi(dgvDSChiTietHopDong);
            HienThiThongTin();
            optionCombobox.DataSource = optionFind;
            txtContractId.Enabled = false;
            txtRoomId.Enabled = false;
            txtDateStart.Enabled = false;
            txtDateEnd.Enabled = false;
        }

        private void QuanLyHopDong_Shown(object sender, EventArgs e)
        {
            removeContract();
        }

        private void HienThiThongTin()
        {
            if (dgvDSChiTietHopDong.CurrentRow != null)
            {
                txtContractId.Text = dgvDSChiTietHopDong.CurrentRow.Cells["ContractId"].Value.ToString();
                txtRoomId.Text = dgvDSChiTietHopDong.CurrentRow.Cells["RoomId"].Value.ToString();
                txtCustomerId.Text = dgvDSChiTietHopDong.CurrentRow.Cells["CustomerId"].Value.ToString();
                txtDateStart.Text = dgvDSChiTietHopDong.CurrentRow.Cells["DateStart"].Value.ToString();
                txtDateEnd.Text = dgvDSChiTietHopDong.CurrentRow.Cells["DateEnd"].Value.ToString();
            }
        }

        private void dgvDSChiTietHopDong_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mntDateStart.MinDate = DateTime.Parse(dgvDSChiTietHopDong.CurrentRow.Cells["DateStart"].Value.ToString());
            setCalendar(txtDateStart, mntDateStart);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mntDateEnd.MinDate = currentDate;
            setCalendar(txtDateEnd, mntDateEnd);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ContractManage.HienThi(dgvDSChiTietHopDong);
            txtContractId.Clear();
            txtRoomId.Clear();
            txtCustomerId.Clear();
            txtDateStart.Clear();
            txtDateEnd.Clear();
            txtTimKiem.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjContract objContract = new Object.ObjContract();
                SetDataContract(objContract);
                DateTime dateStart = DateTime.Parse(txtDateStart.Text);
                DateTime dateEnd = DateTime.Parse(txtDateEnd.Text);
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (calculateTime(dateStart, dateEnd) >= 30)
                    {
                        if (contractCtrl.KiemTraNguoiDung(objContract) == 1)
                        {
                            if (contractCtrl.Update(objContract) > 0)
                            {
                                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ContractManage.HienThi(dgvDSChiTietHopDong);
                                HienThiThongTin();
                            }
                            else
                            {
                                MessageBox.Show("Mã phòng không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nguời dùng không thuộc phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thời gian thuê tối thiểu là 30 ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewContract addNewContract = new AddNewContract();
            addNewContract.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string contractId = dgvDSChiTietHopDong.CurrentRow.Cells["ContractId"].Value.ToString();
                string roomId = dgvDSChiTietHopDong.CurrentRow.Cells["RoomId"].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {                   
                    CapNhatTrangThaiPhong(room, roomId);
                    {
                        switch (contractCtrl.CapNhatPhong(room))
                        {
                            case 1:
                                break;
                        }
                    }
                    deleteContract(contractId, roomId);
                    MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void deleteContract(string contractId, string roomId)
        {
            //delete in table customer detail
            if (contractCtrl.Xoa(contractId) != -9999)
            {               
                if (contractCtrl.XoaNguoiDung(roomId) != -9999)
                {
                    contractCtrl.HienThi(dgvDSChiTietHopDong, contractId);
                    HienThiThongTin();
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa hợp đồng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkNullTextBox()
        {
            if (txtContractId.Text.Trim() == "")
            {
                errContractId.SetError(txtContractId, "Nhập vào mã hợp đồng");
                return false;
            }
            if (txtRoomId.Text.Trim() == "")
            {
                errRoomId.SetError(txtRoomId, "Nhập vào mã phòng");
                return false;
            }
            if (txtCustomerId.Text.Trim() == "")
            {
                errCustomerId.SetError(txtCustomerId, "Nhập vào mã người dùng");
                return false;
            }
            if (txtDateStart.Text.Trim() == "")
            {
                errDateStart.SetError(txtDateStart, "Nhập vào ngày bắt đầu");
                return false;
            }
            if (txtDateEnd.Text.Trim() == "")
            {
                errDateEnd.SetError(txtDateEnd, "Nhập vào ngày kết thúc");
                return false;
            }
            else
            {
                errContractId.SetError(txtContractId, "");
                errRoomId.SetError(txtRoomId, "");
                errCustomerId.SetError(txtCustomerId, "");
                errDateStart.SetError(txtDateStart, "");
                errDateEnd.SetError(txtDateEnd, "");
                return true;
            }
        }

        private void SetDataContract(Object.ObjContract contract)
        {
            contract.ContractId = txtContractId.Text;
            contract.RoomId = txtRoomId.Text;
            contract.CustomerId = txtCustomerId.Text;
            contract.DateStart = txtDateStart.Text;
            contract.DateEnd = txtDateEnd.Text;
        }

        private void CapNhatTrangThaiPhong(Object.ObjRoom room, string roomId)
        {
            room.RoomId = roomId;
            room.RoomStatus = "Còn trống";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string option = (string)optionCombobox.SelectedItem;
            if (option == optionFind[0])
            {
                string tieuchi = "ContractId";
                if (int.TryParse(txtTimKiem.Text.Trim(), out _))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        contractCtrl.HienThiNguoiDung(dgvDSChiTietHopDong, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo mã hợp đồng!";
                    ThongBao(text);
                }
            }
            else
            {
                string tieuchi = "RoomId";
                if (int.TryParse(txtTimKiem.Text.Trim(), out _))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        contractCtrl.HienThiNguoiDung(dgvDSChiTietHopDong, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo mã phòng!";
                    ThongBao(text);
                }
            }
        }

        private void removeContract()
        {
            for (int rows = 0; rows < dgvDSChiTietHopDong.Rows.Count - 1; rows++)
            {
                string time = dgvDSChiTietHopDong.Rows[rows].Cells["DateEnd"].Value.ToString();
                if (time != null)
                {
                    DateTime value = DateTime.Parse(time);
                    string contractId = dgvDSChiTietHopDong.Rows[rows].Cells["ContractId"].Value.ToString();
                    string roomId = dgvDSChiTietHopDong.Rows[rows].Cells["RoomId"].Value.ToString();
                    if (calculateTime(value, DateTime.Today) > 0)
                    {
                        MessageBox.Show("Hợp đồng " + contractId + " đã hết hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CapNhatTrangThaiPhong(room, roomId);
                        {
                            switch (contractCtrl.CapNhatPhong(room))
                            {
                                case 1:
                                    break;
                            }
                        }
                        deleteContract(contractId, roomId);
                    }
                }
            }
        }

        private int calculateTime(DateTime dateStart, DateTime dateEnd)
        {
            TimeSpan time = dateEnd - dateStart;
            int soNgay = time.Days;
            return soNgay;
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mntNgayBatDau_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateStart.Text = mntDateStart.SelectionStart.ToShortDateString();
            mntDateStart.Visible = false;
        }

        private void mntNgayBatDau_MouseLeave(object sender, EventArgs e)
        {
            mntDateStart.Visible = false;
        }

        private void mntNgayKetThuc_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateEnd.Text = mntDateEnd.SelectionStart.ToShortDateString();
            mntDateEnd.Visible = false;
        }

        private void mntNgayKetThuc_MouseLeave(object sender, EventArgs e)
        {
            mntDateEnd.Visible = false;
        }

    }
}
