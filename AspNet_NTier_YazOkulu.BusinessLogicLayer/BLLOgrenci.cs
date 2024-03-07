using AspNet_NTier_YazOkulu.DataAccessLayer;
using AspNet_NTier_YazOkulu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet_NTier_YazOkulu.BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
                return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBll (EntityOgrenci p)
        {
            if (p != null && p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }

    }
}
