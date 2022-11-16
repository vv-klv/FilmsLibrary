using FilmsLibrary.Data.Interfaces;
using FilmsLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace FilmsLibrary.Data.Repository
{
    public class Repository : IFilmRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<EntityEntry<Film>> Create(Film Model)
        {
            return await _context.films.AddAsync(Model);
        }

        public async Task<bool> Delete(int Id)
        {
            if (Id > 0)
            {
                var oldModel = await _context.films.FirstOrDefaultAsync(o => o.Id == Id);
                if (oldModel != null)
                {
                    _context.films.Remove(oldModel);
                    return true;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Film>> GetAll()
        {
            return await _context.films.ToListAsync();
        }

        public async Task<Film> GetById(int Id)
        {
            return await _context.films.FirstOrDefaultAsync(o => o.Id == Id);
        }

        public async Task<EntityEntry<Film>> Update(Film Model, int Id)
        {
            if (Id > 0)
            {
                var oldModel = await _context.films.FirstOrDefaultAsync(o => o.Id == Id);
                if (oldModel != null)
                {
                    Model.Id = Id;
                    return _context.films.Update(Model);
                }
            }
            return null;
        }
    }
}
