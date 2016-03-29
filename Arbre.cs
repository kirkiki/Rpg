using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
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
