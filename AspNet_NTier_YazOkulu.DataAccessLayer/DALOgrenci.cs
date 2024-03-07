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

        public static List<EntityOgrenci> OgrenciListesi ()
        {
            List<EntityOgrenci> degerler  = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLOGRENCI", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["OGRID"]);
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("DELETE FROM TBLOGRENCI WHERE OGRID = @OGRID", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@OGRID", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }


        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM TBLOGRENCI WHERE OGRID = @OGRID", Baglanti.bgl);
            komut4.Parameters.AddWithValue("OGRID", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }          
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.AD = dr["OGRAD"].ToString();
                ent.SOYAD = dr["OGRSOYAD"].ToString();
                ent.NUMARA = dr["OGRNUMARA"].ToString();
                ent.FOTOGRAF = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci parametre)
        {
            SqlCommand komut5 = new SqlCommand(@"UPDATE [dbo].[TBLOGRENCI]
                                               SET [OGRAD] = @OGRAD
                                                  ,[OGRSOYAD] = @OGRSOYAD
                                                  ,[OGRNUMARA] = @OGRNUMARA
                                                  ,[OGRFOTO] = @OGRFOTO
                                                  ,[OGRSIFRE] = @OGRSIFRE
                                                  ,[OGRBAKIYE] = @OGRBAKIYE
                                                WHERE OGRID = @OGRID", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@OGRAD", parametre.AD);
            komut5.Parameters.AddWithValue("@OGRSOYAD", parametre.SOYAD);
            komut5.Parameters.AddWithValue("@OGRNUMARA", parametre.NUMARA);
            komut5.Parameters.AddWithValue("@OGRFOTO", parametre.FOTOGRAF);
            komut5.Parameters.AddWithValue("@OGRSIFRE", parametre.SIFRE);
            komut5.Parameters.AddWithValue("@OGRBAKIYE", parametre.BAKIYE);
            komut5.Parameters.AddWithValue("@OGRID", parametre.ID);
            return komut5.ExecuteNonQuery() > 0;
        }

    }
}
