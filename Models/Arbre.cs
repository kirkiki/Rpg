namespace Rpg.Models
{
    class Arbre : Decor
    {
        private string _emblemeArbre = "+";
        public Arbre(Position pPosition)
        {
            position = pPosition;
        }
        public string EmblemeArbre
        {
            get
            {
                return _emblemeArbre;
            }
        }
    }
}
