using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;
using Rpg.Controllers;
using Rpg.Lib;

namespace Rpg.Views
{
    class ParlerView
    {
        private ParlerControler _paControler;
        public ParlerView(ParlerControler ppaControler)
        {
            _paControler = ppaControler;
        }

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            _paControler.Input(cki.Key);
        }

        public void DisplayVieu1()
        {
            Console.Clear();
            Console.WriteLine("Bonjour aventurier");
            Console.WriteLine("Si vous le souhaitez je peux vous apprendre a nager!");
            Console.WriteLine("Oui même vous nul comme vous êtes vous pouvez nager!");
            Console.WriteLine("Enfin vous êtes bien nul quand même...");
            Console.Write("Revenez quand vous aurez des ");
            ConsoleWrite.ColorWrite("palmes", "red");
            Console.WriteLine(" il vas y en avoir besoin");

        }

        public void DisplayVieu2()
        {
            Console.Clear();
            Console.WriteLine("Oh rebonjour!");
            Console.WriteLine("Je vois que vous êtes encore en vie...");
            Console.WriteLine("Je vous avoue que je suis un peu impressionné");
            Console.WriteLine("Bon alors pour nager oui!");
            Console.WriteLine("Alors la technique c'est simple je vais vous montrer");
            Console.WriteLine("Pour le reste... Crois en ton Cosmos Chevalier!");

            ConsoleWrite.ColorWriteLine("Vous pouvez nager !!", "red");

        }
    }
}
