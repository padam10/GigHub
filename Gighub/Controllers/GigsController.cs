using System.Linq;
using System.Web.Mvc;

namespace Gighub.Controllers
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Gighub.Models;
    using Gighub.ViewModels;

    using Microsoft.AspNet.Identity;

    public class GigsController : Controller
    {
        private readonly ApplicationDbContext context;

        public GigsController()
        {
            this.context = new ApplicationDbContext();
        }
       [Authorize]
        public ActionResult Create()
        {
           var viewModel = new GigFormViewModel()
                               {
                                   Genres = this.context.Genres.ToList()
                               };

            return this.View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = context.Genres.ToList();
                return this.View("Create", viewModel);
            }
            var artistId = this.User.Identity.GetUserId();
            var artist = this.context.Users.Single(u => u.Id == artistId);
            var genre = this.context.Genres.Single(g => g.Id == viewModel.Genre);
            var gig = new Gig()
            {
                Artist = artist,
                DateTime = viewModel.GetDateTime(),
                Genre = genre,
                Venue = viewModel.Venue
            };
            this.context.Gigs.Add(gig);
            this.context.SaveChanges();
            return this.RedirectToAction("Index", "Home");
        }
    }
}