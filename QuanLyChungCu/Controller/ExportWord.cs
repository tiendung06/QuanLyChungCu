using Aspose.Words;
using QuanLyChungCu.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ThuVienWinform.Report.AsposeWordExtension;

namespace QuanLyChungCu.Controller
{
    public class ExportWord
    {
        SqlConnection conn = ConnectDatabase.connect;
        string hoTen, ngaySinh, cmnd, sdt, soTaiKhoan, nganHang, email, maPhong, tang, dienTich, giaTien, ngayBatDau, ngayKetThuc;
        string ngayThanhToan, maHoaDon, maKhachHang;
        public void GetDataTenant(string id)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT DwellerName, DwellerBirthday, Tenant.TenantIdCard, TenantPhoneNumber, " +
                "Tenant.CreditNumber, Bank, TenantEmail " +
                "From Dweller LEFT JOIN Tenant ON Dweller.DwellerIdCard = Tenant.TenantIdCard INNER join Contract " +
                "ON Tenant.TenantIdCard = Contract.TenantIdCard " +
                "Where ContractId = @id";
            sqlcmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            sqlcmd.Connection = conn;
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                hoTen = dataReader.GetString(0).ToString();
                ngaySinh = dataReader.GetDateTime(1).ToString("dd/MM/yyyy");
                cmnd = dataReader.GetString(2).ToString();
                sdt = dataReader.GetString(3).ToString();
                soTaiKhoan = dataReader.GetString(4).ToString();
                nganHang = dataReader.GetString(5).ToString();
                email = dataReader.GetString(6).ToString();
            }
            conn.Close();
        }

        public void GetDataRoom(string id)
        {
            conn.Open();
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT Room.RoomId, Room.RoomFloor, Room.RoomArea, Room.Cost, Contract.DateStart, Contract.DateEnd " +
                "FROM Room LEFT JOIN Contract on Contract.RoomId = Room.RoomId " +
                "Where ContractId = @id";
            sqlcmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            sqlcmd.Connection = conn;
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                maPhong = dataReader.GetInt32(0).ToString();
                tang = dataReader.GetInt32(1).ToString();
                dienTich = dataReader.GetDouble(2).ToString();
                giaTien = dataReader.GetDouble(3).ToString();
                ngayBatDau = dataReader.GetDateTime(4).ToString("dd/MM/yyyy");
                ngayKetThuc = dataReader.GetDateTime(5).ToString("dd/MM/yyyy");
            }
            conn.Close();
        }

        public void GetDataBill(string id)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "SELECT Rent.SettlementDay, Rent.RentId, Dweller.DwellerName, Dweller.DwellerId, Contract.RoomId, Room.Cost " +
            "FROM Rent INNER JOIN Contract ON Rent.ContractId = Contract.ContractId " +
            "INNER JOIN Tenant ON Tenant.TenantIdCard = Contract.TenantIdCard " +
            "INNER JOIN Dweller on Dweller.DwellerIdCard = Tenant.TenantIdCard " +
            "INNER JOIN Room ON Room.RoomId = Contract.RoomId " +
            "WHERE RentId = @rentId";
            sqlcmd.Parameters.Add("rentId", SqlDbType.NVarChar).Value = id;
            sqlcmd.Connection = conn;
            SqlDataReader dataReader = sqlcmd.ExecuteReader();
            while (dataReader.Read())
            {
                ngayThanhToan = dataReader.GetDateTime(0).ToString("MM/dd/yyyy");
                maHoaDon = dataReader.GetString(1).ToString();
                hoTen = dataReader.GetString(2).ToString();
                maKhachHang = dataReader.GetInt32(3).ToString();
                maPhong = dataReader.GetInt32(4).ToString();
                giaTien = dataReader.GetDouble(5).ToString();
            }
            conn.Close();
        }

        public void FillDataContract()
        {
            Document doc = new Document("Template//HopDongThueNha.doc");
            doc.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { hoTen });
            doc.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { ngaySinh });
            doc.MailMerge.Execute(new[] { "CMND" }, new[] { cmnd });
            doc.MailMerge.Execute(new[] { "SDT" }, new[] { sdt });
            doc.MailMerge.Execute(new[] { "So_Tai_Khoan" }, new[] { soTaiKhoan });
            doc.MailMerge.Execute(new[] { "Ngan_Hang" }, new[] { nganHang });
            doc.MailMerge.Execute(new[] { "Email" }, new[] { email });
            doc.MailMerge.Execute(new[] { "Ma_Phong" }, new[] { maPhong });
            doc.MailMerge.Execute(new[] { "Tang" }, new[] { tang });
            doc.MailMerge.Execute(new[] { "Dien_Tich" }, new[] { dienTich });
            doc.MailMerge.Execute(new[] { "Gia_Tien" }, new[] { giaTien });
            doc.MailMerge.Execute(new[] { "Ngay_Bat_Dau" }, new[] { ngayBatDau });
            doc.MailMerge.Execute(new[] { "Ngay_Ket_Thuc" }, new[] { ngayKetThuc });
            doc.SaveAndOpenFile("HopDong.docx");
        }

        public void FillDataBill()
        {
            DateTime dateTime = DateTime.Parse(ngayThanhToan);
            string ngay = dateTime.Day.ToString();
            string thang = dateTime.Month.ToString();
            string nam = dateTime.Year.ToString();
            Document doc = new Document("Template//HoaDon.doc");
            doc.MailMerge.Execute(new[] { "Ngay" }, new[] { ngay });
            doc.MailMerge.Execute(new[] { "Thang" }, new[] { thang });
            doc.MailMerge.Execute(new[] { "Nam" }, new[] { nam });
            doc.MailMerge.Execute(new[] { "Ma_Hoa_Don" }, new[] { maHoaDon });
            doc.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { hoTen });
            doc.MailMerge.Execute(new[] { "Ma_Khach_Hang" }, new[] { maKhachHang });
            doc.MailMerge.Execute(new[] { "Ma_Phong" }, new[] { maPhong });
            doc.MailMerge.Execute(new[] { "Gia_Tien" }, new[] { giaTien });
            doc.SaveAndOpenFile("HoaDon.docx");
        }
    }
}
