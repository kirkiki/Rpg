namespace Rpg
{
    class Map
    {

        private static string sol = "-";
        private static string arbre = "O";
        private static string maison = "A";
        private static string eau = "~";
        private static string pnj = "L";

        private static string H = maison;
        private static string O = sol;
        private static string I = arbre;
        private static string E = eau;
        private static string D = pnj;

        private string[,] plan = new string[,]
        {
            {I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I,I},
            {I,I,O,I,I,I,O,O,O,O,O,I,E,E,E,E,E,E,E,I},
            {I,O,O,I,O,O,O,I,I,I,O,I,E,E,E,E,E,E,E,I},
            {I,I,I,O,O,I,I,I,I,I,O,I,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,I,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,I,O,O,O,O,O,O,O,I},
            {I,O,O,D,O,O,H,O,O,O,O,I,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,I,O,O,O,O,O,O,O,I},
            {I,O,O,O,O,O,O,O,O,O,O,I,O,O,O,O,O,O,O,I}
        };

        Joueur joueur = new Joueur("Ronan");
        Pnj npc = new Pnj(new Position(0,0));

        public string[,] Plan
        {
            get
            {
                return plan;
            }
        }

        public int getLargeur()
        {
            return plan.GetLength(1) - 1;
        }
        public int getLongueur()
        {
            return plan.GetLength(0) - 1;
        }
        public Joueur Joueur
        {
            get
            {
                return joueur;
            }
        }
        public string Sol
        {
            get
            {
                return sol;
            }
        }
        public string Arbre
        {
            get
            {
                return arbre;
            }
        }

        public string Maison
        {
            get
            {
                return maison;
            }
        }

        public string Eau
        {
            get
            {
                return eau;
            }
        }

        public string Pnj
        {
            get
            {
                return pnj;
            }

            set
            {
                pnj = value;
            }
        }

        internal Pnj Npc
        {
            get
            {
                return npc;
            }

            set
            {
                npc = value;
            }
        }
    }
}