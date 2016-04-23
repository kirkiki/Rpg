using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Lib
{
    class ConsoleWrite
    {
        static public void ColorWriteLine(String text, string color)
        {
            switch(color){
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(text);
                    
                    break;
                default:
                    Console.WriteLine(text);
                    break;
            }
            Console.ResetColor();
        }

        static public void ColorWrite(String text, string color)
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(text);

                    break;
                default:
                    Console.Write(text);
                    break;
            }
            Console.ResetColor();
        }
    }
}
