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
        Panel infoPanel;
        public Board(Random rand, int amountofplayers, Panel infoPanel)
        {
            this.rand = rand;
            players = new Player[amountofplayers];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }
            currentPlayerIndex = 0;
            Squares = new Square[40];
            Squares[1] = new PropertySquare(new Property("Old Kent Rd", 60, 2, 0, BoardConstants.PropertyColors.Brown), infoPanel);
            Squares[3] = new PropertySquare(new Property("Whitechapel Rd", 60, 4, 0, BoardConstants.PropertyColors.Brown), infoPanel);
            Squares[6] = new PropertySquare(new Property("The Angel Islington", 100, 6, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel);
            Squares[8] = new PropertySquare(new Property("Euston", 100, 6, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel);
            Squares[9] = new PropertySquare(new Property("Pentonville", 120, 8, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel);
            Squares[11] = new PropertySquare(new Property("Pall Mall",140, 10, 0, BoardConstants.PropertyColors.Magenta), infoPanel);
            Squares[13] = new PropertySquare(new Property("White Hall", 140, 10, 0, BoardConstants.PropertyColors.Magenta), infoPanel);
            Squares[14] = new PropertySquare(new Property("Northumrl'd", 160, 12, 0, BoardConstants.PropertyColors.Magenta), infoPanel);
            Squares[16] = new PropertySquare(new Property("Bow",180,16,0,BoardConstants.PropertyColors.Orange), infoPanel);
            Squares[18] = new PropertySquare(new Property("Marlborough", 180, 20, 0, BoardConstants.PropertyColors.Orange), infoPanel);
            Squares[19] = new PropertySquare(new Property("Vine", 200, 20, 0, BoardConstants.PropertyColors.Orange), infoPanel);


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
            //infoPanel.Visible = false;
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
