using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CustomerRepository : IRepository<Customer>, IControlRepository<Customer>
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetAll()
        {
            return _context.Set<Customer>().ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Set<Customer>().Find(id);
        }
        public void Insert(Customer entity)
        {
            _context.Set<Customer>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<Customer>().Find(id);
            if (entity != null)
            {
                _context.Set<Customer>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public bool IsExistByEmailAndPassword(string email, string password)
        {
            return _context.Customers.Any(
       agent =>
       string.Equals(agent.MailAdress, email, StringComparison.OrdinalIgnoreCase) &&
       string.Equals(agent.Password, password, StringComparison.Ordinal)

      );
        }

        public Customer GetByEmailAndPassword(string email, string password)
        {
            return (Customer)_context.Customers.Where(
       customer =>
       (customer.MailAdress == email) &&
       customer.Password == password);

        }
    }

}

