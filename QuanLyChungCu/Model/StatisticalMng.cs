﻿using QuanLyChungCu.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Model
{
    class StatisticalMng
    {
        DataConfig cls = new DataConfig();

        public DataTable HTTongTBDung()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT COUNT(*) AS Total_Device FROM Device WHERE Status_Device = N'Đang sử dụng'";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                sqldata.Fill(result);
            }
            catch (Exception)
            {
                
            }
            return result;
        }

        public DataTable HTTongThanhLy()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT COUNT(*) AS Total_Liqui FROM Liquidate";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
                sqldata.Fill(result);
            }
            catch (Exception)
            {
            }
            return result;
        }

        public DataSet getListDeviceByTime(DateTime start, DateTime end)
        {
            SqlCommand sqlcmd = new SqlCommand("SELECT D.Id_Device AS 'MÃ THIẾT BỊ', " +
                "D.Name_Device AS 'TÊN THIẾT BỊ', " +
                "RD.Id_Rent AS 'MÃ MƯỢN', " +
                "RD.Date_Rent AS 'NGÀY MƯỢN', " +
                "CD.Name_Customer AS 'TÊN NGƯỜI DÙNG' FROM Rent_Device AS RD, " +
                "Device AS D, " +
                "Customer_Detail AS CD " +
                "WHERE Date_Rent >= '" + start.ToString() + "' " +
                "AND Date_Rent <= '" + end.ToString() + "' " +
                "AND RD.Id_Device = D.Id_Device " +
                "AND RD.Id_Customer = CD.Id_Customer");
            try
            {
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet getListDeviceByName(string name)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("SELECT D.Id_Device as 'MÃ THIẾT BỊ', D.Name_Device as 'TÊN THIẾT BỊ', RD.Date_Rent as 'NGÀY MƯỢN', CD.Name_Customer AS 'TÊN NGƯỜI DÙNG' " +
                    "FROM Rent_Device as RD, Device as D, Customer_Detail as CD " +
                    "WHERE CD.Name_Customer Like N'%" + name + "%' " +
                    "AND RD.Id_Device = D.Id_Device AND RD.Id_Customer = CD.Id_Customer");
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public DataSet getDeviceToChar()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT DATEPART(yyyy, Date_Liqui) AS 'Year', SUM(Id_Liqui) AS 'Total' FROM Liquidate GROUP BY DATEPART(yyyy, Date_Liqui)";

            //action get database
            DataSet result = new DataSet();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                sqldata.Fill(result);
            }
            catch (Exception)
            {

            }
            return result;
        }
    }
}