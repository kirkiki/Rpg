using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;

namespace Rpg.Controllers
{
    class ItemControler
    {

      static  public Item Create(string nom)
        {
            Item result = new Item("Name", "Rien du tout", "un rien du tout cassé", "Rien", "Toujours rien en pire", false, false, 0, 0, 0, 20);
            
            switch(nom){
                case "Epee en bois":
                    result.Nom = "Epee en bois";
                    result.Description = "Une simple épée en bois";
                    result.DestroyDescription = "Une epee en bois toute cassée";
                    result.Effet = "+1 Attaque";
                    result.DestroyEffet = "Rien";
                    result.Equipable = true;
                    result.Consommable = false;
                    result.Bpv = 0;
                    result.Battaque = 1;
                    result.Bdefense = 0;
                    result.Durabilite = 5;

                    break;
                default:
                    result.Nom = nom;
                    break;
            }
            return result;
        }

      

    }
}
