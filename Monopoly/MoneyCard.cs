using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class MoneyCard : Card
    {
        private int amount;
        public MoneyCard(string name, int amount) : base(name)
        {

        }

        public override void CardEffect(Player player)
        {
            player.money += amount;
        }
    }
}
