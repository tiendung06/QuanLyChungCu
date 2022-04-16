using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyChungCu
{
    public partial class Login : KryptonForm
    {
        public static int resultLogin = -1;
        public static string nameLogin = "Unknown";
        public static string idCustomerLogin = "NULL";
        public static string user = "NULL";
        public static string pass = "NULL";

        //connection database
        SqlConnection connect = ConnectDatabase.connect;

        public Login()
        {
            InitializeComponent();
        }

        private void getMainControl()
        {
            MainControl mainMenu = new MainControl();
            mainMenu.TopLevel = false;
            panelMain.Controls.Add(mainMenu);
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.BringToFront();
            mainMenu.Show();
        }

        public static string getIdCustomerLogin()
        {
            //query data
            try
            {
                //string query = "SELECT Id_Customer FROM Account WHERE User_Name_Customer = '" + user + "' AND PassWord_Customer = '" + pass + "'";
                ////action get database
                //SqlConnection connect = ConnectDatabase.connect;
                //SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                //DataTable result = new DataTable();
                //sqldata.Fill(result);
                //// check database
                //idCustomerLogin = result.Rows[0]["Id_Customer"].ToString();
                //return result.Rows[0]["Id_Customer"].ToString();
                return "NULL";
            }
            catch
            {
                return "NULL";
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //query data
            user = MainControl.checkInjectionSQL(username.Text.Trim());
            pass = MainControl.checkInjectionSQL(password.Text.Trim());

            string query = "SELECT Account.AccountName, Account.Position " +
                "FROM Account " +
                "WHERE Account.Username = '" + user + "' " +
                "AND Account.Password = '" + pass + "'; ";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
                sqldata.Fill(result);
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // check database
            if (rdbAdmin.Checked)
            {
                try
                {
                    if (result.Rows[0]["Position"].ToString() == "admin")
                    {
                        nameLogin = result.Rows[0]["AccountName"].ToString();
                        resultLogin = 1;
                        getMainControl();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!\n");
                }

            }
            else
            {
                try
                {
                    if (result.Rows.Count > 0 && result.Rows[0]["Position"].ToString() != "admin")
                    {
                        nameLogin = result.Rows[0]["AccountName"].ToString();
                        resultLogin = 0;
                        getMainControl();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show(ce.Message);
                }
            }
        }
    }
}
