namespace Rpg.Models
{
    class Pnj
    {
        private Position _position;
        public Pnj(Position pPosition){Position = pPosition;}

        public Position Position { get { return _position; } set { _position = value; } }

        public static void SwimmingAbility(Joueur joueur)
        {
            if (joueur.GotWebbed)
            {
                joueur.CanSwim = true;
            }
        }
    }
}
