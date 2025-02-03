using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract class Card
    {
        string name;
        public Card(string name)
        {
            this.name = name;
        }
        
        public abstract void CardEffect(Player player,Board board);
    }
}
