using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Teskilat:BaseEntity
    {
        public string TeskilatAd { get; set; }

        public int UstTeskilatID { get; set; }
        public Teskilat UstTeskilat { get; set; }

        public string TeskilatTur { get; set; }
    }
}
