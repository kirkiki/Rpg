using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;
using Rpg.Views;

namespace Rpg.Controllers
{
    class CombatControler
    {
        private MapControler _mpc;
        private CombatView _cbView;
        private bool _isCombating = false;
        private Enemi _combatEnemi;
        private Joueur _perso;
        private Enemi[] _enemi = new Enemi[] { new Singe(), new Loup(), };


        private List<string> _loot = new List<string>();

        public CombatControler(MapControler pMapControler)
        {
            _mpc = pMapControler;
            _cbView = new CombatView(this);
        }

        public Enemi CombatEnemi
        {
            get { return _combatEnemi; }
            set { _combatEnemi = value; }
        }

        public void Combating(Enemi pEnemi, Joueur pperso)
        {
            string loot;
            _combatEnemi = pEnemi;
            _perso = pperso;
            _isCombating = true;
            while (_isCombating == true)
            {
                if (_combatEnemi.Vie1 <= 0) //fin combat
                {
                    _isCombating = false;
                    loot = RandLoot();
                    pperso.GainItem(loot);
                    pperso.Exp += 20;
                    pperso.Lvup();
                    InventaireControler.EndBattleDura(pperso);
                    
                    _cbView.EcranFin(loot);
                    ConsoleKeyInfo enter = Console.ReadKey();
                    if (enter.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }//
                _cbView.Display();
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                    break;
                _cbView.GetInfoTouche(cki);
                ConsoleKeyInfo entree = Console.ReadKey();
                _cbView.GetInfoTouche(entree);
               
            }
        }

        public Enemi RandEnemis()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            int var = random.Next(0, _enemi.Length);
            return _enemi[var];
        }

        public string RandLoot()
        {
            _loot.Add("Epee en bois");
            
            Random random = new Random((int)DateTime.Now.Ticks);
            int rand = random.Next(0, _loot.Count() - 1);
          
            
            return _loot[rand];
        }

        public void attaqueEnnemi()
        {
            int damage;
            
            Console.WriteLine(_combatEnemi.Nom + "vous attaque!");
            damage = (_combatEnemi.Attaque - _perso.Defense) * 10;
            if (damage < 0) {damage = 0;}
            _perso.Currentvie -= damage;
            Console.WriteLine("Il vous inflige " + damage + "degats, il vous reste" + _perso.Currentvie + "PV.");
        }

        public void Input(ConsoleKey ck)
        {
            switch (ck)
            {
                case ConsoleKey.A:
                    int damage;
                    _cbView.Display();
                    Console.WriteLine("Vous avez lancé un coup d'épée");
                    damage = (_perso.Attaque - _combatEnemi.Defense) * 10;
                    if (damage < 0) { damage = 0;}
                    _combatEnemi.PrendreDesDegats(damage);
                    Console.WriteLine("Vous infligez " + damage + " a " + _combatEnemi.Nom);
                    Console.WriteLine();
                    attaqueEnnemi();
                    Console.WriteLine("Appuyez sur entrer...");
                    break;
                case ConsoleKey.Z:
                    _cbView.Display();
                    Console.WriteLine("vous avez lancé un sort");
                    _combatEnemi.PrendreDesDegats(20);
                    Console.WriteLine();
                    attaqueEnnemi();
                    Console.WriteLine("Appuyez sur entrer...");
                    break;
                case ConsoleKey.Enter:
                    break;
                default:
                    Console.WriteLine("fait pas le fou");
                    break;
            }

            
        }
    }
}
