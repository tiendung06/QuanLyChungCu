using ComponentFactory.Krypton.Toolkit;
using QuanLyChungCu.Controller;
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
        Object.ObjContract contract = new Object.ObjContract();
        Model.ContractManage contractManage = new Model.ContractManage();
        ContractCtrl contractCtrl = new ContractCtrl();
        Object.ObjRoom room = new Object.ObjRoom();
        DwellerCtrl dwellerCtrl = new DwellerCtrl();
        DateTime currentDate = DateTime.Today;

        public QuanLyHopDong()
        {
            InitializeComponent();
        }

        private void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Visible = false;
                btnThemHopDong.Visible = false;
                btnCapNhat.Visible = false;
                btnXuatHopDong.Visible = false;
            }
            contractManage.HienThi(dgvDSChiTietHopDong);
            HienThiThongTin();
            optionCombobox.DataSource = optionFind;
            txtContractId.Enabled = false;
            txtRoomId.Enabled = false;
            txtDateStart.Enabled = false;
            txtDateEnd.Enabled = false;
            txtContractStatus.Enabled = false;
            txtTenantIdCard.Enabled = false;
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
                txtTenantIdCard.Text = dgvDSChiTietHopDong.CurrentRow.Cells["TenantIdCard"].Value.ToString();
                txtDateStart.Text = dgvDSChiTietHopDong.CurrentRow.Cells["DateStart"].Value.ToString();
                txtDateEnd.Text = dgvDSChiTietHopDong.CurrentRow.Cells["DateEnd"].Value.ToString();
                txtContractStatus.Text = dgvDSChiTietHopDong.CurrentRow.Cells["ContractStatusTitle"].Value.ToString();
            }
        }

        private void dgvDSChiTietHopDong_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnDateStart_Click(object sender, EventArgs e)
        {
            mntDateStart.MinDate = DateTime.Parse(dgvDSChiTietHopDong.CurrentRow.Cells["DateStart"].Value.ToString());
            setCalendar(txtDateStart, mntDateStart);
        }

        private void btnDateEnd_Click(object sender, EventArgs e)
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
            contractManage.HienThi(dgvDSChiTietHopDong);
            txtContractId.Clear();
            txtRoomId.Clear();
            txtTenantIdCard.Clear();
            txtDateStart.Clear();
            txtDateEnd.Clear();
            txtTimKiem.Clear();
            contractCtrl.HienThi(dgvDSChiTietHopDong);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                SetDataContract(contract);
                DateTime dateStart = DateTime.Parse(txtDateStart.Text);
                DateTime dateEnd = DateTime.Parse(txtDateEnd.Text);
                DialogResult dlg = MessageBox.Show("Bạn có muốn thay đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (calculateTime(dateStart, dateEnd) >= 30)
                    {
                        if (dwellerCtrl.KTCMNDNguoiDungTen(contract.TenantIdCard))
                        {
                            if (contractCtrl.Update(contract) > 0)
                            {
                                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                contractManage.HienThi(dgvDSChiTietHopDong);
                                HienThiThongTin();
                            }
                            else
                            {
                                ThongBao("Cập nhật không thành công!");
                            }
                        }
                        else
                        {
                            ThongBao("Mã số chứng minh nhân dân người đứng tên không tồn tại!");
                        }
                    }
                    else
                    {
                        ThongBao("Thời gian thuê tối thiểu là 30 ngày!");
                    }
                }
            }
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            View.AddNewContract addNewContract = new AddNewContract();
            addNewContract.TopLevel = false;
            panelQuanLyHopDong.Controls.Add(addNewContract);
            addNewContract.Dock = DockStyle.Fill;
            addNewContract.BringToFront();
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
                SetDataContract(contract);
                contract.ContractStatus = "0";
                contract.ContractStatusTitle = "Hết hiệu lực";
                string contractId = dgvDSChiTietHopDong.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn hủy hợp đồng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    deleteContract(contractId);
                }
            }
        }

        private void btnXuatHopDong_Click(object sender, EventArgs e)
        {
            string contractId = dgvDSChiTietHopDong.CurrentRow.Cells[0].Value.ToString();
            ExportWord export = new ExportWord();
            export.GetDataTenant(contractId);
            export.GetDataRoom(contractId);
            export.FillDataContract();
        }

        private void deleteContract(string contractId)
        {
            if (contractCtrl.Update(contract) > 0)
            {
                MessageBox.Show("Hủy hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contractCtrl.HienThi(dgvDSChiTietHopDong);
                HienThiThongTin();
            }
            else
            {
                MessageBox.Show("Không thể hủy hợp đồng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtTenantIdCard.Text.Trim() == "")
            {
                errTenantId.SetError(txtTenantIdCard, "Nhập vào mã người dùng");
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
                errTenantId.SetError(txtTenantIdCard, "");
                errDateStart.SetError(txtDateStart, "");
                errDateEnd.SetError(txtDateEnd, "");
                return true;
            }
        }

        private void SetDataContract(Object.ObjContract contract)
        {
            contract.ContractId = txtContractId.Text;
            contract.RoomId = txtRoomId.Text;
            contract.TenantIdCard = txtTenantIdCard.Text;
            contract.DateStart = txtDateStart.Text;
            contract.DateEnd = txtDateEnd.Text;
            contract.ContractStatusTitle = txtContractStatus.Text;
        }

        private void SetDataRoom(Object.ObjRoom room)
        {
            room.RoomId = txtRoomId.Text;
            room.RoomStatus = "0";
            room.RoomStatusTitle = "Phòng trống";
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
                    ThongBao("Vui lòng nhập vào một số nếu tìm kiếm theo mã hợp đồng!");
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
                    ThongBao("Vui lòng nhập vào một số nếu tìm kiếm theo mã phòng!");
                }
            }
        }

        private void removeContract()
        {
            for (int rows = 0; rows < dgvDSChiTietHopDong.Rows.Count - 1; rows++)
            {
                SetDataContract(contract);
                string time = dgvDSChiTietHopDong.Rows[rows].Cells["DateEnd"].Value.ToString();
                if (time != null)
                {
                    DateTime value = DateTime.Parse(time);
                    string contractId = dgvDSChiTietHopDong.Rows[rows].Cells["ContractId"].Value.ToString();
                    if (calculateTime(value, DateTime.Today) > 0)
                    {
                        contract.ContractStatus = "0";
                        contract.ContractStatusTitle = "Hết hiệu lực";
                        MessageBox.Show("Hợp đồng " + contractId + " đã hết hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetDataRoom(room);
                        contractCtrl.CapNhatPhong(room);
                        deleteContract(contractId);
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

        private void mntDateEnd_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateEnd.Text = mntDateEnd.SelectionStart.ToShortDateString();
            mntDateEnd.Visible = false;
        }

        private void mntDateStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateStart.Text = mntDateStart.SelectionStart.ToShortDateString();
            mntDateStart.Visible = false;
        }

        private void mntDateEnd_MouseLeave(object sender, EventArgs e)
        {
            mntDateEnd.Visible = false;
        }

        private void mntDateStart_MouseLeave(object sender, EventArgs e)
        {
            mntDateStart.Visible = false;
        }
    }
}
