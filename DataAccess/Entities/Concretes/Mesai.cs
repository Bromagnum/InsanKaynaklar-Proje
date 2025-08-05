using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Mesai:BaseEntity
    {
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }

        public DateOnly Tarih { get; set; }

        public TimeOnly GirisSaat { get; set; }

        public TimeOnly CıkısSaat { get; set; }
    }
}
