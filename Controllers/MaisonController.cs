using Rpg.Models;
using Rpg.Views;

namespace Rpg.Controllers
{
    class MaisonController : Controller

    {
        public MaisonView Mav { get; private set; }
        //Position position=new Position(3,5);//a changer si on bouge la maison
        public Maison Maison = new Maison(new Position(3, 5));
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
            Maison.Joueur.Position = new Position(3, 5);
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
            else if (Maison.GetMaisonBloc(nextPos.Y, nextPos.X) == Maison.Porte)
            {
                _mapControler.Map.Joueur.Position = new Position(Maison.PositionMaison.X, Maison.PositionMaison.Y + 1);
                _isEnter = false;
            }
            else {
                Maison.Joueur.Bouger(0, 0);
            }
        }
    }
}
