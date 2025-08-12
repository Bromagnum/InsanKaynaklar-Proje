using DAL.Repositories.Abstracts;
using DAL.Repositories.Concretes;
using DAL.Entities.Abstracts;
using DAL.Entities.Concretes;
using DAL.Context;
using System.Threading.Tasks;
namespace CA_InsanKaynaklarıProje
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var context = new IKDbContext();
            var personelRepository = new BaseRepository<Personel>(context);

            var personel = new Personel
            {
                Ad = "Ahmet",
                SoyAd = "Yılmaz",
                Email = "ahmet.yilmaz@example.com",
                TCNo = "12345678901",
                TelefonNo = "5551234567",
                DogumTarihi = new DateOnly(1990, 1, 1),
                EgitimDurumu = "Lisans",
                SGKNo = "SGK123456",
                Maas = 10000,
                MedeniHal = 0,
                Askerlik = 0,
                Cinsiyet = 0,


            };
            
            try
            {
                var result = await personelRepository.CreateAsync(personel);
                if (result.Success)
                {
                    Console.WriteLine("Personel başarıyla eklendi.");
                }
                else
                {
                    Console.WriteLine("Personel eklenemedi.");
                }

            }catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            //var deletedPersonel = personelRepository.DeleteAsync(personel);
            //if (deletedPersonel != null)
            //{
            //    Console.WriteLine("Personel başarıyla silindi.");
            //}
            //else
            //{
            //    Console.WriteLine("Personel silinemedi.");
            //}

            //personel.Ad = "Mehmet";
            //personel.SoyAd = "Demir";
            //personel.Email = "falanfilan@gmail.com";
            //var updatedPersonels = personelRepository.UpdateAsync(personel);
            //if (updatedPersonels.Status == 0)
            //{
            //    Console.WriteLine("Personel başarıyla güncellendi.");
            //}
            //else
            //{
            //    Console.WriteLine("Personel güncellenemedi.");
            //}
        }
    }

}
