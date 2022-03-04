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
        private string _CustomerId;

        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
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

    }
}
