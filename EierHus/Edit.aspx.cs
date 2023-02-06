using BusinessLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace EierHus
{
    public partial class Edit : System.Web.UI.Page
    {
        protected BLayer db = new BLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tabell();
                TextboxText();
            }
        }
        public void Tabell()
        {
            var ID = Request["ID"];

            if (ID == null)
            {
                Response.Redirect($"Default.aspx");
            }
            else
            {
                List<EierHusData> ehd = db.GetAllDataWhereID(int.Parse(ID));
                GridViewInvis.DataSource = ehd;
                GridViewInvis.DataBind();
            }
            if (GridViewInvis.Rows.Count == 0)
            {
                Error.Visible = true;
            }
        }
        protected void TextboxText()
        {
            TextBoxFornavn.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[0].Text);
            TextBoxEtternavn.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[1].Text);
            TextBoxTelefonnr.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[2].Text).Replace("+47 ", "");
            TextBoxBoligtype.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[3].Text);
            TextBoxAntSov.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[4].Text);
            TextBoxAntEta.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[5].Text);
            TextBoxPrimærrom.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[6].Text).Replace(" m²", "");
            TextBoxBruksareal.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[7].Text).Replace(" m²", "");
            TextBoxTomteareal.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[8].Text).Replace(" m²", "");
            TextBoxHusfarge.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[9].Text);
            TextBoxByggeår.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[10].Text);
            TextBoxAdresse.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[11].Text);
            TextBoxPostnr.Text = Server.HtmlDecode(GridViewInvis.Rows[0].Cells[12].Text).Trim();
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            var ID = Request["ID"];
            Button knapp = (Button)sender;
            db.EditAllDataInAEier(TextBoxFornavn.Text, TextBoxEtternavn.Text, int.Parse(ID), int.Parse(TextBoxTelefonnr.Text), TextBoxBoligtype.Text, int.Parse(TextBoxAntSov.Text), int.Parse(TextBoxAntEta.Text), int.Parse(TextBoxPrimærrom.Text), int.Parse(TextBoxBruksareal.Text), int.Parse(TextBoxTomteareal.Text), TextBoxHusfarge.Text, int.Parse(TextBoxByggeår.Text), TextBoxAdresse.Text, TextBoxPostnr.Text);
            Response.Redirect($"Default.aspx");
        }

        protected void Return_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Default.aspx");
        }
    }
}