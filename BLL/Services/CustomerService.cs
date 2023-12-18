using AutoMapper;
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
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IControlRepository<Customer> _controlRepository;
        private readonly IMapper _mapper;
        public CustomerService(IRepository<Customer> customerRepository, IControlRepository<Customer> controlRepository, IMapper mapper )
        {
            _customerRepository = customerRepository;
            _controlRepository = controlRepository;
            _mapper = mapper;
        }

        public IEnumerable<Customer> GetAllUsers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetUserById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public void AddUser(MemberDTO customer)
        {
            _customerRepository.Insert(_mapper.Map<Customer>(customer));
        }

        public void UpdateUser(MemberDTO customer)
        {
            _customerRepository.Update(_mapper.Map<Customer>(customer));
        }

        public void DeleteUser(int id)
        {
            _customerRepository.Delete(id);
        }

        public bool IsExistEmailAndPass(string email, string password)
        {
          return _controlRepository.IsExistByEmailAndPassword(email, password);
        }

        public UserDTO GetByEmailAndPass(string email, string password)
        {
            Customer customer = _controlRepository.GetByEmailAndPassword(email, password);
                return new UserDTO()
                {
                    Id = customer.ID
                };
        }
    }
}
