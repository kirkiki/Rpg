using System;
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
        private Joueur _perso;

        private bool continuer = true;
        private int state = 0;
        private int equipState = 0;
        private int page = 0;

        public InventaireControler(MapControler pMapControler)
        {
            _mpc = pMapControler;
            _ivView = new InventaireView(this);

        }

        public void Check(Joueur Perso)
        {
            _perso = Perso;
         
            while (continuer)
            {
                switch (state)
                {
                    case 0:
                        _ivView.DisplayI(Perso);
                        break;
                    case 1:
                        _ivView.DisplayO(Perso);
                        break;
                    case 2:
                        _ivView.DisplayE(Perso, equipState, page);
                        break;
                }
                ConsoleKeyInfo cki = Console.ReadKey();
                _ivView.GetInfoTouche(cki);
            }
            continuer = true;

        }

        public void changeEquip(int input)
        {
            if (equipState == 1)
            {
                

                _perso.Stuff.Add(_perso.Sac[page * 5 + input - 1]);
                _perso.Sac.RemoveAt(page * 5 + input - 1);

                _perso.Attaque += _perso.Stuff[page * 5 + input - 1].Battaque;
                _perso.Defense += _perso.Stuff[page * 5 + input - 1].Bdefense;
                _perso.Vie += _perso.Stuff[page * 5 + input - 1].Bpv;

            }
            if (equipState == 2)
            {
                _perso.Sac.Add(_perso.Stuff[page * 5 + input - 1]);
                _perso.Stuff.RemoveAt(page * 5 + input - 1);

                _perso.Attaque -= _perso.Sac[page * 5 + input - 1].Battaque;
                _perso.Defense -= _perso.Sac[page * 5 + input - 1].Bdefense;
                _perso.Vie -= _perso.Sac[page * 5 + input - 1].Bpv;
                if (_perso.Currentvie > _perso.Vie)
                {
                    _perso.Currentvie = _perso.Vie;
                }
            }
        }
        
        public void Input(ConsoleKey ck)
        {
            switch (ck)
            {
                case ConsoleKey.Escape:
                    continuer = false;
                    break;
                case ConsoleKey.I:
                    state = 0;
                    break;
                case ConsoleKey.O:
                    state = 1;
                    break;
                case ConsoleKey.E:
                    state = 2;
                    break;
                case ConsoleKey.S:
                    if (equipState == 0)
                    {
                        equipState = 1;
                    }
                    else
                    {
                        equipState = 0;
                    }
                    break;
                case ConsoleKey.D:
                    if (equipState == 0)
                    {
                        equipState = 2;
                        page = 0;
                    }
                    else
                    {
                        equipState = 0;
                        page = 0;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (equipState == 1)
                    {
                        if (page - 1 >= 0)
                        {
                            page--;
                        }
                    }
                    if (equipState == 2)
                    {
                        if (page - 1 >= 0)
                        {
                            page++;
                        }
                    }

                    break;
                case ConsoleKey.RightArrow:
                    if (equipState == 1)
                    {
                        if (page + 1 < (_perso.Sac.Count()/5) +1)
                        {
                            page++;
                        }
                    }
                    if (equipState == 2)
                    {
                        if (page + 1 < (_perso.Stuff.Count() / 5) + 1)
                        {
                            page++;
                        }
                    }
                    break;
                case ConsoleKey.D1:
                    changeEquip(1);
                    break;
                case ConsoleKey.D2:
                    changeEquip(2);
                    break;
                case ConsoleKey.D3:
                    changeEquip(3);
                    break;
                case ConsoleKey.D4:
                    changeEquip(4);
                    break;
                case ConsoleKey.D5:
                    changeEquip(5);
                    break;
                case ConsoleKey.R:
                    //test here
                    _mpc.Map.Joueur.GotWebbed = true;
                    break;
                default:
                    break;
            }
        }

    }
}
