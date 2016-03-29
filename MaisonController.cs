using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class MaisonController : Controller

    {
        public MaisonView Mav { get; private set; }
        public Maison Maison = new Maison();
        private bool _isEnter = false;
        private MapControler _mapControler;


        public MaisonController(MapControler pMapControler)
        {
            Mav = new MaisonView(Maison);
            _mapControler = pMapControler;
        }

        public bool IsEnter
        {
            get
            {
                return _isEnter;
            }

            set
            {
                _isEnter = value;
            }
        }

        public void Entrer(Joueur pJoueur)
        {
            Maison.Joueur = pJoueur;
            Maison.Joueur.Position = new Position(3, 1);
            Mav.Display();
        }

        public void Move()
        {
            Position nextPos = new Position(Maison.Joueur.Position.X + Maison.Joueur.VelociteX, Maison.Joueur.Position.Y + Maison.Joueur.VelociteY);

            if (nextPos.Y > Maison.GetLongueur() || nextPos.X > Maison.GetLargeur())
            {
                Maison.Joueur.Bouger(0, 0);
            }
            else if (nextPos.X < 0 || nextPos.Y < 0)
            {
                Maison.Joueur.Bouger(0, 0);
            }
            else if (Maison.GetMaisonBloc(nextPos.Y, nextPos.X) == Maison.Sol)
            {
                Maison.Joueur.Position = nextPos;
            }
            else if(Maison.GetMaisonBloc(nextPos.Y,nextPos.X)==Maison.Porte)
            {
                _mapControler.Map.Joueur.Position=new Position(6,8);
                _isEnter = false;
            }
            else {
                Maison.Joueur.Bouger(0, 0);
            }
        }
    }
}
