using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EstateRepository : IRepository<Estate>
    {
        private readonly ApplicationDbContext _context;

        public EstateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Estate> GetAll()
        {
            return _context.Set<Estate>().ToList();
        }

        public Estate GetById(int id)
        {
            return _context.Set<Estate>().Find(id);
        }

        public void Insert(Estate entity)
        {
            _context.Set<Estate>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Estate entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<Estate>().Find(id);
            if (entity != null)
            {
                _context.Set<Estate>().Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
