using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class MaisonView
    {
        HomeControler hmc;
        Maison maison;

        public MaisonView(Maison pMaison)
        {
            maison = pMaison;
        }

        public void Display()
        {
            Console.Clear();
            for (int i = 0; i <= maison.getLongueur(); i++)
            {
                for (int j = 0; j <= maison.getLargeur(); j++)
                {
                    if (maison.Joueur.Position.X == j && maison.Joueur.Position.Y == i)
                    {
                        Console.Write(maison.Joueur.Embleme);
                        j++;
                    }
                    Console.Write(maison.getMaisonBloc(i,j));
                }
                Console.WriteLine();
            }
        }
    }
}
