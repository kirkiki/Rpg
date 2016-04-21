using System;

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
                Console.WriteLine("Vous avez des palmes, je vais vous apprendre a nager!");
                joueur.CanSwim = true;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas de palmes! Revenez quand vous en aurez");
            }
        }
    }
}
