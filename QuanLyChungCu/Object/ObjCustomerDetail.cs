using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    class ObjCustomerDetail
    {
        private string _id;

        public string CustomerId
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _CustomerName;

        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        private string _CustomerEmail;

        public string CustomerEmail
        {
            get { return _CustomerEmail; }
            set { _CustomerEmail = value; }
        }
        private string _CustomerGender;

        public string CustomerGender
        {
            get { return _CustomerGender; }
            set { _CustomerGender = value; }
        }
        private string _CustomerBirthday;

        public string CustomerBirthday
        {
            get { return _CustomerBirthday; }
            set { _CustomerBirthday = value; }
        }
        private string _CustomerIdentityCard;

        public string CustomerIdentityCard
        {
            get { return _CustomerIdentityCard; }
            set { _CustomerIdentityCard = value; }
        }
        private string _RoomId;

        public string RoomId
        {
            get { return _RoomId; }
            set { _RoomId = value; }
        }
    }
}
