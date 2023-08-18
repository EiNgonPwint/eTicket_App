using eTicket.Data.Base;
using eTicket.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>, IActorsService
    {

        private readonly AppDbContext _context;
       

        public ActorService(AppDbContext context) : base(context)
        {
           
        }
      /*  public async Task AddAsync(Actor actor)
        {
            await _context.Actor.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

      
        public async Task  DeleteAsync(int id)
        {
            var result = await _context.Actor.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actor.Remove(result);
            await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actor.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actor.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
            var result = await _context.Actor.FirstOrDefaultAsync(n => n.Id == id);
            if(result == null)
            {
                return null;
            }


            result.ProfilePictureURL = actor.ProfilePictureURL;
            result.FullName = actor.FullName;
            result.Bio = actor.Bio;
            *//*_context.Update(actor);*//*
            await _context.SaveChangesAsync();
            return actor;
        }*/

       
    }
}
