using BusinessLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI.WebControls;

namespace EierHus
{
    public partial class Add : System.Web.UI.Page
    {
        protected BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AvailiblePostnr();
            }
        }
        public void AddEier_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            db.AddEierData(TextBoxFornavn.Text, TextBoxEtternavn.Text, int.Parse(TextBoxTelefonnr.Text));
            Response.Redirect($"Default.aspx");
        }

        protected void AddPostNr_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            db.AddPostNrData(TextBoxPostNr.Text, TextBoxPoststed.Text);
            Response.Redirect($"Default.aspx");
        }

        protected void AddHus_Click(object sender, EventArgs e)
        {
            Button knapp = (Button)sender;
            db.AddHusData(TextBoxBoligtype.Text, int.Parse(TextBoxAntSov.Text), int.Parse(TextBoxAntEta.Text), int.Parse(TextBoxPrimærrom.Text), int.Parse(TextBoxBruksareal.Text), int.Parse(TextBoxTomteareal.Text), TextBoxHusfarge.Text, int.Parse(TextBoxByggeår.Text), TextBoxAdresse.Text, TextBoxPostnummer.Text);
            Response.Redirect($"Default.aspx");
        }

        protected void Return_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Default.aspx");
        }
        protected void AvailiblePostnr()
        {
            List<EierHusData> ehd = db.AvaiablePostnr();
            GridViewTilgjengeligePostnr.DataSource = ehd;
            GridViewTilgjengeligePostnr.DataBind();
        }
    }
}