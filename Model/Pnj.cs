using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Pnj
    {
        private Position _position;
        public Pnj(Position pPosition){Position = pPosition;}

        public Position Position { get { return _position; } set { _position = value; } }
    }
}
