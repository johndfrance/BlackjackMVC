using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    internal class Admin:User
    {
        private string password;

        public Admin(int id, string name, string password) : base()
        {
            this.password = password;
        }
    }
}
    
