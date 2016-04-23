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
        private List<Enemi> _enemi = new List<Enemi>();
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
               
                if (_perso.Currentvie <= 0)
                {
                   
                    while (true)
                    {
                        Random random = new Random((int)DateTime.Now.Ticks);
                        int txt = random.Next(0, 4);
                        _cbView.GameOver(txt);
                    }

                }
                _cbView.Display();
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                    break;
                _cbView.GetInfoTouche(cki);

                ConsoleKeyInfo wait = Console.ReadKey();

                if (_combatEnemi.Vie1 <= 0) //fin combat
                {
                    _isCombating = false;
                    loot = RandLoot();

                    if (loot != "Rien")
                    {
                        pperso.GainItem(loot); 
                    }
                    pperso.Exp += 20;
                    pperso.Lvup();

                    InventaireControler.EndBattleDura(pperso);

                    _cbView.EcranFin(loot);

                    ConsoleKeyInfo enter = Console.ReadKey();


                }//
            }
        }

        public List<Enemi> ResetEnnemi()
        {
            List<Enemi> reset = new List<Enemi>();
            reset.Add(new Loup());
            reset.Add(new Singe());

            return reset;
        }

        public List<string> ResetItem()
        {
            List<string> reset = new List<string>();
            reset.Add("Epee en bois");
            reset.Add("Epee en bois");
            reset.Add("Armure en cuir");
            reset.Add("Armure en cuir");
            reset.Add("Palmes");
            reset.Add("Rien");
            reset.Add("Rien");
            reset.Add("Rien");
            reset.Add("Rien");


            return reset;
        }

        public Enemi RandEnemis()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            _enemi = ResetEnnemi();

            int var = random.Next(0, _enemi.Count());
            return _enemi[var];
        }

        public string RandLoot()
        {
            _loot = ResetItem();
            
            Random random = new Random((int)DateTime.Now.Ticks);
            int rand = random.Next(0, _loot.Count());
          
            
            return _loot[rand];
        }

        public void attaqueEnnemi()
        {
            int damage;
            
            damage = (_combatEnemi.Attaque - _perso.Defense) * 10;
            if (damage < 0) {damage = 0;}
            _perso.Currentvie -= damage;
            _cbView.attaqueEnnemi(damage, _combatEnemi, _perso);
        }

        public void Input(ConsoleKey ck)
        {
            switch (ck)
            {
                case ConsoleKey.D1:
                    int damage;
                    _cbView.Display();
                    damage = (_perso.Attaque - _combatEnemi.Defense) * 10;
                    if (damage < 0) { damage = 0;}
                    _combatEnemi.PrendreDesDegats(damage);
                    _cbView.attaqueJoueur(damage, _combatEnemi);
                    attaqueEnnemi();
                    break;
                case ConsoleKey.D2:
                    _cbView.Display();
                    _combatEnemi.PrendreDesDegats(20);
                    _cbView.lancerSort();
                    attaqueEnnemi();
                    Console.WriteLine("Appuyez sur entrer...");
                    break;
                case ConsoleKey.Enter:
                    break;
                default:
                    Console.WriteLine("fait pas le fou Daniel-sensei");
                    break;
            }

            
        }
    }
}
