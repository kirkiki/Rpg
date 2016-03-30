using System;
using Rpg.Controllers;
using Rpg.Models;

namespace Rpg.Views
{
    class MapView
    {
        MapControler _mpc;
        Map _map;

        public MapView(MapControler mc)
        {
            _mpc = mc;
            _map = mc.Map;
        }

        public void Display()
        {
            Console.Clear();
            for (int i = 0; i <= _map.GetLongueur(); i++)
            {
                for (int j = 0; j <= _map.GetLargeur(); j++)
                {
                    if (_map.Joueur.Position.X == j && _map.Joueur.Position.Y == i)
                    {
                        Console.Write(_map.Joueur.Embleme + " ");
                        j++;
                    }
                    _mpc.DisplayEmbleme(_map.Sol, j, i);
                    if (_mpc.DisplayEmbleme(_map.Pnj, j, i))
                        _map.Npc.Position = new Position(10,13);
                    _mpc.DisplayEmbleme(_map.Eau, j, i);
                    _mpc.DisplayEmbleme(_map.Arbre, j, i);
                    _mpc.DisplayEmbleme(_map.Maison, j, i);
                }
                Console.WriteLine();
            }
        }

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            _mpc.Input(cki.Key);
        }
    }

}