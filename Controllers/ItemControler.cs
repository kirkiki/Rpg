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
            Item result = new Item("Name", "Rien du tout", "un rien du tout cassé", "Rien", "Toujours rien en pire", false, false, 20);
            
            switch(nom){
                case "Epee en bois":
                    result.Nom = "Epee en bois";
                    result.Description = "Une simple épée en bois";
                    result.DestroyDescription = "Une epee en bois toute cassée";
                    result.Effet = "+1 Attaque";
                    result.DestroyEffet = "Rien";
                    result.Equipable = true;
                    result.Consommable = false;
                    result.Durabilite = 5;
                    break;
                case "Armure en cuir":
                    result.Nom = "Armure en cuir";
                    result.Description = "Une simple pièce d'armure en cuir";
                    result.DestroyDescription = "Une pièce d'armure en cuir toute cassée";
                    result.Effet = "+1 Defense";
                    result.DestroyEffet = "Rien";
                    result.Equipable = true;
                    result.Consommable = false;
                    result.Durabilite = 5;
                    break;
                case "Palmes":
                    result.Nom = "Palmes";
                    result.Description = "Outil primordial a la nage";
                    result.DestroyDescription = "Ne sert plus a rien";
                    result.Effet = "Webbed";
                    result.DestroyEffet = "Rien";
                    result.Equipable = true;
                    result.Consommable = false;
                    result.Durabilite = 50;
                    break;
                default:
                    result.Nom = nom;
                    break;
            }
            return result;
        }

      

    }
}
