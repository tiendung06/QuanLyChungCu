using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    class ObjContract
    {
        private string _ContractId;

        public string ContractId
        {
            get { return _ContractId; }
            set { _ContractId = value; }
        }

        private string _RoomId;

        public string RoomId
        {
            get { return _RoomId; }
            set { _RoomId = value; }
        }
        private string _TenantIdCard;

        public string TenantIdCard
        {
            get { return _TenantIdCard; }
            set { _TenantIdCard = value; }
        }
        
        private string _DateStart;

        public string DateStart
        {
            get { return _DateStart; }
            set { _DateStart = value; }
        }

        private string _DateEnd;

        public string DateEnd
        {
            get { return _DateEnd; }
            set { _DateEnd = value; }
        }

        private string _ContractStatus;

        public string ContractStatus
        {
            get { return _ContractStatus; }
            set { _ContractStatus = value; }
        }

        private string _ContractTitle;

        public string ContractStatusTitle
        {
            get { return _ContractTitle; }
            set { _ContractTitle = value; }
        }
    }
}
