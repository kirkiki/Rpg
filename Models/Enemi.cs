using System;

namespace Rpg.Models
{
	class Enemi:Personnage
    {
        public Enemi(String pNom, int pVie)
        {
            this.Nom = pNom;
            this.Vie = pVie;
        }

        public override void Attaquer()
        {
            throw new NotImplementedException();
        }

        public override void Bouger(int pVelociteX, int pVelociteY)
        {
            throw new NotImplementedException();
        }

        public override void PrendreDesDegats()
        {
            throw new NotImplementedException();
        }
    }
}