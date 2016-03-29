using System;

namespace Rpg
{
    class HomeControler
    {
        public MapControler mp { get; private set; }

        public HomeControler()
        {
            mp = new MapControler();
        }

        public void Start()
        {
             mp.Start();
        }

        public bool Play()
        {
            return mp.Play();
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

        public void Input(ConsoleKey ckey)
        {
            switch (ckey)
            {
                case ConsoleKey.J:
                    Start();
                    while (Play()) { }
                    break;
                case ConsoleKey.C:
                    Credits();
                    break;
                default:
                    break;
            }

        }
    }

}