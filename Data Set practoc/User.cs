using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Set_practoc
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Role { get; set; }

        public override string ToString()
        {
            string roleStr;

            switch (Role)
            {
                case 0: roleStr = "Administrator"; break;
                case 1: roleStr = "Moderator"; break;
                case 2: roleStr = "User"; break;
                default: roleStr = "User"; break;
            }

            return $"{Login} ({Password}) => {Address}; {Phone}; - {roleStr}";
        }
    }
}