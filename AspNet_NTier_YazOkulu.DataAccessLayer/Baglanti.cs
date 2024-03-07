using System;
using System.Data.SqlClient;
using System.Data;

namespace AspNet_NTier_YazOkulu.DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-I1U4DR9;Initial Catalog=KahveSiparis;Integrated Security=True");
    }
}
