using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNet_NTier_YazOkulu.EntityLayer;

namespace AspNet_NTier_YazOkulu.DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand(@"INSERT INTO [dbo].[TBLOGRENCI]
            ([OGRAD]
            ,[OGRSOYAD]
            ,[OGRNUMARA]
            ,[OGRFOTO]
            ,[OGRSIFRE]) VALUES(@OGRAD,@OGRSOYAD,@OGRNUMARA,@OGRFOTO,@OGRSIFRE)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            komut1.Parameters.AddWithValue("@OGRAD", parametre.AD);
            komut1.Parameters.AddWithValue("@OGRSOYAD", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@OGRNUMARA", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@OGRFOTO", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@OGRSIFRE", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
        }
    }
}
