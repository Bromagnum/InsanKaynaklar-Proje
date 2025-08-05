using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Bordro:BaseEntity
    {
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }

        public int CalısılanAy { get; set; }

        public int CalısılanYıl { get; set; }

        public decimal MaasTutar { get; set; }

        public decimal Kesinti { get; set; }

        public decimal EkOdeme { get; set; }

        private decimal _netMaas;

        public decimal NetMaas
        {
            get => _netMaas = NetMaas ; 
            set => NetMaas = MaasTutar + EkOdeme - Kesinti ;
        }
    }
}
