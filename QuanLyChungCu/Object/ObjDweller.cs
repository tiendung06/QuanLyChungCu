using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    internal class ObjDweller
    {
        private string _DwellerId;

        public string DwellerId
        {
            get { return _DwellerId; }
            set { _DwellerId = value; }
        }

        private string _DwellerName;

        public string DwellerName
        {
            get { return _DwellerName; }
            set { _DwellerName = value; }
        }

        private string _DwellerGender;

        public string DwellerGender
        {
            get { return _DwellerGender; }
            set { _DwellerGender = value; }
        }

        private string _DwellerBirthday;

        public string DwellerBirthday
        {
            get { return _DwellerBirthday; }
            set { _DwellerBirthday = value; }
        }

        private string _DwellerIdCard;

        public string DwellerIdCard
        {
            get { return _DwellerIdCard; }
            set { _DwellerIdCard = value; }
        }

        private string _DwellerStatus;

        public string DwellerStatus
        {
            get { return _DwellerStatus; }
            set { _DwellerStatus = value; }
        }

        private string _DwellerStatusTitle;

        public string DwellerStatusTitle
        {
            get { return _DwellerStatusTitle; }
            set { _DwellerStatusTitle = value; }
        }

        private string _TenantIdCard;

        public string TenantIdCard
        {
            get { return _TenantIdCard; }
            set { _TenantIdCard = value; }
        }
    }
}
