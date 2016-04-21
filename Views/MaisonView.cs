using System;
using Rpg.Controllers;
using Rpg.Models;

namespace Rpg.Views
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
                    Console.Write(_maison.GetMaisonBloc(i, j));
                }
                Console.WriteLine();
            }
        }


        public void keblo()
        {
            Console.Clear();
            Console.WriteLine("Soudain les portes se referment");
            Console.WriteLine("Vous êtes enfermé a jamais");
            Console.WriteLine("Appuyez sur une touche");
        }

        public void GameOver(int random)
        {
            string txt = "";
            switch (random)
            {
                case 0:
                    txt = "Vous êtes mort";
                    break;
                case 1:
                    txt = "Game Over";
                    break;
                case 2:
                    txt = "Vous êtes nul quand même";
                    break;
                case 3:
                    txt = "Vous me devez un kebab";
                    break;
                default:
                    break;
            }
            Console.WriteLine(txt);
        }

    }

     
}
