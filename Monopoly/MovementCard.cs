using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class MovementCard : Card
    {


        private string description;
        private int finalIndex;

        public MovementCard(string description, int finalIndex) : base(description)
        {

            this.description = description;
            this.finalIndex = finalIndex;

        }

        public override void CardEffect(Player player, Board board)
        {
            player.location = finalIndex;


        }
    }
}
