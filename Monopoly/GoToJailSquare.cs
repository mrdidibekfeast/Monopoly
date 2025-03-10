using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class GoToJailSquare : Square
    {
        public override void SquareEffect(Player player, Board board, Random rand)
        {
            player.isInjail = true;
            player.location = 
        }
    }
}
