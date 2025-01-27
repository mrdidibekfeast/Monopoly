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

        public Player()
        {
            money = 0;
            properties = new List<Property>();
            location = 0;
            
        }
    }
}
