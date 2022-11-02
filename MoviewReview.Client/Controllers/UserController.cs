using Microsoft.AspNetCore.Mvc;
using MovieReview.Core.Domain.Entities;
using MoviewReview.Client.Models;
using MoviewReview.WebApp.Services.Interfaces;
using Refit;

namespace MoviewReview.WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel user)
        {
            var apiClient = RestService.For<IMovieReviewApi>("https://localhost:7240/api");

            var token = apiClient.LoginAsync(user);

            return View(token);
        }
    }
}
