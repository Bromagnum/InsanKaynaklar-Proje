using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Concretes
{
    public class Malzeme:BaseEntity
    {
        public int TeskilatId { get; set; }
        public Teskilat Teskilat { get; set; }

        public string MalzemeAd { get; set; }

        public int MalzemeMiktar { get; set; }

        public string MalzemeBirim { get; set; }//KG,KW,Watt vb.
    }
}
