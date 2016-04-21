using System;
using System.Collections.Generic;
using Rpg.Controllers;


namespace Rpg.Models
{
    enum EDirection
    {
        Haut, Bas, Gauche, Droite
    }
    class Joueur : Personnage
    {

        Position _position = new Position(15, 25);
        private string _embleme = "X";
        private int _currentvie = 0;
        private int _velociteX = 0;
        private int _velociteY = 0;
        private bool _canSwim = false;
        private  bool _gotWebbed = false;
        private EDirection _direction;
        private bool _isDead = false;
        private List<Item> sac = new List<Item>();
        private List<Item> stuff = new List<Item>();
        private int level = 1;
        private int exp = 0;
        private int nextlv = 5;

        public int Nextlv{ get { return nextlv; } set { nextlv = value; } }


        public int Exp{ get { return exp; } set { exp = value; } }

        public int Level { get { return level; } set { level = value; } }

        public List<Item> Stuff { get { return stuff; } set { stuff = value; } }

        public List<Item> Sac { get { return sac; } set { sac = value; } }

        public int Currentvie { get { return _currentvie; } set { _currentvie = value; } }

        public string Embleme { get { return _embleme; } }

        public Position Position { get { return _position; } set { _position = value; } }

        public int VelociteX { get { return _velociteX; } }

        public int VelociteY { get { return _velociteY; } }

        public bool CanSwim { get { return _canSwim; } set { _canSwim = value; } }

        public EDirection Direction { get { return _direction; } set { _direction = value; } }

        public bool IsDead { get { return _isDead; } set { _isDead = value; } }

        public  bool GotWebbed { get { return _gotWebbed; } set { _gotWebbed = value; } }

        public Joueur(String pNom)
        {
            this.Nom = pNom;
            this.Vie = 100;
            this.Currentvie = 100;
        }

        public void Lvup()
        {
            while (exp >= nextlv)
            {
                nextlv *= 2;
                Vie += 20;
                Currentvie = Vie;
                Attaque ++;
                Defense++;
                level++;
            }
        }

        public void GainItem(string item)
        {
            Item ajout = ItemControler.Create(item);
            sac.Add(ajout);
        }

        public Position NextPosition()
        {
            return new Position(Position.X + VelociteX, Position.Y + VelociteY);
        }

        public override void Bouger(int pVelociteX, int pVelociteY)
        {
            _velociteX = pVelociteX;
            _velociteY = pVelociteY;
        }

        public override void Attaquer()
        {

        }

        public override void PrendreDesDegats(int degats)
        {
            throw new NotImplementedException();
        }
    }
}