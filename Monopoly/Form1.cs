using System.Text;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        Board board;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<PictureBox> pieces = new List<PictureBox>();
            pieces.Add(ShoePiece);
            pieces.Add(RaceCarPiece);
            pieces.Add(TexPiece);
            pieces.Add(WheelBarrowPiece);

            PropertyVisualizer propvis = new PropertyVisualizer(nameBox, colorBox, priceBox, rentCostBox);

            board = new Board(new Random(10), BoardConstants.PlayerCount, infoPanel, pieces, propvis);



            RollDiceButton.Click += RollDice;
            EndTurnButton.Click += EndTurn;
            EndTurnButton.Enabled = false;
            infoPanel.Visible = false;


            playerMoneyBox.Text = board.players[board.currentPlayer].money.ToString();
        }
        private void RollDice(object sender, EventArgs e)
        {

            int dice1 = board.rand.Next(1, 7);
            int dice2 = board.rand.Next(1, 7);
            int total = dice1 + dice2;

            if (dice1 == dice2)
            {
                board.players[board.currentPlayer].isInjail = false;
            }

            board.MovePlayer(total);

            EndTurnButton.Enabled = true;
            RollDiceButton.Enabled = false;



        }
        private void EndTurn(object sender, EventArgs e)
        {
            board.EndTurn();
            EndTurnButton.Enabled = false;
            RollDiceButton.Enabled = true;

            propertiesBox.Items.Clear();
            propertiesBox.Items.AddRange(board.players[board.currentPlayer].properties.ToArray());

            playerMoneyBox.Text = "";
            playerMoneyBox.Text = board.players[board.currentPlayer].money.ToString();


            buyButton.Enabled = true;
            sellButton.Enabled = true;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            

            PropertySquare landedPropertySquare = (PropertySquare)board.Squares[board.players[board.currentPlayer].location];

            if(landedPropertySquare.property.owner != null || board.players[board.currentPlayer].money < landedPropertySquare.property.price)
            {
                buyButton.Enabled = false;
            }

            board.players[board.currentPlayer].money -= landedPropertySquare.property.price;

            board.players[board.currentPlayer].properties.Add(landedPropertySquare.property);

            propertiesBox.Items.Clear();
            propertiesBox.Items.AddRange(board.players[board.currentPlayer].properties.ToArray());

            playerMoneyBox.Text = "";
            playerMoneyBox.Text = board.players[board.currentPlayer].money.ToString();

            buyButton.Enabled = false;
            sellButton.Enabled = false;



        }

        private void sellButton_Click(object sender, EventArgs e)
        {
           

            PropertySquare landedPropertySquare = (PropertySquare)board.Squares[board.players[board.currentPlayer].location];

            if(landedPropertySquare.property.owner != board.players[board.currentPlayer])
            {
                sellButton.Enabled = false;
            }

            board.players[board.currentPlayer].money += landedPropertySquare.property.price;

            board.players[board.currentPlayer].properties.Remove(landedPropertySquare.property);

            propertiesBox.Items.Clear();
            propertiesBox.Items.AddRange(board.players[board.currentPlayer].properties.ToArray());

            playerMoneyBox.Text = "";
            playerMoneyBox.Text = board.players[board.currentPlayer].money.ToString();

            sellButton.Enabled = false;
            buyButton.Enabled = false;
        }
    }
}
