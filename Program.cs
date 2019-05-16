using System;

namespace TuroChamp
{
    class App
    {
        public void Run()
        {
            Board board = new Board();

            bool done = false;
            while (!done)
            {
                Console.Write(">");
                string command = Console.ReadLine();
                if (command == "print")
                {
                    board.printBoard();
                }
                else if (command.ToLower() == "quit")
                {
                    done = true;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square bsqoard = new Square();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi there again!");
            bsqoard.doSomething();

            App app = new App();
            app.Run();
        }
    }
}
