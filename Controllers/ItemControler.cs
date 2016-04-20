using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Controllers
{
    class ItemControler
    {
     
        static public int GetIndex(string pnom)
        {
            int index = 0;
            switch (pnom)
            {
                case "Epee en bois":
                    index = 1;
                    break;
                default :
                    index = 0;
                    break;
            }
            return index;
        }

        static public string GetDesc(int index)
        {
            string desc = null;
            switch (index)
            {
                case 1:
                    desc = "Un simple jouet";
                    break;
                default:
                    desc = "rien du tout";
                    break;
            }
            return desc;
        }

        static public string GetName(int index)
        {
            string Name = null;
            switch (index)
            {
                case 1:
                    Name = "Epee en bois";
                    break;
                default:
                    Name = "rien du tout";
                    break;
            }
            return Name;
        }

        static public string GetEff(int index)
        {
            string Eff = null;
            switch (index)
            {
                case 1:
                    Eff = "A+1";
                    break;
                default:
                    Eff = "(-)";
                    break;
            }
            return Eff;
        }
    }
}
