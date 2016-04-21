using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Controllers;
using Rpg.Models;

namespace Rpg.Views
{
    class CombatView
    {
        private CombatControler _cbControler;
        public CombatView(CombatControler pcbControler)
        {
            _cbControler = pcbControler;
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Vous etes en combat avec un "+_cbControler.CombatEnemi.Nom1);
            Console.WriteLine("Vie du "+ _cbControler.CombatEnemi.Nom1+": "+_cbControler.CombatEnemi.Vie1);
            Console.WriteLine("1:coup d'épée");
            Console.WriteLine("2:sort");

        }

        public void EcranFin(string ploot)
        {
            Console.Clear();
            Console.WriteLine("vous avez vaincu cet Enemi!");
            Console.WriteLine("vous avez gagné " + ploot); 
            Console.WriteLine("appuyez sur entrée");
        }

        public void attaqueJoueur(int damage, Enemi _combatEnemi)
        {
            Console.Clear();

            Console.WriteLine("Vous avez lancé un coup d'épée");
            Console.WriteLine("Vous infligez " + damage + " a " + _combatEnemi.Nom);
            
            Console.WriteLine();
            
        }

        public void lancerSort()
        {
            Console.Clear();

            Console.WriteLine("vous avez lancé un sort");
            Console.WriteLine();
            
        }

        public void attaqueEnnemi(int damage, Enemi _combatEnemi, Joueur _perso)
        {
            Console.WriteLine(_combatEnemi.Nom + "vous attaque!");
            Console.WriteLine("Il vous inflige " + damage + "degats, il vous reste" + _perso.Currentvie + "PV.");

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

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            _cbControler.Input(cki.Key);
        }
    }
}
