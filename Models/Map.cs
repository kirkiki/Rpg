namespace Rpg.Models
{
    class Map
    {

        private static string _sol = "-";
        private static string _arbre = "O";
        private static string _maison = "A";
        private static string _eau = "~";
        private static string _pnj = "L";

        private static string H = _maison;
        private static string O = _sol;
        private static string I = _arbre;
        private static string E = _eau;
        private static string D = _pnj;

        private string[,] _plan = new string[,]
        {
            {I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,I,I,I,I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,I,I,I,I,I,I,I,I,I,I,I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,H,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,D,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,I},
            {I,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,E,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I}
        };

        Joueur _joueur = new Joueur("Ronan");
        Pnj _npc = new Pnj(new Position(0,0));

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