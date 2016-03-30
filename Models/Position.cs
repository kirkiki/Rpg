namespace Rpg.Models
{
    class Position
    {
        private int _coordoneeX;
        private int _coordoneeY;
        public Position(int pCoordoneeX, int pCoordoneeY)
        {
            this._coordoneeX = pCoordoneeX;
            this._coordoneeY = pCoordoneeY;
        }
        public int Y { get { return _coordoneeY; } set { _coordoneeY = value; } }
        public int X { get { return _coordoneeX; } set { _coordoneeX = value; } }
    }
}