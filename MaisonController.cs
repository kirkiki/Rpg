using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class MaisonController : Controller

    {
        public MaisonView mav { get; private set; }
        public Maison maison = new Maison();
        private bool isEnter = false;
        private MapControler mapControler;


        public MaisonController(MapControler pMapControler)
        {
            mav = new MaisonView(maison);
            mapControler = pMapControler;
        }

        public bool IsEnter
        {
            get
            {
                return isEnter;
            }

            set
            {
                isEnter = value;
            }
        }

        public void Entrer(Joueur pJoueur)
        {
            maison.Joueur = pJoueur;
            maison.Joueur.Position = new Position(3, 1);
            mav.Display();
        }

        public void Move()
        {
            Position nextPos = new Position(maison.Joueur.Position.X + maison.Joueur.VelociteX, maison.Joueur.Position.Y + maison.Joueur.VelociteY);

            if (nextPos.Y > maison.getLongueur() || nextPos.X > maison.getLargeur())
            {
                maison.Joueur.Bouger(0, 0);
            }
            else if (nextPos.X < 0 || nextPos.Y < 0)
            {
                maison.Joueur.Bouger(0, 0);
            }
            else if (maison.getMaisonBloc(nextPos.Y, nextPos.X) == maison.Sol)
            {
                maison.Joueur.Position = nextPos;
            }
            else if(maison.getMaisonBloc(nextPos.Y,nextPos.X)==maison.Porte)
            {
                mapControler.map.Joueur.Position=new Position(6,8);
                isEnter = false;
            }
            else {
                maison.Joueur.Bouger(0, 0);
            }
        }
    }
}
