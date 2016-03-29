using System;
namespace Rpg
{
    enum EDirection
    {
        Haut, Bas, Gauche, Droite
    }
    class Joueur : Personnage
    {

        Position _position = new Position(1, 1);
        private string _embleme = "X";
        private int _vie = 100;
        private int _velociteX = 0;
        private int _velociteY = 0;
        private bool _canSwim = false;
        private EDirection _direction;
        private bool _isDead = false;

        public string Embleme { get { return _embleme; } }

        public Position Position { get { return _position; } set { _position = value; } }

        public int VelociteX { get { return _velociteX; } }

        public int VelociteY { get { return _velociteY; } }

        public bool CanSwim { get { return _canSwim; } set { _canSwim = value; } }

        public EDirection Direction { get { return _direction; } set { _direction = value; } }

        public bool IsDead{get{return _isDead;}set{_isDead = value;}}

        public Joueur(String pNom)
        {
            this.Nom = pNom;
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
            throw new NotImplementedException();
        }

        public override void PrendreDesDegats()
        {
            throw new NotImplementedException();
        }
    }
}