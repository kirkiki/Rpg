using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Controllers;


namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeControler hm = new HomeControler();
            while (true)
            {
                hm.Jouer();
                ConsoleKeyInfo info = Console.ReadKey();
                hm.Input(info.Key);
            }
        }
    }
}
