using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Controllers;
using Rpg.Models;
using Rpg.Lib;

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

        public void DisplayI(Joueur Perso)
        {
            Console.Clear();

            Console.WriteLine("-------- Menu -------");
            Console.WriteLine("--- O : Objectif --- E : Equipement ---");
            Console.WriteLine("");
            Console.WriteLine("-------- Perso -------");
            Console.WriteLine("Nom :" + Perso.Nom + " Lv " + Perso.Level);
            Console.WriteLine("Pv :" + Perso.Currentvie + "/" + Perso.Vie);
            Console.WriteLine("Attaque :" + Perso.Attaque + " - Defense :" + Perso.Defense);
            Console.WriteLine("EXP : " + Perso.Exp + "/" + Perso.Nextlv);

            Console.WriteLine("-------- Inventaire -------");
            for (int i = 0; i < Perso.Sac.Count(); i++)
            {
                Console.WriteLine(i + 1 + ")" + Perso.Sac[i].Nom + " = " + Perso.Sac[i].Description);
                Console.WriteLine("->" + Perso.Sac[i].Effet + " Durabilité " + Perso.Sac[i].Durabilite);

            }

            Console.WriteLine("-------- Equipement -------");
            for (int i = 0; i < Perso.Stuff.Count(); i++)
            {
                Console.WriteLine(i + 1 + ")" + Perso.Stuff[i].Nom + " = " + Perso.Stuff[i].Description);
                Console.WriteLine("->" + Perso.Stuff[i].Effet + " Durabilité " + Perso.Stuff[i].Durabilite);
            }
        }

        public void DisplayO(Joueur Perso) {
            Console.Clear();

            Console.WriteLine("-------- Objectif -------");
            Console.WriteLine("--- I : Menu --- E : Equipement ---");
            Console.WriteLine("");
            Console.WriteLine("Bonjour "+ Perso.Nom + " Il est temps d'apprendre a nager!");

        }

        public void DisplayE(Joueur Perso, int trigger, int page)
        {
            Console.Clear();

            Console.WriteLine("-------- Equipement -------");
            Console.WriteLine("--- I : Menu --- O : Objectif ---");
            Console.WriteLine("");
            
            
            
            if (trigger == 1)
            {
                Console.Write("--- S : ");
                ConsoleWrite.ColorWrite("Equiper", "red");
                Console.WriteLine(" --- D : Désequiper ---");
                Console.WriteLine();
                Console.WriteLine("--- <-- Changer Page --> ---");
                Console.WriteLine("--- <-- Page " + page + "--> ---");

                for (int i = 5 * page; i < Perso.Sac.Count() && i < 5 * (page +1 ); i++)
                {
                    Console.WriteLine(i - 5*page + 1 + ") " + Perso.Sac[i].Nom + " = " + Perso.Sac[i].Effet + " Durabilité " + Perso.Sac[i].Durabilite);
                }

            }
            else if (trigger == 2)
            {
                Console.Write("--- S : Equiper --- D :");
                ConsoleWrite.ColorWrite(" Désequiper", "red");
                Console.WriteLine(" ---");
                Console.WriteLine();
                Console.WriteLine("--- <-- Changer Page --> ---");
                Console.WriteLine("---    " + page + "    ---");

                for (int i = 5 * page; i < Perso.Stuff.Count() && i < 5 * (page + 1); i++)
                {
                    Console.WriteLine(i - page*5 + 1 + ") " + Perso.Stuff[i].Nom + " = " + Perso.Stuff[i].Effet + " Durabilité " + Perso.Stuff[i].Durabilite);
                }
            }
            else
            {
                Console.WriteLine("--- S : Equiper --- D : Désequiper ---");
            }

        }

    }
}
