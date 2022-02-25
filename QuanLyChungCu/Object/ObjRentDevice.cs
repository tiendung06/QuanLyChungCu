using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    class ObjRentDevice
    {
        private string _idRent;

        public string Id_Rent
        {
            get { return _idRent; }
            set { _idRent = value; }
        }

        private string _dayRent;

        public string Day_Rent
        {
            get { return _dayRent; }
            set { _dayRent = value; }
        }

        private string _dayPay;

        public string Day_Pay
        {
            get { return _dayPay; }
            set { _dayPay = value; }
        }

        private string _idDevice;

        public string Id_Device
        {
            get { return _idDevice; }
            set { _idDevice = value; }
        }

        private string _idCustomer;

        public string Id_Customer
        {
            get { return _idCustomer; }
            set { _idCustomer = value; }
        }

        private string _statusRent;

        public string Status_Device
        {
            get { return _statusRent; }
            set { _statusRent = value; }
        }
    }
}
