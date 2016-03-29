using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Pnj
    {
        private Position position;
        public Pnj(Position p_position)
        {
            Position = p_position;
        }

        internal Position Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
    }
}
