using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IEstateService
    {
        IEnumerable<Estate> GetAllEstates();
        Estate GetEstateById(int id);
        void AddEstate(Estate estate);
        void UpdateEstate(Estate estate);
        void DeleteEstate(int id);
    }
}
