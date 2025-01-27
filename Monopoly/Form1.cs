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
            board = new Board(new Random(10), BoardConstants.PlayerCount,infoPanel,pieces);

            RollDiceButton.Click += RollDice;
            EndTurnButton.Click += EndTurn;
            EndTurnButton.Enabled = false;
            infoPanel.Visible = false;
        }
        private void RollDice(object sender, EventArgs e)
        {
            int dice1 = board.rand.Next(1, 7);
            int dice2 = board.rand.Next(1, 7);
            int total =  dice1 + dice2;
            board.MovePlayer(total);

            EndTurnButton.Enabled = true;
            RollDiceButton.Enabled = false;

        }
        private void EndTurn(object sender, EventArgs e)
        {
            board.EndTurn();
            EndTurnButton.Enabled = false;
            RollDiceButton.Enabled = true;
        }


    }
}
