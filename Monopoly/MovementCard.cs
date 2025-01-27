using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class MovementCard : Card
    {
        private Board board;
        private string name;
        private string description;
        private int index;

        public MovementCard(string name, string description,int index,Board board) : base(name)
        {
            this.name = name;
            this.description = description;
            this.index = index;
            this.board = board;
        }

        public override void CardEffect(Player player)
        {
            
            board.MovePlayer();
        }
    }
}
