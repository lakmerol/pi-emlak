using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IControlRepository<T>
    {
        bool IsExistByEmailAndPassword(string email, string password);
        T GetByEmailAndPassword(string email, string password);
    }
}
