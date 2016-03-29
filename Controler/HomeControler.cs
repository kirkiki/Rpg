using System;

namespace Rpg
{
    class HomeControler
    {
        public MapControler Mp { get; private set; }

        public HomeControler()
        {
            Mp = new MapControler();
        }

        public void Start()
        {
             Mp.Start();
        }

        public bool Play()
        {
            return Mp.Play();
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