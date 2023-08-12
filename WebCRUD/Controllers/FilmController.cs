using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCRUD.DAL;
using WebCRUD.Models.ViewModel;

namespace WebCRUD.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmDBContext _filmDBContext;
        public IActionResult Index()
        {
            return View(_filmDBContext.Films.ToList());
        }

        public FilmController(FilmDBContext filmDBContext)
        {
            _filmDBContext=filmDBContext;
        }

        public IActionResult Details(int? id)
        {
            //Eager loading Kullanımı
            //var film=_filmDBContext.Films.Include(x=>x.Category).Include(x=>x.Actors).ThenInclude(x=>x.Actor).Where(x=>x.FilmID==id).FirstOrDefault();

            //Lazy Loading Kullanımı için Yazılmıştır.
            var film=_filmDBContext.Films.Include(x=>x.Category).Where(x=>x.FilmID==id).FirstOrDefault();

            FilmDetailVM filmDetailVM = new FilmDetailVM()
            {
                FilmID=film.FilmID,
                FilmName=film.FilmName,
                Duration=film.Duration,
                Description=film.Description,
                CategoryName=film.Category.CategoryName,
            }; 
            foreach(var actor in film.Actors)
            {
                ActorVM actorVM = new ActorVM()
                {
                    ActorID = actor.ActorID,
                    FirstName = actor.Actor.FirstName,
                    LastName = actor.Actor.LastName,
                    ActorRole=actor.ActorRole

                };
                filmDetailVM.Actors.Add(actorVM);
            }
            return View(filmDetailVM);
        }

    }
}
