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
            if (state == 2 && equipState == 1 && (page * 5 + input - 1) <= _perso.Sac.Count() && _perso.Sac.Count() > 0)
            {
                _perso.Stuff.Add(_perso.Sac[page * 5 + input]);
                ChangeStat(equipState, _perso, 0);
                _perso.Sac.RemoveAt(page * 5 + input );

                
                

            }
            if (state == 2 && equipState == 2 && (page * 5 + input) <= _perso.Stuff.Count() && _perso.Stuff.Count() > 0)
            {
                _perso.Sac.Add(_perso.Stuff[page * 5 + input]);
                ChangeStat(equipState, _perso, 0);
                _perso.Stuff.RemoveAt(page * 5 + input);

                
                
            }
        }

        public static void ChangeStat(int variable, Joueur pperso, int place)
        {
            if (variable == 1 )//equip
            {
                pperso.Vie += pperso.Stuff[pperso.Stuff.Count() - 1].Bpv;
                pperso.Attaque += pperso.Stuff[pperso.Stuff.Count() - 1].Battaque;
                pperso.Defense += pperso.Stuff[pperso.Stuff.Count() - 1].Bdefense;
            }
            else if (variable == 2 )//unequip
            {
                pperso.Vie -= pperso.Sac[pperso.Sac.Count() - 1].Bpv;
                pperso.Attaque -= pperso.Sac[pperso.Sac.Count() - 1].Battaque;
                pperso.Defense -= pperso.Sac[pperso.Sac.Count() - 1].Bdefense;

                if (pperso.Currentvie > pperso.Vie)
                {
                    pperso.Currentvie = pperso.Vie;
                }

            }
            else if(variable == 3){//both

                pperso.Vie -= pperso.Stuff[place].Bpv;
                pperso.Attaque -= pperso.Stuff[place].Battaque;
                pperso.Defense -= pperso.Stuff[place].Bdefense;

                pperso.Stuff[place].DuraDown();

                pperso.Vie += pperso.Stuff[place].Bpv;
                pperso.Attaque += pperso.Stuff[place].Battaque;
                pperso.Defense += pperso.Stuff[place].Bdefense;

                if (pperso.Currentvie > pperso.Vie)
                {
                    pperso.Currentvie = pperso.Vie;
                }
            }
        }

        static public void EndBattleDura(Joueur perso)
        {
            for (int i = 0; i < perso.Stuff.Count(); i++)
            {
                ChangeStat(3,perso, i);
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
                    changeEquip(0);
                    break;
                case ConsoleKey.D2:
                    changeEquip(1);
                    break;
                case ConsoleKey.D3:
                    changeEquip(2);
                    break;
                case ConsoleKey.D4:
                    changeEquip(3);
                    break;
                case ConsoleKey.D5:
                    changeEquip(4);
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
