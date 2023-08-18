﻿using eTicket.Data.Base;
using eTicket.Models;

namespace eTicket.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieById(int id);
    }
}
