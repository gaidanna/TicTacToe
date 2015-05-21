using System;

namespace OOP_krestikiNoliki
{
    public class HumanPlayer
    {
        private char sign;

        public HumanPlayer(char sign)
        {
            this.sign = sign;
        }

        public char GetSign()
        {
            return sign;
        }

        public bool IsSignEqual(char signToCompare)
        {
            return sign == signToCompare;
        }

        public Coordinate ReadKeyBoardInput()
        {
            int index;
            int[] inputNumbers;
            string[] inputInfo;

            index = 0;

            inputInfo = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            inputNumbers = new int[inputInfo.Length];

            if (inputInfo.Length == 2)
            {
                try
                {
                    for (int i = inputInfo.Length - 1; i >= 0; i--)
                    {
                        inputNumbers[index] = Convert.ToInt32(inputInfo[i]) - 1;

                        if (inputNumbers[index] >= 0 && inputNumbers[index] <= 2)
                        {
                            index++;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    return new Coordinate(inputNumbers[0], inputNumbers[1]);
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void PerformHumanTurn(Board gameBoard)
        {
            
            Coordinate inputNumbers;
            bool correctChoice;

            correctChoice = false;
            string messageCorrectCoice = "Please insert correct choice.";
            string messageFullCell = "This cell is full. Please select a new cell.";

            while (!correctChoice)
            {
                inputNumbers = ReadKeyBoardInput();

                if (inputNumbers != null)
                {
                    correctChoice = gameBoard.CheckInputChoice(inputNumbers, sign);

                    if (!correctChoice)
                    {
                        Program.ShowMessage(messageFullCell);
                    }
                }
                else
                {
                    Program.ShowMessage(messageCorrectCoice);
                }
            }
        }
    }
}
