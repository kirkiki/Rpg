namespace Rpg.Models
{
    class Map
    {

        private static string _sol = " ";
        private static string _arbre = "O";
        private static string _maison = "A";
        private static string _eau = "~";
        private static string _pnj = "L";

        private static string _h = _maison;
        private static string _o = _sol;
        private static string _ = _arbre;
        private static string _e = _eau;
        private static string _d = _pnj;

        private string[,] _plan = new string[,]
        {
            {_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_h,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_o,_e,_e,_e,_},
            {_,_e,_e,_e,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_e,_e,_},
            {_,_e,_e,_e,_o,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_o,_e,_e,_e,_},
            {_,_e,_e,_e,_o,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_o,_o,_o,_d,_o,_o,_o,_o,_o,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_e,_e,_e,_e,_e,_e,_e,_e,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_e,_e,_e,_e,_e,_e,_e,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_o,_},
            {_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_,_}
        };

        Joueur _joueur = new Joueur("Ronan");
        Pnj _npc = new Pnj(new Position(0, 0));

        public string[,] Plan
        {
            get
            {
                return _plan;
            }
        }

        public int GetLargeur()
        {
            return _plan.GetLength(1) - 1;
        }
        public int GetLongueur()
        {
            return _plan.GetLength(0) - 1;
        }
        public Joueur Joueur
        {
            get
            {
                return _joueur;
            }
        }
        public string Sol
        {
            get
            {
                return _sol;
            }
        }
        public string Arbre
        {
            get
            {
                return _arbre;
            }
        }

        public string Maison
        {
            get
            {
                return _maison;
            }
        }

        public string Eau
        {
            get
            {
                return _eau;
            }
        }

        public string Pnj
        {
            get
            {
                return _pnj;
            }

            set
            {
                _pnj = value;
            }
        }

        public Pnj Npc
        {
            get
            {
                return _npc;
            }

            set
            {
                _npc = value;
            }
        }
    }
}