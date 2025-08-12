using BLL.Services.Abstracts;
using DAL.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Concretes
{
    public class PersonelService : IPersonel
    {
        public Task CreatePersonelAsync(Personel personel)
        {
            throw new NotImplementedException();
        }

        public Task DeletePersonelAsync(int personelId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Personel>> GetAllPersonelsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Personel> GetPersonelByIdAsync(int personelId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePersonelAsync(Personel personel)
        {
            throw new NotImplementedException();
        }
    }
}
