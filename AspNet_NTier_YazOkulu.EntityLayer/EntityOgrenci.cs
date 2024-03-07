using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet_NTier_YazOkulu.EntityLayer
{
    public class EntityOgrenci
    {
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public int ID { get; set; }
        public string NUMARA { get; set; }
        public string FOTOGRAF { get; set; }
        public double BAKIYE { get; set; }
        public string SIFRE { get; set; }
    }
}
