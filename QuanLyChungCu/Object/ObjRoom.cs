using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    class ObjRoom
    {
        private string _RoomId;

        public string RoomId
        {
            get { return _RoomId; }
            set { _RoomId = value; }
        }

        private string _Cost;

        public string Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        private string _RoomFloor;

        public string RoomFloor
        {
            get { return _RoomFloor; }
            set { _RoomFloor = value; }
        }

        private string _RoomStatus;

        public string RoomStatus
        {
            get { return _RoomStatus; }
            set { _RoomStatus = value; }
        }
    }
}