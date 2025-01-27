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
        public Player[] players;
        public int currentPlayer; 
        public Random rand;
        readonly Panel infoPanel;
        List<PictureBox> pieces;
        public Board(Random rand, int amountofplayers, Panel infoPanel, List<PictureBox> pieces)
        {
            pieces = new List<PictureBox>();
            this.pieces = pieces;

            this.rand = rand;
            players = new Player[amountofplayers];
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player();
            }
            currentPlayer = 0;
            Squares = new Square[40];
            Squares[0] = new GoSquare();
            Squares[1] = new PropertySquare(new Property("Old Kent Rd", 60, 2, 0, BoardConstants.PropertyColors.Brown), infoPanel);
            Squares[3] = new PropertySquare(new Property("Whitechapel Rd", 60, 4, 0, BoardConstants.PropertyColors.Brown), infoPanel);
            Squares[6] = new PropertySquare(new Property("The Angel Islington", 100, 6, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel);
            Squares[8] = new PropertySquare(new Property("Euston", 100, 6, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel);
            Squares[9] = new PropertySquare(new Property("Pentonville", 120, 8, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel);
            Squares[11] = new PropertySquare(new Property("Pall Mall",140, 10, 0, BoardConstants.PropertyColors.Magenta), infoPanel);
            Squares[13] = new PropertySquare(new Property("White Hall", 140, 10, 0, BoardConstants.PropertyColors.Magenta), infoPanel);
            Squares[14] = new PropertySquare(new Property("Northumrl'd", 160, 12, 0, BoardConstants.PropertyColors.Magenta), infoPanel);
            Squares[16] = new PropertySquare(new Property("Bow",180,14,0,BoardConstants.PropertyColors.Orange), infoPanel);
            Squares[18] = new PropertySquare(new Property("Marlborough", 180, 14, 0, BoardConstants.PropertyColors.Orange), infoPanel);
            Squares[19] = new PropertySquare(new Property("Vine", 200, 16, 0, BoardConstants.PropertyColors.Orange), infoPanel);
            Squares[21] = new PropertySquare(new Property("Strand",220,18,0,BoardConstants.PropertyColors.Red), infoPanel);
            Squares[23] = new PropertySquare(new Property("Fleet", 220, 18,0,BoardConstants.PropertyColors.Red), infoPanel);
            Squares[24] = new PropertySquare(new Property("Trafalgar Square", 240, 20,0,BoardConstants.PropertyColors.Red), infoPanel);
            Squares[26] = new PropertySquare(new Property("Leicester Square", 260, 22, 0, BoardConstants.PropertyColors.Yellow), infoPanel);
            Squares[27] = new PropertySquare(new Property("Coventry Street", 260, 22, 0, BoardConstants.PropertyColors.Yellow), infoPanel);
            Squares[29] = new PropertySquare(new Property("Piccadilly", 280, 22, 0, BoardConstants.PropertyColors.Yellow), infoPanel);
            Squares[31] = new PropertySquare(new Property("Regent Street", 300,26,0, BoardConstants.PropertyColors.Green), infoPanel);
            Squares[32] = new PropertySquare(new Property("Oxford Street", 300, 26, 0, BoardConstants.PropertyColors.Green), infoPanel);
            Squares[34] = new PropertySquare(new Property("Bond Street", 320, 28, 0,BoardConstants.PropertyColors.Green),infoPanel);
            Squares[37] = new PropertySquare(new Property("Park Lane", 350,35,0,BoardConstants.PropertyColors.DarkBlue), infoPanel);
            Squares[39] = new PropertySquare(new Property("Mayfair", 400,50,0,BoardConstants.PropertyColors.DarkBlue), infoPanel);

        }
        public void MovePlayer(int numberOfSpaces)
        {
            int total = numberOfSpaces + players[currentPlayer].location;
            if (total > 39)
            {
                total -= 40;
                players[currentPlayer].money += 200;
            }
            

            players[currentPlayer].location = total;
            //Squares[players[currentPlayerIndex].location].SquareEffect(players[currentPlayerIndex], rand);

            if (players[currentPlayer].location <= BoardConstants.JailIndex)
            {
                pieces[currentPlayer].Location = new Point(BoardConstants.RightScreen - (players[currentPlayer].location * BoardConstants.JumpValue), BoardConstants.BottomScreen);
            }
            else if (players[currentPlayer].location <= BoardConstants.ParkingIndex)
            {
                pieces[currentPlayer].Location = new Point(BoardConstants.LeftScreen, BoardConstants.BottomScreen - (players[currentPlayer].location - BoardConstants.JailIndex) * BoardConstants.JumpValue);
            }
            else if (players[currentPlayer].location <= BoardConstants.GoToJailIndex)
            {

                pieces[currentPlayer].Location = new Point(BoardConstants.LeftScreen + (players[currentPlayer].location - BoardConstants.ParkingIndex) * BoardConstants.JumpValue, BoardConstants.TopScreen);
            }
            else
            {
                pieces[currentPlayer].Location = new Point(BoardConstants.RightScreen, BoardConstants.TopScreen + (players[currentPlayer].location - BoardConstants.GoToJailIndex) * BoardConstants.JumpValue);
            }
        }
        public void EndTurn()
        {
            if (currentPlayer == players.Length - 1)
            {
                currentPlayer = 0;
                return;
            }

            currentPlayer++;
            //infoPanel.Visible = false;
        }
       
     
    }
}
