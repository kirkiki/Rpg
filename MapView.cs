using System;

namespace Rpg
{
    class MapView
    {
        MapControler mpc;
        Map map;

        public MapView(MapControler mc)
        {
            mpc = mc;
            map = mc.map;
        }

        public void Display()
        {
            Console.Clear();
            for (int i = 0; i <= map.getLongueur(); i++)
            {
                for (int j = 0; j <= map.getLargeur(); j++)
                {
                    if (map.Joueur.Position.X == j && map.Joueur.Position.Y == i)
                    {
                        Console.Write(map.Joueur.Embleme + " ");
                        j++;
                    }
                    mpc.displayEmbleme(map.Sol, j, i);
                    if (mpc.displayEmbleme(map.Pnj, j, i))
                        map.Npc.Position = new Position(j, i);
                    mpc.displayEmbleme(map.Eau, j, i);
                    mpc.displayEmbleme(map.Arbre, j, i);
                    mpc.displayEmbleme(map.Maison, j, i);
                }
                Console.WriteLine();
            }
        }

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            mpc.input(cki.Key);
        }
    }

}