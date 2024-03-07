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
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int OGRID = Convert.ToInt32(Request.QueryString["OGRID"]);
            // Response.Write(x); bu sonuc basmak console gibi bir şey
            EntityOgrenci ent = new EntityOgrenci();
            ent.ID = OGRID;
            BLLOgrenci.OgrenciSilBLL(ent.ID);
            Response.Redirect("Default.aspx"); //yönlendirme yapar
        }
    }
}