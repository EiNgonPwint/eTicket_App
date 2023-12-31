﻿using eTicket.Data.Base;
using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

       

        public async Task<Movie> GetMovieById(int id)
        {
            var movieDetails = await _context.Movies.
                Include(c=>c.Cinema)
                .Include(p=>p.Producer)
                .Include(am=>am.Actor_Movies).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);
            return  movieDetails;
        }
    }
}
