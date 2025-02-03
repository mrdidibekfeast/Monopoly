using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class CommunityCardSquare : CardSquare
    {
        static Card[] communitycards = new Card[1];
        
        
        public override void SquareEffect(Player player,Board board, Random random)
        {
           
            communitycards[random.Next(communitycards.Length)].CardEffect(player,board);
        }
    }
}
