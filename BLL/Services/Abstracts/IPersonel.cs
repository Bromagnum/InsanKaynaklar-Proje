using DAL.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstracts
{
    public interface IPersonel
    {
        Task CreatePersonelAsync(Personel personel);
        Task UpdatePersonelAsync(Personel personel);
        Task DeletePersonelAsync(int personelId);

        Task<Personel> GetPersonelByIdAsync(int personelId);
        Task<List<Personel>> GetAllPersonelsAsync();
    }
}
