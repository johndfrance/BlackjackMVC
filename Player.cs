using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackMVC
{
    internal class Player:User
    {
        public int wallet { get; set; }

        public Player():base()
        {
            wallet = 20000;
        }
        public Player(int id, string name) : base()
        {
            wallet = 20000;
        }
    }
}
