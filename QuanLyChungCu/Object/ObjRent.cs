using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    class ObjRent
    {
        private string _RentId;

        public string RentId
        {
            get { return _RentId; }
            set { _RentId = value; }
        }

        private string _RentStatus;

        public string RentStatus
        {
            get { return _RentStatus; }
            set { _RentStatus = value; }
        }

        private string _RentStatusTitle;

        public string RentStatusTitle
        {
            get { return _RentStatusTitle; }
            set { _RentStatusTitle = value; }
        }

        private string _Payday;

        public string Payday
        {
            get { return _Payday; }
            set { _Payday = value; }
        }

        private string _SettlementDay;

        public string SettlementDay
        {
            get { return _SettlementDay; }
            set { _SettlementDay = value; }
        }

        private string _ContractId;

        public string ContractId
        {
            get { return _ContractId; }
            set { _ContractId = value; }
        }

        private string _Cost;

        public string Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        private string _Month;

        public string Month
        {
            get { return _Month; }
            set { _Month = value; }
        }
    }
}
