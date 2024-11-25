using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Board
    {
        Square[] Squares;
        Player[] players;
        int currentPlayerIndex;
        Random rand;
        
        public Board(Random rand,int amountofplayers)
        {
            this.rand = rand;
            players = new Player[amountofplayers];
            for(int i = 0; i < players.Length; i ++)
            {
                players[i] = new Player();
            }
            currentPlayerIndex = 0;
            Squares = [new PropertySquare(),new CommunityCardSquare(),new ChanceCardSquare()];
        }
        public void MovePlayer()
        {
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            int total = players[currentPlayerIndex].location +  dice1 + dice2;

            if(total > 39)
            {
                total -= 40;
            }
            players[currentPlayerIndex].location++;
            //players[currentPlayerIndex].location = total;
            ;
        }
        public void EndTurn()
        {
            if(currentPlayerIndex == players.Length - 1)
            {
                currentPlayerIndex = 0;
                return;
            }

            currentPlayerIndex++;
        }
        public void movePiece(List<PictureBox> pieces)
        {
            if (players[currentPlayerIndex].location<=10)
            {
                pieces[currentPlayerIndex].Location = new Point(770 - players[currentPlayerIndex].location * 65, 700);
            }
            else if (players[currentPlayerIndex].location <= 20)
            {
                pieces[currentPlayerIndex].Location = new Point(125  , 700 - (players[currentPlayerIndex].location-10) * 65);
            }
            else if (players[currentPlayerIndex].location <= 30)
            {
                pieces[currentPlayerIndex].Location = new Point(125 + (players[currentPlayerIndex].location - 20) * 65, 65);
            }
        }
    }
}
