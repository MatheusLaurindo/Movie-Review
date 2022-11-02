﻿using MovieReview.Database.Repositories.Base;
using MovieReview.Database.Repositories.Interfaces;
using MovieReview.Database.Repositories.Interfaces.Base;
using MovieReview.Core.Domain.Entities;

namespace MovieReview.Database.Repositories
{
    public class ScreenwriterRepository : GenericRepository<Screenwriter>, IScreenwriterRepository
    {
    }
}
