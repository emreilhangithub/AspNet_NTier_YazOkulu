using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet_NTier_YazOkulu.DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-I1U4DR9;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
