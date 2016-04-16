using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;
using Rpg.Views;

namespace Rpg.Controllers
{
    class InventaireControler
    {

        private MapControler _mpc;
        private InventaireView _ivView;

        public InventaireControler(MapControler pMapControler)
        {
            _mpc = pMapControler;
            _ivView = new InventaireView(this);

        }

    }
}
