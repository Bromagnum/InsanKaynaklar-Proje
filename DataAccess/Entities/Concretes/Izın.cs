using DAL.Entities.Abstracts;
using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Izın:BaseEntity
    {
        public int PersonelID { get; set; }

        public Personel Personel { get; set; }

        public DateOnly IzınBaslangıcTarih { get; set; }

        public DateOnly IzınBıtısTarih { get; set; }

        public Onay Onay { get; set; }

    }
}
