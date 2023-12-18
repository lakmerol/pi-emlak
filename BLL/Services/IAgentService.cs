using BLL.DTOs;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IAgentService
    {
        IEnumerable<Agent> GetAllUsers();
        Agent GetUserById(int id);
        void AddUser(Agent user);
        void UpdateUser(Agent user);
        void DeleteUser(int id);
        bool IsExitsByEmailAndPass(string email, string password);
        UserDTO GetByEmailAndPass(string email, string password);

    }
}
