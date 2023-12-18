using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EstateService : IEstateService
    {
        private readonly IRepository<Estate> _estateRepository;

        public EstateService(IRepository<Estate> estateRepository)
        {
            _estateRepository = estateRepository;
        }

        public IEnumerable<Estate> GetAllEstates()
        {
            return _estateRepository.GetAll();
        }

        public Estate GetEstateById(int id)
        {
            return _estateRepository.GetById(id);
        }

        public void AddEstate(Estate estate)
        {
            _estateRepository.Insert(estate);
        }

        public void UpdateEstate(Estate estate)
        {
            _estateRepository.Update(estate);
        }

        public void DeleteEstate(int id)
        {
            _estateRepository.Delete(id);
        }
    }
}
