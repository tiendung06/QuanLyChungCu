using QuanLyChungCu.View;
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
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyChungCu
{
    public partial class MainControl : KryptonForm
    {
        public MainControl()
        {
            InitializeComponent();
            lblNameUser.Text = Login.nameLogin;
            this.lblNameUser.Left = (this.lblNameUser.Parent.Width - this.lblNameUser.Width) / 2;
            home();
            if (Login.resultLogin != 1)
            {               
                btnQLNhomNguoiDung.Enabled = false;            
                btnQLThanhLy.Enabled = false;
                btnThongKeTB.Enabled = false;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //set form
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);                
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["QuanLyPhong"] == null)
                btnQLPhong.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyKhachO"] == null)
                btnQLKhachO.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyHopDong"] == null)
                btnQLHopDong.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyTaiKhoan"] == null)
                btnQLTaiKhoan.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyNguoiDung"] == null)
                btnQLNguoiDung.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyNhomNguoiDung"] == null)
                btnQLNhomNguoiDung.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyThietBi"] == null)
                btnQLThanhLy.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyMuonTra"] == null)
                btnQLMuonTra.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyThanhLy"] == null)
                btnQLThanhLy.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyThongKe"] == null)
                btnThongKeTB.BackColor = Color.FromArgb(250, 255, 252);
            if (Application.OpenForms["QuanLyLoaiThietBi"] == null)
                btnQLLoaiTB.BackColor = Color.FromArgb(250, 255, 252);
        }

        //reset color for button
        private void resetColorForButton()
        {
            btnHome.BackColor = Color.FromArgb(250, 255, 252);
            btnHome.ForeColor = Color.FromArgb(103, 102, 105);
            btnHome.IconColor = Color.FromArgb(103, 102, 105);

            btnQLPhong.BackColor = Color.FromArgb(250, 255, 252);
            btnQLPhong.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLPhong.IconColor = Color.FromArgb(103, 102, 105);

            btnQLKhachO.BackColor = Color.FromArgb(250, 255, 252);
            btnQLKhachO.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLKhachO.IconColor = Color.FromArgb(103, 102, 105);

            btnQLHopDong.BackColor = Color.FromArgb(250, 255, 252);
            btnQLHopDong.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLHopDong.IconColor = Color.FromArgb(103, 102, 105);

            btnQLTaiKhoan.BackColor = Color.FromArgb(250, 255, 252);
            btnQLTaiKhoan.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLTaiKhoan.IconColor = Color.FromArgb(103, 102, 105);

            btnQLNguoiDung.BackColor = Color.FromArgb(250, 255, 252);
            btnQLNguoiDung.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLNguoiDung.IconColor = Color.FromArgb(103, 102, 105);

            btnQLNhomNguoiDung.BackColor = Color.FromArgb(250, 255, 252);
            btnQLNhomNguoiDung.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLNhomNguoiDung.IconColor = Color.FromArgb(103, 102, 105);

            btnQLThietBi.BackColor = Color.FromArgb(250, 255, 252);
            btnQLThietBi.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLThietBi.IconColor = Color.FromArgb(103, 102, 105);

            btnQLMuonTra.BackColor = Color.FromArgb(250, 255, 252);
            btnQLMuonTra.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLMuonTra.IconColor = Color.FromArgb(103, 102, 105);

            btnQLThanhLy.BackColor = Color.FromArgb(250, 255, 252);
            btnQLThanhLy.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLThanhLy.IconColor = Color.FromArgb(103, 102, 105);

            btnThongKeTB.BackColor = Color.FromArgb(250, 255, 252);
            btnThongKeTB.ForeColor = Color.FromArgb(103, 102, 105);
            btnThongKeTB.IconColor = Color.FromArgb(103, 102, 105);

            btnQLLoaiTB.BackColor = Color.FromArgb(250, 255, 252);
            btnQLLoaiTB.ForeColor = Color.FromArgb(103, 102, 105);
            btnQLLoaiTB.IconColor = Color.FromArgb(103, 102, 105);
        }

        private void home()
        {
            resetColorForButton();
            AbrirFormulario<Default>();
            btnHome.BackColor = Color.FromArgb(8, 142, 254);
            btnHome.ForeColor = Color.FromArgb(250, 255, 252);
            btnHome.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home();
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<QuanLyPhong>();
            btnQLPhong.BackColor = Color.FromArgb(8, 142, 254);
            btnQLPhong.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLPhong.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLKhachO_Click(object sender, EventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<QuanLyKhachO>();
            btnQLKhachO.BackColor = Color.FromArgb(8, 142, 254);
            btnQLKhachO.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLKhachO.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            //form quan ly tai khoan
            resetColorForButton();
            AbrirFormulario<QuanLyTaiKhoan>();
            btnQLTaiKhoan.BackColor = Color.FromArgb(8, 142, 254);
            btnQLTaiKhoan.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLTaiKhoan.IconColor = Color.FromArgb(250, 255, 252);
        }

        public static bool onLoadCheckAccLogin()
        {
            //query data
            try
            {
                string query = "SELECT * FROM Account WHERE CustomerId = " + Login.getIdCustomerLogin() + "";
                //action get database
                SqlConnection connect = ConnectDatabase.connect;
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                DataTable result = new DataTable();
                sqldata.Fill(result);
                // check database
                if (result.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                return false;
            }
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            //form quan ly nguoi dung
            resetColorForButton();
            AbrirFormulario<QuanLyNguoiDung>();
            btnQLNguoiDung.BackColor = Color.FromArgb(8, 142, 254);
            btnQLNguoiDung.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLNguoiDung.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLNhomNguoiDung_Click(object sender, EventArgs e)
        {
            //form quan ly nhom nguoi dung
            resetColorForButton();
            AbrirFormulario<QLNhomNguoiDungcs>();
            btnQLNhomNguoiDung.BackColor = Color.FromArgb(8, 142, 254);
            btnQLNhomNguoiDung.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLNhomNguoiDung.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLThietBi_Click(object sender, EventArgs e)
        {
            //form quan ly thiet bi
            resetColorForButton();
            AbrirFormulario<QuanLyThietBi>();
            btnQLThietBi.BackColor = Color.FromArgb(8, 142, 254);
            btnQLThietBi.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLThietBi.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLMuonTra_Click(object sender, EventArgs e)
        {
            //form quan ly muon tra
            resetColorForButton();
            AbrirFormulario<QLMuonTra>();
            btnQLMuonTra.BackColor = Color.FromArgb(8, 142, 254);
            btnQLMuonTra.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLMuonTra.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLThanhLy_Click(object sender, EventArgs e)
        {
            //form quan ly thanh ly
            resetColorForButton();
            AbrirFormulario<QLThanhLyTB>();
            btnQLThanhLy.BackColor = Color.FromArgb(8, 142, 254);
            btnQLThanhLy.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLThanhLy.IconColor = Color.FromArgb(250, 255, 252);
        }


        private void btnThongKeTB_Click(object sender, EventArgs e)
        {
            //form thong ke
            resetColorForButton();
            AbrirFormulario<QLThongKe>();
            btnThongKeTB.BackColor = Color.FromArgb(8, 142, 254);
            btnThongKeTB.ForeColor = Color.FromArgb(250, 255, 252);
            btnThongKeTB.IconColor = Color.FromArgb(250, 255, 252);
        }

        private void btnQLLoaiTB_Click(object sender, EventArgs e)
        {
            //form thong ke
            resetColorForButton();
            AbrirFormulario<QLLoaiTB>();
            btnQLLoaiTB.BackColor = Color.FromArgb(8, 142, 254);
            btnQLLoaiTB.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLLoaiTB.IconColor = Color.FromArgb(250, 255, 252);
        }

        public static string checkInjectionSQL(string value)
        {
            return value.Replace("\'", "NULL").Replace("=", "NULL");
        }

        private void btnQLHopDong_Click(object sender, EventArgs e)
        {
            //form hop dong
            resetColorForButton();
            AbrirFormulario<QuanLyHopDong>();
            btnQLHopDong.BackColor = Color.FromArgb(8, 142, 254);
            btnQLHopDong.ForeColor = Color.FromArgb(250, 255, 252);
            btnQLHopDong.IconColor = Color.FromArgb(250, 255, 252);
        }
    }
}
