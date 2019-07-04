using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuroChampXboard
{
    class XboardInterface
    {
        public Tuple<bool, string> Execute(string commandline)
        {
            string retval = "";
            bool bDone = false;

            string[] commands = commandline.Split(' ');
            if (commands.Length > 0)
            {
                string command = commands[0];
                switch (command.ToLower())
                {
                    case "new":
                    {
                        retval = "NEW GAME";
                    }
                    break;

                    case "level":
                    {
                        Console.WriteLine("LEVEL");
                        foreach(string s in commands)
                        {
                            Console.WriteLine("s: {0}", s);
                        }
                    }
                    break;

                    case "quit":
                    {
                        bDone = true;
                    }
                    break;

                    default:
                    {
                        Console.WriteLine("move e7e5");
                    }
                    break;
                }
            }

            return new Tuple<bool, string>(bDone, retval);
        }
    }
    
    class ConsoleInterface
    {
        public void MainLoop()
        {
            bool bDone = false;

            Console.WriteLine("tellics say TuroChampXboard");
            Console.WriteLine("tellics say (c) 2019 by Adalid Claure");

            XboardInterface xboard = new XboardInterface();
            while (!bDone)
            {
                string command = Console.ReadLine();
                Tuple<bool,string> ret = xboard.Execute(command);
                if (!ret.Item1)
                {
                    Console.WriteLine("");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInterface app = new ConsoleInterface();
            app.MainLoop();
        }
    }
}
