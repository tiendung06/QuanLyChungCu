using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChungCu.Object
{
    class ObjCustomerGroup
    {
        private string _id;

        public string Id_Group
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name_Group
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
