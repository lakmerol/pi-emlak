using BLL.DTOs;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository<Agent> _agentRepository;
        private readonly IControlRepository<Agent> _controlRepository;

        public AgentService(IRepository<Agent> agentrepository, IControlRepository<Agent> controlRepository)
        {
            _agentRepository = agentrepository;
            _controlRepository = controlRepository;
        }

        public IEnumerable<Agent> GetAllUsers()
        {
            return _agentRepository.GetAll();
        }

        public Agent GetUserById(int id)
        {
            return _agentRepository.GetById(id);
        }

        public void AddUser(Agent user)
        {
            _agentRepository.Insert(user);
        }

        public void UpdateUser(Agent user)
        {
            _agentRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            _agentRepository.Delete(id);
        }

        public bool IsExitsByEmailAndPass(string email, string password)
        {
            return _controlRepository.IsExistByEmailAndPassword(email, password);
        }

        public UserDTO GetByEmailAndPass(string email, string password)
        {
            return new UserDTO()
            {
                Id = _controlRepository.GetByEmailAndPassword(email, password).ID
        };
        }


    }
}
