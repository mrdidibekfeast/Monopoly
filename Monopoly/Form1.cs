using System.Text;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        Board board;
        List<PictureBox> pieces;
        public Form1()
        {
            InitializeComponent();
        }
       


        private void Form1_Load_1(object sender, EventArgs e)
        {
            pieces = new List<PictureBox>();
            board = new Board(new Random(10), BoardConstants.PlayerCount);
            pieces.Add(ShoePiece);
            pieces.Add(RaceCarPiece);
            pieces.Add(TexPiece);
            pieces.Add(WheelBarrowPiece);
            RollDiceButton.Click += RollDice;
            EndTurnButton.Click += EndTurn;
            EndTurnButton.Enabled = false;
        }
        private void RollDice(object sender, EventArgs e)
        {
            board.MovePlayer();
            EndTurnButton.Enabled = true;
            RollDiceButton.Enabled = false;
            board.movePiece(pieces);
        }
        private void EndTurn(object sender, EventArgs e)
        {
            board.EndTurn();
            EndTurnButton.Enabled = false;
            RollDiceButton.Enabled = true;
        }


    }
}
