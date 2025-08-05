using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class GorevDagılım:BaseEntity
    {
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }

        public int TeskilatId { get; set; }

        public Teskilat Teskilat { get; set; }

        public string PozisyonAd { get; set; }

        public DateOnly BaslamaTarih { get; set; }

        public DateOnly BıtısTarih { get; set; }
    }
}
