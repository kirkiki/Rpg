using System;
namespace Rpg
{
    class MapControler
    {
        public MapView Mv { get; private set; }

        public Map Map = new Map();
        MaisonController msc;

        public MapControler()
        {
            Mv = new MapView(this);
            msc = new MaisonController(this);
        }
        public void Start()
        {
            Mv.Display();
        }
        public bool Play()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            Mv.GetInfoTouche(info);
            if (msc.IsEnter)
                msc.Move();
            else
                Move();
            Display();

            if (Map.Joueur.IsDead) { return false; }
            else { return true; }

        }

        public void Move()
        {
            Position nextPos = new Position(Map.Joueur.Position.X + Map.Joueur.VelociteX, Map.Joueur.Position.Y + Map.Joueur.VelociteY);

            if (nextPos.Y > Map.GetLongueur() || nextPos.X > Map.GetLargeur())
            {
                Map.Joueur.Bouger(0, 0);
            }
            else if (nextPos.X < 0 || nextPos.Y < 0)
            {
                Map.Joueur.Bouger(0, 0);
            }
            else if (Map.Plan[nextPos.Y, nextPos.X] == Map.Eau && Map.Joueur.CanSwim)
            {
                Map.Joueur.Position = nextPos;
            }
            else if (Map.Plan[nextPos.Y, nextPos.X] == Map.Sol)
            {
                Map.Joueur.Position = nextPos;
            }

            else if (Map.Plan[nextPos.Y, nextPos.X] == Map.Maison && Map.Joueur.Direction==EDirection.Haut)
            {
                msc.IsEnter = true;
                msc.Entrer(Map.Joueur);
            }
            else {
                Map.Joueur.Bouger(0, 0);
            }
        }

        public bool DisplayEmbleme(string pEmbleme, int varI, int varJ)
        {
            if (Map.Plan[varJ, varI] == pEmbleme)
                Console.Write(Map.Plan[varJ, varI] + " ");
            return true;
        }

        public void Talk()
        {
            if (CanTalk())
            {
                Map.Joueur.CanSwim = true;
            }
        }
        public bool CanTalk()
        {
            if (Map.Joueur.Direction == EDirection.Haut && Map.Npc.Position.Y == Map.Joueur.Position.Y - 1)
            {
                return true;
            }
            else if (Map.Joueur.Direction == EDirection.Bas && Map.Npc.Position.Y == Map.Joueur.Position.Y + 1)
            {
                return true;
            }
            else if (Map.Joueur.Direction == EDirection.Gauche && Map.Npc.Position.X == Map.Joueur.Position.X - 1)
            {
                return true;
            }
            else if (Map.Joueur.Direction == EDirection.Droite && Map.Npc.Position.X == Map.Joueur.Position.X + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Display()
        {
            if (msc.IsEnter)
                msc.Mav.Display();
            else
            {
                Mv.Display();
            }
        }

        public void Input(ConsoleKey pKey)
        {
            switch (pKey)
            {
                case ConsoleKey.UpArrow:
                    Map.Joueur.Bouger(0, -1);
                    Map.Joueur.Direction = EDirection.Haut;
                    break;
                case ConsoleKey.DownArrow:
                    Map.Joueur.Bouger(0, 1);
                    Map.Joueur.Direction = EDirection.Bas;
                    break;
                case ConsoleKey.RightArrow:
                    Map.Joueur.Bouger(1, 0);
                    Map.Joueur.Direction = EDirection.Droite;
                    break;
                case ConsoleKey.LeftArrow:
                    Map.Joueur.Bouger(-1, 0);
                    Map.Joueur.Direction = EDirection.Gauche;
                    break;
                case ConsoleKey.Enter:
                    Talk();
                    break;
                default:
                    break;
            }
        }
    }
}
