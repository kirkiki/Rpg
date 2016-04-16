using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Controllers;
using Rpg.Models;

namespace Rpg.Views
{
    class InventaireView
    {

         private InventaireControler _ivControler;
     

        public InventaireView(InventaireControler pivControler)
        {
            _ivControler = pivControler;
        }

        public void GetInfoTouche(ConsoleKeyInfo cki)
        {
            _ivControler.Input(cki.Key);
        }

        public void Display(Joueur Perso)
        {
            Console.Clear();
            Console.WriteLine("-------- Perso -------");
            Console.WriteLine("Nom :" + Perso.Nom);
            Console.WriteLine("Pv :" + Perso.Currentvie + "/" + Perso.Vie);
            Console.WriteLine("Attaque :" + Perso.Attaque + " - Defense :" + Perso.Defense);

            Console.WriteLine("-------- Inventaire -------");
            for (int i = 0; i < Perso.Sac.Count() - 1; i++)
            {
                Console.WriteLine(i + 1 + ")" + ItemControler.GetName(Perso.Sac[i]) + " = " + ItemControler.GetDesc(Perso.Sac[i]));
                Console.WriteLine("->" + ItemControler.GetEff(Perso.Sac[i]));

            }

            Console.WriteLine("-------- Equipement -------");
            for (int i = 0; i < Perso.Stuff.Count() - 1; i++)
            {
                Console.WriteLine(i + 1 + ")" + ItemControler.GetName(Perso.Stuff[i]) + " = " + ItemControler.GetDesc(Perso.Stuff[i]));
                Console.WriteLine("->" + ItemControler.GetEff(Perso.Stuff[i]));
            }


        }

    }
}
