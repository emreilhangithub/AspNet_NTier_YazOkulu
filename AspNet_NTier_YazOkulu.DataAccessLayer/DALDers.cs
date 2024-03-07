using AspNet_NTier_YazOkulu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet_NTier_YazOkulu.DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM TBLDERSLER", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ent = new EntityDersler();
                ent.ID = Convert.ToInt32(dr["DERSID"]);
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MIN = Convert.ToInt32(dr["DERSMINKONT"]);
                ent.MAX = Convert.ToInt32(dr["DERSMAXKONT"]);
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuruForm entityBasvuruForm)
        {
           
            SqlCommand komut = new SqlCommand(@"INSERT INTO [dbo].[TBLBASVURUFORM]
            ([OGRRENCIID]
            ,[DERSID])
            VALUES(@OGRRENCIID,@DERSID)", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@OGRRENCIID", entityBasvuruForm.BASOGRID);
            komut.Parameters.AddWithValue("@DERSID", entityBasvuruForm.BASDERSID);
            return komut.ExecuteNonQuery();
        }

    }
}
