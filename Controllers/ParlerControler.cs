using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;
using Rpg.Views;

namespace Rpg.Controllers
{
    class ParlerControler
    {
        private MapControler _mpc;
        private ParlerView _paView;

        public ParlerControler(MapControler pMapControler)
        {
            _mpc = pMapControler;
            _paView = new ParlerView(this);
        }

        public void ParlerVieux(Joueur Perso)
        {
            if(Perso.GotWebbed == false)
            {
                _paView.DisplayVieu1();
            }
            else
            {
                _paView.DisplayVieu2();
            }
            ConsoleKeyInfo cki = Console.ReadKey();
            _paView.GetInfoTouche(cki);
        }

        public void Input(ConsoleKey ck)
        {

        }
    }
}
