using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Kadro:BaseEntity
    {
        public int TeskilatID { get; set; }

        public Teskilat Teskilat { get; set; }

        public string PozisyonAd { get; set; }
        public int PersonelSayısı { get; set; }
    }
}
