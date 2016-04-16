﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;
using Rpg.Views;

namespace Rpg.Controllers
{
    class InventaireControler
    {

        private MapControler _mpc;
        private InventaireView _ivView;

        private bool continuer = true;

        public InventaireControler(MapControler pMapControler)
        {
            _mpc = pMapControler;
            _ivView = new InventaireView(this);

        }

        public void Check(Joueur Perso)
        {
            
            while (continuer)
            {
                _ivView.Display(Perso);
                ConsoleKeyInfo cki = Console.ReadKey();
                _ivView.GetInfoTouche(cki);
            }

        }

        public void Input(ConsoleKey ck)
        {
            switch (ck)
            {
                case ConsoleKey.Escape:
                    continuer = false;
                    break;
                default:
                    break;
            }
        }

    }
}
