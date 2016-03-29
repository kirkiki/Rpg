using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    abstract class Decor
    {
        protected Position position;

        public Position Position { get { return position; } }
    }
}
