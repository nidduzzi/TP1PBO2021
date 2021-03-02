using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Auth
    {
        private string m_password = "pbo123";

        public bool authenticate(string username, string password)
        {
            if(m_password == password)
                return true;
            return false;
        }
    }
}
