using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract class Square
    {
        public string name;


        public abstract void SquareEffect(Player player,Random rand);
    }
}
