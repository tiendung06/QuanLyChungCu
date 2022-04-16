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
    public partial class AddNewRoom : Form
    {
        public static string text = "";
        Controller.RoomCtrl roomCtrl = new Controller.RoomCtrl();
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private bool checkNullItem()
        {
            if (txtRoomId.Text == "" || txtCost.Text == "" || txtRoomFloor.Text == "" || txtRoomArea.Text == "")
            {
                return false;
            }
            else return true;
        }

        private void GanDuLieu(Object.ObjRoom room)
        {
            room.RoomId = txtRoomId.Text.Trim();
            room.Cost = txtCost.Text.Trim();
            room.RoomFloor = txtRoomFloor.Text.Trim();
            room.RoomArea = txtRoomArea.Text.Trim();
            room.RoomStatus = "0";
            room.RoomStatusTitle = "Phòng trống";
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtRoomId.Clear();
            txtCost.Clear();
            txtRoomFloor.Clear();
            txtRoomArea.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Object.ObjRoom room = new Object.ObjRoom();
            if (checkNullItem())
            {
                GanDuLieu(room);
                {
                    switch (roomCtrl.Them(room))
                    {
                        case 0:
                            ThongBao("Vui lòng chọn mã phòng khác!");
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

        private void txtRoomId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtRoomFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        private void txtRoomArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidNumber(e);
        }

        public void ValidNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
