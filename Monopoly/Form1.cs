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
            board = new Board(new Random(10), 5);
            RollDiceButton.Click += RollDice;
        }
        private void RollDice(object sender, EventArgs e)
        {
            board.MovePlayer();
        }
        private void EndTurn(object sender, EventArgs e)
        {
            
        }


    }
}
