using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Controllers;
using Rpg.Models;

namespace Rpg.Views
{
    class CombatView
    {
        private CombatControler _cbControler;
        public CombatView(CombatControler pcbControler)
        {
            _cbControler = pcbControler;
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Vous etes en combat avec un "+_cbControler.CombatEnemi.Nom1);
            Console.WriteLine("Vie du "+ _cbControler.CombatEnemi.Nom1+": "+_cbControler.CombatEnemi.Vie1);
            Console.WriteLine("1:coup d'épée");
            Console.WriteLine("2:sort");

        }

        public void EcranFin()
        {
            Console.Clear();
            Console.WriteLine("vous avez vaincu cet Enemi!");
            Console.WriteLine("appuyez sur entrée");
        }

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            _cbControler.Input(cki.Key);
        }
    }
}
