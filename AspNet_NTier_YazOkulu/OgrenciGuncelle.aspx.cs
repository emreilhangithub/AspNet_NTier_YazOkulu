using AspNet_NTier_YazOkulu.BusinessLogicLayer;
using AspNet_NTier_YazOkulu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_NTier_YazOkulu
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int OGRID = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TxtId.Text = OGRID.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false) //bunu demeyince guncelleme işlemi olmuyormus
            { 
                List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(OGRID);
                TxtAd.Text = OgrList[0].AD.ToString();
                TxtSoyad.Text = OgrList[0].SOYAD.ToString();
                TxtNumara.Text = OgrList[0].NUMARA.ToString();
                TxtSifre.Text = OgrList[0].SIFRE.ToString();
                TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
            }
        }

        protected void BtnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();           
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            ent.ID = Convert.ToInt32(TxtId.Text);
            BLLOgrenci.OgrenciGuncelleBll(ent);
            Response.Redirect("Default.aspx");
        }
    }
}