using System;

namespace OOP_krestikiNoliki
{
    public class Board
    {
        private Cell[,] gameBoard;

        public Board()
        {
            Initialize();
        }

        public bool VerifyWin(char charForCheck)
        {
            bool isWinner = false;

            isWinner = CheckColumns(charForCheck);

            if (!isWinner)
            {
                isWinner = CheckRows(charForCheck);
            }

            if (!isWinner)
            {
                isWinner = CheckLeftDiagonal(charForCheck);
            }

            if (!isWinner)
            {
                isWinner = CheckRightDiagonal(charForCheck);
            }
            return isWinner;

        }

        public bool CheckEmptyCells()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j].IsEmpty())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckColumns(char player)
        {
            bool isWinner;

            for (int raw = 0; raw < gameBoard.GetLength(0); raw++)
            {
                isWinner = true;

                for (int column = 0; column < gameBoard.GetLength(1); column++)
                {
                    if (gameBoard[raw, column].GetSign() != player)
                    {
                        isWinner = false;
                    }
                }

                if (isWinner)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckRows(char player)
        {
            bool isWinner;

            for (int column = 0; column < gameBoard.GetLength(1); column++)
            {
                isWinner = true;

                for (int raw = 0; raw < gameBoard.GetLength(0); raw++)
                {
                    if (gameBoard[raw, column].GetSign() != player)
                    {
                        isWinner = false;
                    }
                }

                if (isWinner)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckLeftDiagonal(char player)
        {
            for (int raw = 0; raw < gameBoard.GetLength(0); raw++)
            {
                if (gameBoard[raw, raw].GetSign() != player)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckRightDiagonal(char player)
        {
            for (int raw = 0; raw < gameBoard.GetLength(0); raw++)
            {
                if (gameBoard[raw, gameBoard.GetUpperBound(0) - raw].GetSign() != player)
                {
                    return false;
                }
            }
            return true;
        }

        public void ShowResultOutput()
        {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    Console.Write(gameBoard[i, j].GetSign() + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Initialize()
        {
            gameBoard = new Cell[3, 3];

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(0); j++)
                {
                    gameBoard[i, j] = new Cell();
                }
            }
        }

        public bool CheckInputChoice(Coordinate coordinate, char playersSign)
        {
            if (gameBoard[coordinate.X(), coordinate.Y()].IsEmpty())
            {
                gameBoard[coordinate.X(), coordinate.Y()].Set(playersSign);
                return true;
            }
            return false;
        }

    }
}
