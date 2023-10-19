using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    partial class Program

    {
        private static void Restart()
        {
            Console.WriteLine("Продолжить? (Y/N)");
            string contune = Console.ReadLine();
            if (contune == "Y" || contune == "y")
            {
                Console.Clear();
                gameScore = 0;
                gameRunning = true;
                Main(null);
            }
        }
    }
}
