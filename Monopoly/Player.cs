using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Player
    {
        public int money;
        public List<Property> properties;
        public int location;
        public bool isInjail;
       
        public Player()
        {
            money = 1500;
            properties = new List<Property>();
            location = 0;
            isInjail = false;
        }
    }
}
