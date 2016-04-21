using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Models
{
    class Item
    {
        protected string nom, description, destroyDescription, effet, destroyEffet;

        
        protected bool equipable, consommable;
        protected int bpv, battaque, bdefense; //bonus
        protected int durabilite;

        

        public Item()
        {

        }

        public Item(string pnom, string pdescription, string pdestroyDescription, string peffet, string pdestroyEffet, bool pequipable, bool pconsommable, int pbpv, int pbattaque, int pbdefense, int pdurabilité)
        {
            this.nom = pnom;
            this.description = pdescription;
            this.destroyDescription = pdestroyDescription;
            this.destroyEffet = pdestroyEffet;
            this.effet = peffet;
            this.equipable = pequipable;
            this.consommable = pconsommable;
            this.bpv = pbpv;
            this.battaque = pbattaque;
            this.bdefense = pbdefense;
            this.durabilite = pdurabilité;

            
        }


        public void DuraDown()
        {
            durabilite--;
            if (durabilite <= 0)
            {
                bpv = 0;
                battaque = 0;
                bdefense = 0;

                effet = destroyEffet;
                description = destroyDescription;
            }
        }

        public string DestroyEffet
        {
            get { return destroyEffet; }
            set { destroyEffet = value; }
        }

        public string DestroyDescription
        {
            get { return destroyDescription; }
            set { destroyDescription = value; }
        }
        
        public int Durabilite
        {
            get { return durabilite; }
            set { durabilite = value; }
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
