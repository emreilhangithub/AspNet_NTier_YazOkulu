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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler> EntDers = BLLDers.BllListele();
                DropDownList1.DataSource = BLLDers.BllListele();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
            }          
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnDersTalepOlustur_Click1(object sender, EventArgs e)
        {
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvuruForm entityBasvuruForm = new EntityBasvuruForm();
            entityBasvuruForm.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
            entityBasvuruForm.BASOGRID = int.Parse(TextBox1.Text);
            BLLDers.TalepEkleBll(entityBasvuruForm);
        }
    }
}