using System;

namespace Rpg.Models
{
	public abstract class Personnage
    {
        private int vie;
        private int attaque;
        private int defense;
        private String nom;       
        protected bool mort;


        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Vie
        {
            get { return vie; }
            set { vie = value; }
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

        // methodes virtuelles
        public abstract void Attaquer();

        public abstract void PrendreDesDegats(int degats);

        public abstract void Bouger(int pVelociteX, int pVelociteY);

    }
}