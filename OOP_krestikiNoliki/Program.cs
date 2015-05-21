using System;

namespace OOP_krestikiNoliki
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.ReadLine();
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ClearOutput()
        {
            Console.Clear();
        }
    }
}


