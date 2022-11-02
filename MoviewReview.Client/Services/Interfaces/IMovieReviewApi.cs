using Microsoft.AspNetCore.Mvc;
using MovieReview.Core.Domain.Entities;
using Refit;

namespace MoviewReview.WebApp.Services.Interfaces
{
    public interface IMovieReviewApi
    {
        [Post("/User/Login")]
        Task<Dictionary<string, string>> LoginAsync([FromBody] User user);
    }
}
