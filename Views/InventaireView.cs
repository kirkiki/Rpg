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

    }
}
