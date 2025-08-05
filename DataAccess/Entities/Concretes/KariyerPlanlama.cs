using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class KariyerPlanlama:BaseEntity
    {
        public string MevcutPozisyon { get; set; }
        public string HedefPozisyon { get; set; }

        public string GerekliEgitim { get; set; }

        public int GerekliSüre { get; set; }
    }
}
