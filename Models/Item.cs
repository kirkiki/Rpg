using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Models
{
    class Item
    {
        protected string nom, description, effet;
        protected bool equipable, consommable;
        protected int bpv, battaque, bdefense; //bonus

        public Item()
        {

        }

        public Item(string pnom, string pdescription, string peffet, bool pequipable, bool pconsommable, int pbpv, int pbattaque, int pbdefense)
        {
            this.nom = pnom;
            this.description = pdescription;
            this.effet = peffet;
            this.equipable = pequipable;
            this.consommable = pconsommable;
            this.bpv = pbpv;
            this.battaque = pbattaque;
            this.bdefense = pbdefense;
        }

        public int Bdefense
        {
            get { return bdefense; }
            set { bdefense = value; }
        }

        public int Battaque
        {
            get { return battaque; }
            set { battaque = value; }
        }

        public int Bpv
        {
            get { return bpv; }
            set { bpv = value; }
        }

       public bool Consommable
       {
           get { return consommable; }
           set { consommable = value; }
       }

       public bool Equipable
       {
           get { return equipable; }
           set { equipable = value; }
       }

       public string Effet
       {
           get { return effet; }
           set { effet = value; }
       }

       public string Description
       {
           get { return description; }
           set { description = value; }
       }

       public string Nom
       {
           get { return nom; }
           set { nom = value; }
       }
    }
}
