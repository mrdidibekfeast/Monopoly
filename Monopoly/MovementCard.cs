using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class MovementCard : Card
    {
        private int space;

        public MovementCard(string name, int space) : base(name)
        {

        }

        public override void CardEffect(Player player)
        {
            player.location = space;
        }
    }
}
