namespace Rpg
{
    class Position
    {
        private int coordoneeX;
        private int coordoneeY;
        public Position(int p_coordoneeX, int p_coordoneeY)
        {
            this.coordoneeX = p_coordoneeX;
            this.coordoneeY = p_coordoneeY;
        }
        public int Y
        {
            get
            {
                return coordoneeY;
            }

            set
            {
                coordoneeY = value;
            }
        }

        public int X
        {
            get
            {
                return coordoneeX;
            }

            set
            {
                coordoneeX = value;
            }
        }
    }
}