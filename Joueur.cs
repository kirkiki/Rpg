using System;
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

        public string Embleme
        {
            get
            {
                return embleme;
            }
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
            this.nom = p_nom;
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