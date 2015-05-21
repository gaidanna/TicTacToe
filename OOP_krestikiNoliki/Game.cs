
namespace OOP_krestikiNoliki
{
    public class Game
    {
        bool gameOver = false;
        Board board = new Board();
        HumanPlayer human = new HumanPlayer('X');
        ComputerPlayer comp = new ComputerPlayer('O');

        string welcomeMessage = "Welcome to the game. Let's start it.\r\nThere is a 3×3 grid.\r\nPlease insert two numbers between 1 and 3 each to place 'X' (e.g.1 1)";
        string messagePlayerWon = "\r\nYou won the game!";
        string messageComputerWon = "\r\nComputer won the game!";
        string messagePlayerTurn = "\r\nYour turn\r\n";
        string messageGameOver = "Game over. No winners!";

        public void Start()
        {
            Program.ShowMessage(welcomeMessage);

            while (!gameOver)
            {
                Program.ShowMessage(messagePlayerTurn);
                human.PerformHumanTurn(board);
                Program.ClearOutput();

                board.ShowResultOutput();
                gameOver = board.VerifyWin(human.GetSign());

                if (gameOver)
                {
                    Program.ShowMessage(messagePlayerWon);
                    break;
                }
                else
                {
                    bool emptyCells = board.CheckEmptyCells();

                    if (!emptyCells)
                    {
                        Program.ShowMessage(messageGameOver);
                        break;
                    }
                }

                comp.PerformComputerTurn(board);
                Program.ClearOutput();
                board.ShowResultOutput();
                gameOver = board.VerifyWin(comp.GetSign());

                if (gameOver)
                {
                    Program.ShowMessage(messageComputerWon);
                }
            }
        }
    }
}
