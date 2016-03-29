using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Arbre : Decor
    {
        private string emblemeArbre = "+";
        public Arbre(Position p_position)
        {
            position = p_position;
        }
        public string EmblemeArbre
        {
            get
            {
                return emblemeArbre;
            }
        }
    }
}
