using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxcalculator
{
    internal class info
    {
        private string id; // เลขบัตรประชาชน
        private string name; //ชื่อ
        private string surname; //นามสกุล
        private string callnum; //เบอร์โทร
        private string birthdate; //วันเกิด   

        public string idnum
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Callnum
        {
            get
            {
                return callnum;
            }
            set
            {
                callnum = value;
            }
        }
        public string Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
        public info()
        {
            id = "";
            name = "";
            surname = "";
            callnum = "";
            birthdate = "";
        }
    }
}
