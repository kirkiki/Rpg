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
        private Enemi[] _enemi = new Enemi[] { new Singe(), new Loup(), };

        //instancier les models des objets pour le futur
        private static string[] _loot = new string[] { "une pomme", "de la poussiere", "un rubis", "des palmes" };

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

        public void Combating(Enemi pEnemi)
        {
            _combatEnemi = RandEnemis();
            _isCombating = true;
            while (_isCombating == true)
            {
                if (_combatEnemi.Vie1 <= 0)
                {
                    _isCombating = false;
                    Console.WriteLine("vous avez gagner " +RandLoot());
                    _cbView.EcranFin();
                    ConsoleKeyInfo enter = Console.ReadKey();
                    if (enter.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
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
            Random random = new Random((int)DateTime.Now.Ticks);
            int rand = random.Next(0, 100);
            string value="";
            if (rand >= 90)
                value = "un rubis";
            else if (rand >= 70 && rand < 90)
            {
                value = "des palmes";
                _mpc.Map.Joueur.GotWebbed = true;
            }
            else if (rand >= 40 && rand < 70)
                value = "une pomme";
            else if (rand >= 0 && rand < 40)
            {
                value = "de la poussiere";
            }
            return value;
        }

        public void Input(ConsoleKey ck)
        {
            switch (ck)
            {
                case ConsoleKey.A:
                    _cbView.Display();
                    Console.WriteLine("vous avez lancé un coup d'épée");
                    _combatEnemi.PrendreDesDegats(10);
                    Console.WriteLine();
                    Console.WriteLine("Appuyez sur entrer...");
                    break;
                case ConsoleKey.Z:
                    _cbView.Display();
                    Console.WriteLine("vous avez lancé un sort");
                    _combatEnemi.PrendreDesDegats(20);
                    Console.WriteLine();
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
