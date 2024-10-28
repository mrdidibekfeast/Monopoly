using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class ChanceCardSquare : CardSquare
    {
        
        static Card[] chancecards = [new MovementCard("Go to Go and Collect $200",0),
            new MoneyCard("You are Lucky: Find $100",100)];
        public override void SquareEffect(Player player,Random random)
        {
            chancecards[random.Next(chancecards.Length)].CardEffect(player);
        }
    }
}
