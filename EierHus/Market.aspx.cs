using BusinessLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EierHus
{
    public partial class Market : System.Web.UI.Page
    {
        protected BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tabell();
            }
        }
        public void Tabell()
        {
            
            List<EierHusData> ewh = db.GetDataWhereEierWithoutHus();
            List<EierHusData> hts = db.GetAllDataWhereHusTilSalgs();
            GridViewHusLøseEiere.DataSource = ewh;
            GridViewHusTilSalgs.DataSource = hts;
            GridViewHusLøseEiere.DataBind();
            GridViewHusTilSalgs.DataBind();
            if (ewh == null || hts == null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Return_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void Purchase_Click(object sender, EventArgs e)
        {
            db.ConnectEierAndHus(int.Parse(TextBoxEierID.Text), int.Parse(TextBoxHusID.Text));
            Response.Redirect("Default.aspx");
        }
    }
}