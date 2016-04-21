using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Rpg.Models;
using Rpg.Views;

namespace Rpg.Controllers
{
    class MaisonController : Controller

    {
        public MaisonView Mav { get; private set; }
        //a changer si on bouge la maison
        public Maison Maison = new Maison(new Position(15,0));
        private bool _isEnter = false;
        private MapControler _mapControler;
        private int compteur = 0;

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
                compteur++;
                if (compteur >= 5)
                {
                    Mav.keblo();
                    ConsoleKeyInfo enter = Console.ReadKey();
                   
                    Random random = new Random((int)DateTime.Now.Ticks);
                    while (true)
                    {
                        int txt = random.Next(0, 4);

                        Mav.GameOver(txt); 
                    }
                    
                }
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
