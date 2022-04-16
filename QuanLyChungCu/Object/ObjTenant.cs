using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    internal class ObjTenant : ObjDweller
    {
        private string _TenantEmail;
        
        public string TenantEmail
        {
            get { return _TenantEmail; }
            set { _TenantEmail = value; }
        }

        private string _TenantPhoneNumber;

        public string TenantPhoneNumber
        {
            get { return _TenantPhoneNumber; }
            set { _TenantPhoneNumber = value; }
        }

        private string _CreditNumber;

        public string CreditNumber
        {
            get { return _CreditNumber; }
            set { _CreditNumber = value; }
        }

        private string _Bank;

        public string Bank
        {
            get { return _Bank; }
            set { _Bank = value; }
        }

        private string _TenantIdCard;

        public string TenantIdCard
        {
            get { return _TenantIdCard; }
            set { _TenantIdCard = value; }
        }
    }
}
