using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Maison : Decor
    {
        Joueur joueur;
        private Position position;
        private string emblemeMaison = "A";
        private static string sol = "-";
        private static string mur = "O";
        private static string porte = "=";
        private static string I=sol ;
        private static string Q=mur ;
        private static string B=porte;
        public string Sol { get { return sol; } }

        public Maison()
        {
            
        }
        public Maison(Position p_position)
        {
            PositionMaison = p_position;
        }
        private string[,] maison = new string[,]
        {
            {Q,Q,Q,Q,Q,Q,Q},
            {Q,I,I,I,I,I,Q},
            {Q,I,I,I,I,I,Q},
            {Q,I,I,I,I,I,Q},
            {Q,I,I,I,I,I,Q},
            {Q,I,I,I,I,I,Q},
            {Q,Q,Q,B,Q,Q,Q}
        };

        public string EmblemeMaison
        {
            get
            {
                return emblemeMaison;
            }
        }

        public Joueur Joueur
        {
            get
            {
                return joueur;
            }

            set
            {
                joueur = value;
            }
        }

        public string Porte
        {
            get
            {
                return porte;
            }
        }

        public Position PositionMaison
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public string getMaisonBloc(int i, int j)
        {
            return maison[i, j];
        }
        public int getLargeur()
        {
            return maison.GetLength(1) - 1;
        }
        public int getLongueur()
        {
            return maison.GetLength(0) - 1;
        }
    }
}
