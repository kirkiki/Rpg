using System;

namespace Rpg.Models
{
	public abstract class Enemi:Personnage
    {
        public Enemi()
        {
        }

	    public string Nom1
	    {
	        get { return this.Nom; }
            set { this.Nom = value; }
        }

	    public int Vie1
	    {
	        get { return this.Vie; }
            set { this.Vie = value; }
	    }

	    public override void Attaquer()
        {
            throw new NotImplementedException();
        }

        public override void Bouger(int pVelociteX, int pVelociteY)
        {
            throw new NotImplementedException();
        }

        public override void PrendreDesDegats(int degats)
        {
            Vie1 -= degats;
        }
    }
}