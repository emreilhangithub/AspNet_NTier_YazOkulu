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
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<EntityOgrenci> OgrList =  new List<EntityOgrenci>(); bu yeni bir ögrenci listesi tanımalama anlamına gelir
            List<EntityOgrenci> OgrList = BLLOgrenci.BllListele();
            Repeater1.DataSource = OgrList;
            Repeater1.DataBind();
        }
    }
}