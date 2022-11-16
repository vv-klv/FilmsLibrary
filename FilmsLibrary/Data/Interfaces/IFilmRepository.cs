using FilmsLibrary.Models;
using FilmsLibrary.Models.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FilmsLibrary.Data.Interfaces
{
    public interface IFilmRepository
    {
        Task SaveChangesAsync();

        Task<EntityEntry<Film>> Create(Film Model);

        Task<Film> GetById(int Id);

        Task<EntityEntry<Film>> Update(Film Model, int Id);

        Task<bool> Delete(int Id);

        Task<IEnumerable<Film>> GetAll();

    }
}
