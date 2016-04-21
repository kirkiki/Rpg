using System;
using Rpg.Views;

namespace Rpg.Controllers
{
    class HomeControler
    {
        public MapControler Mp { get; private set; }
        public HomeView hm;

        public HomeControler()
        {
            Mp = new MapControler(this);
            hm = new HomeView(this);
        }

        public void Start()
        {
            Mp.Start();
        }

        public bool Play()
        {
            return Mp.Play();
        }

        public void Jouer()
        {
            hm.Display();
            ConsoleKeyInfo info = Console.ReadKey();
            hm.GetInfoTouche(info);
        }

        public void Input(ConsoleKey ckey)
        {
            switch (ckey)
            {
                case ConsoleKey.J:
                    Start();
                    while (Play()) { }
                    break;
                case ConsoleKey.C:
                    hm.Credits();
                    break;
                default:
                    Console.WriteLine("arrete Daniel-senpai, notre jeu est parfait");
                    break;
            }

        }
    }

}