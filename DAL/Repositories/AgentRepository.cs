using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AgentRepository : IRepository<Agent>, IControlRepository<Agent>
    {
        private readonly ApplicationDbContext _context;

        public AgentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Agent> GetAll()
        {
            return _context.Set<Agent>().ToList();
        }

        public Agent GetById(int id)
        {
            return _context.Set<Agent>().Find(id);
        }
        public void Insert(Agent entity)
        {
            _context.Set<Agent>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Agent entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<Agent>().Find(id);
            if (entity != null)
            {
                _context.Set<Agent>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public bool IsExistByEmailAndPassword(string email, string password)
        {
            return _context.Agents.Any(
       agent =>
       string.Equals(agent.MailAdress, email, StringComparison.OrdinalIgnoreCase) &&
       string.Equals(agent.Password, password, StringComparison.Ordinal)

      );
        }

        public Agent GetByEmailAndPassword(string email, string password)
        {
            return (Agent)_context.Agents.Where(
       agent =>
       (agent.MailAdress == email) &&
       agent.Password == password);

        }


    }
}
