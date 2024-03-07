using AspNet_NTier_YazOkulu.DataAccessLayer;
using AspNet_NTier_YazOkulu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet_NTier_YazOkulu.BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDersler> BllListele()
        {
            return DALDers.DersListesi();
        }

        public static int TalepEkleBll(EntityBasvuruForm p)
        {
            if(p.BASOGRID != null && p.BASDERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
