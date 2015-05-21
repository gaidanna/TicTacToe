using System;

namespace OOP_krestikiNoliki
{
    public class ComputerPlayer
    {
        private char sign;

        public ComputerPlayer(char sign)
        {
            this.sign = sign;
        }

        public char GetSign()
        {
            return sign;
        }

        public Coordinate SelectComputerTurn()
        {
            int x;
            int y;
            Random random;

            random = new Random();
            x = random.Next(3);
            y = random.Next(3);

            return new Coordinate(x, y);
        }

        public void PerformComputerTurn(Board gameBoard)
        {
            bool correctChoice;
            Coordinate compCoordinate;

            correctChoice = false;

            while (!correctChoice)
            {
                compCoordinate = SelectComputerTurn();
                correctChoice = gameBoard.CheckInputChoice(compCoordinate, sign);
            }
        }

    }
}
