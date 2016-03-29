using System;
using System.Collections.Generic;

namespace Rpg
{
    enum EDirection
    {
        HAUT,BAS,GAUCHE,DROITE
    }
    class Joueur : Personnage
    {


        Position position = new Position(3,8);
        private string embleme = "X";
        private int vie = 100;
        private int velociteX = 0;
        private int velociteY = 0;
        private bool canSwim = false;
        private EDirection direction;
        private bool isDead = false;
        private int attaque = 1;
        private int defense = 0;
        private int lv = 1;
        private string name = "Bonjour";
        private List<int> stuff = new List<int>();
        private List<int> bag = new List<int>();

        
        

        public string Embleme
        {
            get
            {
                return embleme;
            }
        }

        public List<int> Bag
        {
            get { return bag; }
            set { bag = value; }
        } 

        public List<int> Stuff
        {
            get { return stuff; }
            set { stuff = value; }
        }

        public int Lv
        {
            get { return lv; }
            set { lv = value; }
        }

        public int Vie
        {
            get { return vie; }
            set { vie = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Attaque
        {
            get { return attaque; }
            set { attaque = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public Position Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public int VelociteX
        {
            get
            {
                return velociteX;
            }
        }

        public int VelociteY
        {
            get
            {
                return velociteY;
            }
        }

        public bool CanSwim
        {
            get
            {
                return canSwim;
            }

            set
            {
                canSwim = value;
            }
        }

        public EDirection Direction
        {
            get
            {
                return direction;
            }

            set
            {
                direction = value;
            }
        }

        public bool IsDead
        {
            get
            {
                return isDead;
            }

            set
            {
                isDead = value;
            }
        }

        public Joueur(String p_nom)
        {
            this.name = p_nom;
            stuff.Add(1);
        }

        public Position nextPosition()
        {
            return new Position(Position.X + VelociteX, Position.Y + VelociteY);
        }

        public override void Bouger(int p_velociteX, int p_velociteY)
        {
            velociteX = p_velociteX;
            velociteY = p_velociteY;
        }
        public override void attaquer()
        {
        }
        public override void prendreDesDegats()
        {
        }
    }
}