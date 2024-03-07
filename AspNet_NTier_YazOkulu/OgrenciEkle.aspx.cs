using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AspNet_NTier_YazOkulu.BusinessLogicLayer;
using AspNet_NTier_YazOkulu.EntityLayer;

namespace AspNet_NTier_YazOkulu
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}