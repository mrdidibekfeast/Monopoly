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

        public Board(Random rand, int amountofplayers)
        {
            this.rand = rand;
            players = new Player[amountofplayers];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }
            currentPlayerIndex = 0;
            Squares = [new PropertySquare(), new CommunityCardSquare(), new ChanceCardSquare()];
        }
        public void MovePlayer()
        {
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            int total = players[currentPlayerIndex].location + dice1 + dice2;

            if (total > 39)
            {
                total -= 40;
            }
            
            players[currentPlayerIndex].location = total;
            //Squares[players[currentPlayerIndex].location].SquareEffect(players[currentPlayerIndex], rand);
        }
        public void EndTurn()
        {
            if (currentPlayerIndex == players.Length - 1)
            {
                currentPlayerIndex = 0;
                return;
            }

            currentPlayerIndex++;
        }
        public void movePiece(List<PictureBox> pieces)
        {
            if (players[currentPlayerIndex].location <= BoardConstants.JailIndex)
            {
                pieces[currentPlayerIndex].Location = new Point(BoardConstants.RightScreen - (players[currentPlayerIndex].location * BoardConstants.JumpValue), BoardConstants.BottomScreen);
            }
            else if (players[currentPlayerIndex].location <= BoardConstants.ParkingIndex)
            {
                pieces[currentPlayerIndex].Location = new Point(BoardConstants.LeftScreen, BoardConstants.BottomScreen - (players[currentPlayerIndex].location - BoardConstants.JailIndex) * BoardConstants.JumpValue);
            }
            else if (players[currentPlayerIndex].location <= BoardConstants.GoToJailIndex)
            {

                pieces[currentPlayerIndex].Location = new Point(BoardConstants.LeftScreen + (players[currentPlayerIndex].location - BoardConstants.ParkingIndex) * BoardConstants.JumpValue, BoardConstants.TopScreen);
            }
            else
            {
                pieces[currentPlayerIndex].Location = new Point(BoardConstants.RightScreen, BoardConstants.TopScreen + (players[currentPlayerIndex].location - BoardConstants.GoToJailIndex) * BoardConstants.JumpValue);
            }
        }
    }
}
