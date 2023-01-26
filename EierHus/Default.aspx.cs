using BusinessLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace EierHus
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tabell();
            }
        }
        protected BLayer db = new BLayer();
        public void Tabell()
        {
            List<EierHusData> ehd = db.GetAllDataFromEierAndHus();
            GridView1.DataSource = ehd;
            GridView1.DataBind();
        }
        protected void PostnrSøk_Click(object sender, EventArgs e)
        {
            List<EierHusData> ehd = db.GetAllDataFromEierAndHusWherePostnr(TextBoxPostnr.Text);
            GridView1.DataSource = ehd;
            GridView1.DataBind();
        }
        protected void TLFnrSøk_Click(object sender, EventArgs e)
        {
            List<EierHusData> ehd = db.GetAllDataFromEierAndHusWhereTLFnr(TextBoxTLFnr.Text);
            GridView1.DataSource = ehd;
            GridView1.DataBind();
        }
        protected void BoligtypeSøk_Click(object sender, EventArgs e)
        {
            List<EierHusData> ehd = db.GetAllDataFromEierAndHusWhereBoligtype(TextBoxBoligtype.Text);
            GridView1.DataSource = ehd;
            GridView1.DataBind();
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            var ID = knapp.CommandArgument;
            db.DeleteEierDataFromEierWhereID(int.Parse(ID));
            Tabell();
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            var ID = knapp.CommandArgument;
            Response.Redirect($"Edit.aspx?ID={ID}");
        }
        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Add.aspx");
        }
        protected void Market_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Market.aspx");
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tabell();
        }
    }
}