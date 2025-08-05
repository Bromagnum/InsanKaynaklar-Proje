using DAL.Entities.Abstracts;
using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Personel:BaseEntity
    {
        
        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public string TCNo { get; set; }

        public string TelefonNo { get; set; }
        public DateOnly DogumTarihi { get; set; }

        public string EgitimDurumu { get; set; }

        public string SGKNo { get; set; }

        public decimal Maas { get; set; }

        public MedeniHal MedeniHal { get; set; }
        public Askerlik Askerlik { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

    }
}
