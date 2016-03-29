namespace Rpg
{
    using System;

    public abstract class Personnage
    {
        protected int Vie;
        protected int Attaque;
        protected String Nom;
        protected bool Mort;


        // methodes virtuelles
        public abstract void Attaquer();

        public abstract void PrendreDesDegats();

        public abstract void Bouger(int pVelociteX, int pVelociteY);

    }
}