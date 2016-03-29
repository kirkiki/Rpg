using System;
namespace Rpg
{
    class MapControler
    {
        public MapView mv { get; private set; }

        public Map map = new Map();
        MaisonController msc;

        public MapControler()
        {
            mv = new MapView(this);
            msc = new MaisonController(this);
        }
        public void Start()
        {
            mv.Display();
        }
        public bool Play()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            mv.GetInfoTouche(info);
            if (msc.IsEnter)
            {
                msc.Move();
            }
            else
            {
                Move();
            }
            Display();
            if (map.Joueur.IsDead){return false;}
            else{return true;}

        }

        public void Move()
        {
            Position nextPos = new Position(map.Joueur.Position.X + map.Joueur.VelociteX, map.Joueur.Position.Y + map.Joueur.VelociteY);

            if (nextPos.Y > map.getLongueur() || nextPos.X > map.getLargeur())
            {
                map.Joueur.Bouger(0, 0);
            }
            else if (nextPos.X < 0 || nextPos.Y < 0)
            {
                map.Joueur.Bouger(0, 0);
            }
            else if (map.Plan[nextPos.Y, nextPos.X] == map.Eau && map.Joueur.CanSwim)
            {
                map.Joueur.Position = nextPos;
            }
            else if (map.Plan[nextPos.Y, nextPos.X] == map.Sol)
            {
                map.Joueur.Position = nextPos;

            }
            else if (map.Plan[nextPos.Y, nextPos.X] == map.Maison && map.Joueur.VelociteY == -1)
            {
                msc.IsEnter = true;
                msc.Entrer(map.Joueur);
            }
            else {
                map.Joueur.Bouger(0, 0);
            }
        }

        public bool displayEmbleme(string p_embleme, int varI, int varJ)
        {
            if (map.Plan[varJ, varI] == p_embleme)
                Console.Write(map.Plan[varJ, varI] + " ");
            return true;
        }

        public void talk()
        {
            if (canTalk())
            {
                map.Joueur.Position = new Position(9, 9);
            }
        }
        public bool canTalk()
        {
            if (map.Joueur.Direction == EDirection.HAUT && map.Npc.Position.Y == map.Joueur.Position.Y - 1)
            {
                return true;
            }
            else if (map.Joueur.Direction == EDirection.BAS && map.Npc.Position.Y == map.Joueur.Position.Y + 1)
            {
                return true;
            }
            else if (map.Joueur.Direction == EDirection.GAUCHE && map.Npc.Position.X == map.Joueur.Position.X - 1)
            {
                return true;
            }
            else if (map.Joueur.Direction == EDirection.DROITE && map.Npc.Position.X == map.Joueur.Position.X + 1)
            {
                return true;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(map.Npc.Position.X + " " + map.Npc.Position.Y);
                Console.WriteLine(map.Joueur.Position.X + " " + map.Joueur.Position.Y);

                return false;
            }
        }

        public void Display()
        {
            if (msc.IsEnter)
                msc.mav.Display();
            else
            {
                mv.Display();
            }
        }

        public void input(ConsoleKey p_key)
        {
            switch (p_key)
            {
                case ConsoleKey.UpArrow:
                    map.Joueur.Bouger(0, -1);
                    map.Joueur.Direction = EDirection.HAUT;
                    break;
                case ConsoleKey.DownArrow:
                    map.Joueur.Bouger(0, 1);
                    map.Joueur.Direction = EDirection.BAS;
                    break;
                case ConsoleKey.RightArrow:
                    map.Joueur.Bouger(1, 0);
                    map.Joueur.Direction = EDirection.DROITE;
                    break;
                case ConsoleKey.LeftArrow:
                    map.Joueur.Bouger(-1, 0);
                    map.Joueur.Direction = EDirection.GAUCHE;
                    break;
                case ConsoleKey.Enter:
                    talk();
                    //map.Joueur.Position = new Position(9, 9);
                    break;
                default:
                    break;
            }
        }
    }
}
