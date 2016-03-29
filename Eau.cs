using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Eau
    {
        private Position position;
        private string emblemeEeu = "~";
        public Eau(Position p_position)
        {
            position = p_position;
        }
        public string embleme
        {
            get { return emblemeEeu; }
        }
    }
}
