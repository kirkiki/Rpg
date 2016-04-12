using System;

namespace Rpg.Models
{
	public abstract class Personnage
    {
        protected int Vie;
        protected int Attaque;
        protected String Nom;
        protected bool Mort;


        // methodes virtuelles
        public abstract void Attaquer();

        public abstract void PrendreDesDegats(int degats);

        public abstract void Bouger(int pVelociteX, int pVelociteY);

    }
}