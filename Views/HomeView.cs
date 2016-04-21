using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Controllers;

namespace Rpg.Views
{
    class HomeView
    {
        private HomeControler hmc;

        public HomeView(HomeControler _hmc)
        {
            hmc = _hmc;
        }

        public void Display()
        {
            Console.WriteLine("J: Jouer");
            Console.WriteLine("C: Credit");
        }
        public void Credits()
        {
            Console.Clear();
            Console.WriteLine("Jeu crée par:");
            Console.WriteLine("Ronan ROBINEAU");
            Console.WriteLine("Robin CHAPERON");
        }

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            hmc.Input(cki.Key);
        }
    }
}
