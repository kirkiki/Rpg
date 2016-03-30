namespace Rpg.Models
{
    class Eau
    {
        private Position _position;
        private string _emblemeEeu = "~";
        public Eau(Position pPosition)
        {
            _position = pPosition;
        }
        public string Embleme
        {
            get { return _emblemeEeu; }
        }
    }
}
