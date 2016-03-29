namespace Rpg
{
    using System;

    public abstract class Personnage
    {
        protected int vie;
        protected int attaque;
        protected String nom;
        protected bool mort;


        // methodes virtuelles
        public abstract void attaquer();

        public abstract void prendreDesDegats();

        public abstract void Bouger(int p_positionX, int p_positionY);

    }
}