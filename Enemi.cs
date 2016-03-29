namespace Rpg
{
    using System;

    class Enemi:Personnage
    {
        public Enemi(String p_nom, int p_vie)
        {
            this.nom = p_nom;
            this.vie = p_vie;
        }
        public override void attaquer()
        {
            throw new NotImplementedException();
        }
        public override void prendreDesDegats()
        {
            throw new NotImplementedException();

        }
        public override void Bouger(int p_positionX, int p_positionY)
        {
            throw new NotImplementedException();
        }

    }
}