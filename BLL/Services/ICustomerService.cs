using BLL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllUsers();
        Customer GetUserById(int id);
        void AddUser(MemberDTO customer);
        void UpdateUser(MemberDTO customer);
        void DeleteUser(int id);
        bool IsExistEmailAndPass(string email, string password);
        UserDTO GetByEmailAndPass(string email, string password);
    }
}
