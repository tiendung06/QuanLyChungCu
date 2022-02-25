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
    public partial class QuanLyPhong : Form
    {
        public static string text = "";
        string[] optionFind = { "Mã phòng"};
        Model.RoomManage RoomManage = new Model.RoomManage();
        Controller.RoomCtrl roomCtrl = new Controller.RoomCtrl();

        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            RoomManage.HienThi(dgvDSChiTietPhong);
            HienThiThongTin();
            optionCombobox.DataSource = optionFind;
            txtRoomId.Enabled = false;
            txtRoomStatus.Enabled = false;
        }

        private void HienThiThongTin()
        {
            if (dgvDSChiTietPhong.CurrentRow != null)
            {
                txtRoomId.Text = dgvDSChiTietPhong.CurrentRow.Cells["RoomId"].Value.ToString();
                txtCost.Text = dgvDSChiTietPhong.CurrentRow.Cells["Cost"].Value.ToString();
                txtRoomFloor.Text = dgvDSChiTietPhong.CurrentRow.Cells["RoomFloor"].Value.ToString();
                txtRoomStatus.Text = dgvDSChiTietPhong.CurrentRow.Cells["RoomStatus"].Value.ToString();
            }
        }

        private void dgvDSChiTietPhong_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RoomManage.HienThi(dgvDSChiTietPhong);
            txtRoomId.Clear();
            txtCost.Clear();
            txtRoomFloor.Clear();
            txtRoomStatus.Clear();
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
                Object.ObjRoom objRoom = new Object.ObjRoom();
                SetDataRoom(objRoom);

                string RoomId = dgvDSChiTietPhong.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (roomCtrl.Update(objRoom) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RoomManage.HienThi(dgvDSChiTietPhong);
                        HienThiThongTin();
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
                string id_customer = dgvDSChiTietPhong.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (roomCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        roomCtrl.HienThi(dgvDSChiTietPhong, id_customer);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phòng này khi có người đang thuê phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool checkNullTextBox()
        {
            if (txtRoomId.Text.Trim() == "")
            {
                errRoomId.SetError(txtRoomId, "Nhập vào mã phòng");
                return false;
            }
            if (txtCost.Text.Trim() == "")
            {
                errCost.SetError(txtCost, "Nhập vào giá phòng");
                return false;
            }
            if (txtRoomFloor.Text.Trim() == "")
            {
                errRoomFloor.SetError(txtRoomFloor, "Nhập vào số tầng");
                return false;
            }          
            if (txtRoomStatus.Text.Trim() == "")
            {
                errorRoomStatus.SetError(txtRoomStatus, "Nhập vào trạng thái phòng");
                return false;
            }           
            else
            {
                errRoomId.SetError(txtRoomId, "");
                errCost.SetError(txtCost, "");
                errRoomFloor.SetError(txtRoomFloor, "");                
                errorRoomStatus.SetError(txtRoomStatus, "");               
                return true;
            }
        }

        private void SetDataRoom(Object.ObjRoom room)
        {
            room.RoomId = txtRoomId.Text;
            room.Cost = txtCost.Text;
            room.RoomFloor = txtRoomFloor.Text;
            room.RoomStatus = txtRoomStatus.Text;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewRoom addNewRoom = new AddNewRoom();
            addNewRoom.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            string option = (string)optionCombobox.SelectedItem;
            if (option == optionFind[0])
            {
                tieuchi = "RoomId";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        roomCtrl.HienThiNguoiDung(dgvDSChiTietPhong, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo mã phòng!";
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
