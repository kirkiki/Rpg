using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class MaisonView
    {
        HomeControler _hmc;
        Maison _maison;

        public MaisonView(Maison pMaison)
        {
            _maison = pMaison;
        }

        public void Display()
        {
            Console.Clear();
            for (int i = 0; i <= _maison.GetLongueur(); i++)
            {
                for (int j = 0; j <= _maison.GetLargeur(); j++)
                {
                    if (_maison.Joueur.Position.X == j && _maison.Joueur.Position.Y == i)
                    {
                        Console.Write(_maison.Joueur.Embleme);
                        j++;
                    }
                    Console.Write(_maison.GetMaisonBloc(i,j));
                }
                Console.WriteLine();
            }
        }
    }
}
