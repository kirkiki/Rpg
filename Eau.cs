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
