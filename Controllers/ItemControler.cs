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
            Item result = new Item("Name", "Rien du tout", "Rien", false, false, 0, 0, 0);
            
            switch(nom){
                case "Epee en bois":
                    result.Nom = "Epee en bois";
                    result.Description = "Une simple épée en bois";
                    result.Effet = "+1 Attaque";
                    result.Equipable = true;
                    result.Consommable = false;
                    result.Bpv = 0;
                    result.Battaque = 1;
                    result.Bdefense = 0;
                    break;
                default:
                    break;
            }
            return result;
        }

      

    }
}
