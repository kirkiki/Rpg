namespace Rpg.Models
{
    class Maison : Decor
    {
        Joueur _joueur;
        private Position _position;
        private string _emblemeMaison = "A";
        private static string _sol = "-";
        private static string _mur = "O";
        private static string _porte = "=";
        private static string _=_sol ;
        private static string _q=_mur ;
        private static string _b=_porte;
        public string Sol { get { return _sol; } }

        public Maison()
        {
            
        }
        public Maison(Position pPosition)
        {
            PositionMaison = pPosition;
        }
        private string[,] _maison = new string[,]
        {
            {_q,_q,_q,_q,_q,_q,_q},
            {_q,_,_,_,_,_,_q},
            {_q,_,_,_,_,_,_q},
            {_q,_,_,_,_,_,_q},
            {_q,_,_,_,_,_,_q},
            {_q,_,_,_,_,_,_q},
            {_q,_q,_q,_b,_q,_q,_q}
        };

        public string EmblemeMaison
        {
            get
            {
                return _emblemeMaison;
            }
        }

        public Joueur Joueur
        {
            get
            {
                return _joueur;
            }

            set
            {
                _joueur = value;
            }
        }

        public string Porte
        {
            get
            {
                return _porte;
            }
        }

        public Position PositionMaison
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        public string GetMaisonBloc(int i, int j)
        {
            return _maison[i, j];
        }
        public int GetLargeur()
        {
            return _maison.GetLength(1) - 1;
        }
        public int GetLongueur()
        {
            return _maison.GetLength(0) - 1;
        }
    }
}
