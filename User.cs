using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    internal class User
    {
        private int id { get; set; }
        private string name { get; set; }

        public User() 
        { 
            id = 0;
            name = string.Empty;
        }
        public User(int id, string name) 
        {
            this.id = id;
            this.name = name;
        }


    }
}
