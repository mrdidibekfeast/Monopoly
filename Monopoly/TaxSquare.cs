using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class TaxSquare : Square
    {
        public string name;
        public int taxAmount;
        public TaxSquare(string name, int taxAmount)
        {
            this.name = name;
            this.taxAmount = taxAmount;
        }
        public override void SquareEffect(Player player, Board board, Random rand)
        {
            player.money -= taxAmount;
        }
    }
}
