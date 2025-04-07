using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Board
    {
        public Square[] Squares;
        public Player[] players;
        public int currentPlayer; 
        public Random rand;
        readonly Panel infoPanel;
        List<PictureBox> pieces;
        public Board(Random rand, int amountofplayers, Panel infoPanel, List<PictureBox> pieces,PropertyVisualizer propvis)
        {
            
            this.pieces = pieces;
            this.infoPanel = infoPanel;
            this.rand = rand;
            players = new Player[amountofplayers];
            for (int i = 0; i < players.Length; i++) 
            {
                players[i] = new Player();
            }

            
            
            currentPlayer = 0;
            Squares = new Square[40];
            Squares[0] = new GoSquare();
            Squares[1] = new PropertySquare(new Property("Old Kent Rd", 60, 2, 0, BoardConstants.PropertyColors.Brown), infoPanel,propvis);
            Squares[2] = new CommunityCardSquare();
            Squares[3] = new PropertySquare(new Property("Whitechapel Rd", 60, 4, 0, BoardConstants.PropertyColors.Brown), infoPanel , propvis);
            Squares[4] = new TaxSquare("Income tax", 200);
            Squares[5] = new RailroadPropertySquare(new Property("Kings Cross Station", 200, 25,0, BoardConstants.PropertyColors.Railroad), infoPanel, propvis);
            Squares[6] = new PropertySquare(new Property("The Angel Islington", 100, 6, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel, propvis);
            Squares[7] = new ChanceCardSquare();
            Squares[8] = new PropertySquare(new Property("Euston", 100, 6, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel, propvis);
            Squares[9] = new PropertySquare(new Property("Pentonville", 120, 8, 0, BoardConstants.PropertyColors.BabyBlue), infoPanel, propvis);
            Squares[10] = new JailSquare();
            Squares[11] = new PropertySquare(new Property("Pall Mall",140, 10, 0, BoardConstants.PropertyColors.Magenta), infoPanel, propvis);
            Squares[13] = new PropertySquare(new Property("White Hall", 140, 10, 0, BoardConstants.PropertyColors.Magenta), infoPanel, propvis);
            Squares[14] = new PropertySquare(new Property("Northumrl'd", 160, 12, 0, BoardConstants.PropertyColors.Magenta), infoPanel, propvis);
            Squares[15] = new RailroadPropertySquare(new Property("Marylebone Station",200,25, 0, BoardConstants.PropertyColors.Railroad),infoPanel, propvis);
            Squares[16] = new PropertySquare(new Property("Bow",180,14,0,BoardConstants.PropertyColors.Orange), infoPanel, propvis);
            Squares[17] = new CommunityCardSquare();
            Squares[18] = new PropertySquare(new Property("Marlborough", 180, 14, 0, BoardConstants.PropertyColors.Orange), infoPanel, propvis);
            Squares[19] = new PropertySquare(new Property("Vine", 200, 16, 0, BoardConstants.PropertyColors.Orange), infoPanel, propvis);
            Squares[20] = new FreeParkingSquare();
            Squares[21] = new PropertySquare(new Property("Strand",220,18,0,BoardConstants.PropertyColors.Red), infoPanel, propvis);
            Squares[22] = new ChanceCardSquare();
            Squares[23] = new PropertySquare(new Property("Fleet", 220, 18,0,BoardConstants.PropertyColors.Red), infoPanel, propvis);
            Squares[24] = new PropertySquare(new Property("Trafalgar Square", 240, 20,0,BoardConstants.PropertyColors.Red), infoPanel, propvis);
            Squares[25] = new RailroadPropertySquare(new Property("Fenchurch St. Station", 200, 25, 0, BoardConstants.PropertyColors.Railroad),infoPanel, propvis);
            Squares[26] = new PropertySquare(new Property("Leicester Square", 260, 22, 0, BoardConstants.PropertyColors.Yellow), infoPanel, propvis);
            Squares[27] = new PropertySquare(new Property("Coventry Street", 260, 22, 0, BoardConstants.PropertyColors.Yellow), infoPanel, propvis);
            Squares[29] = new PropertySquare(new Property("Piccadilly", 280, 22, 0, BoardConstants.PropertyColors.Yellow), infoPanel, propvis);
            Squares[30] = new GoToJailSquare();
            Squares[31] = new PropertySquare(new Property("Regent Street", 300,26,0, BoardConstants.PropertyColors.Green), infoPanel, propvis);
            Squares[32] = new PropertySquare(new Property("Oxford Street", 300, 26, 0, BoardConstants.PropertyColors.Green), infoPanel, propvis);
            Squares[33] = new CommunityCardSquare();
            Squares[34] = new PropertySquare(new Property("Bond Street", 320, 28, 0,BoardConstants.PropertyColors.Green),infoPanel, propvis);
            Squares[35] = new RailroadPropertySquare(new Property("Liverpool St Station", 200, 25, 0, BoardConstants.PropertyColors.Railroad), infoPanel, propvis);
            Squares[36] = new ChanceCardSquare();
            Squares[37] = new PropertySquare(new Property("Park Lane", 350,35,0,BoardConstants.PropertyColors.DarkBlue), infoPanel, propvis);
            Squares[38] = new TaxSquare("Super tax", 100);
            Squares[39] = new PropertySquare(new Property("Mayfair", 400,50,0,BoardConstants.PropertyColors.DarkBlue), infoPanel, propvis);

        }
        public void SetPlayerLocation(int index)
        {
            int startingIndex = players[currentPlayer].location;
            int endingIndex = index;
            int numberOfSpacesToMove = 0;
            if(startingIndex < endingIndex)
            {
                numberOfSpacesToMove = endingIndex - startingIndex;
                MovePlayer(numberOfSpacesToMove);
            }
            else if(startingIndex > endingIndex)
            {
                endingIndex += 40;
                numberOfSpacesToMove = endingIndex - startingIndex;
                MovePlayer(numberOfSpacesToMove);
            }
            
        }
        public void MovePlayer(int numberOfSpaces)
        {
            if (players[currentPlayer].isInjail)
            {
                return;
            }

            int total = numberOfSpaces + players[currentPlayer].location;
            if (total > 39)
            {
                total -= 40;
                players[currentPlayer].money += 200;
            }
            

            players[currentPlayer].location = total;

            Squares[players[currentPlayer].location].SquareEffect(players[currentPlayer],this, rand);

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
            ;
            infoPanel.Visible = false;
        }
       
     
    }
}
