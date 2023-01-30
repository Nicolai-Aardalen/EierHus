using BusinessObjects;
using DataBaseLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BLayer
    {
        private DBLayer dbl = new DBLayer();
        public List<EierHusData> GetAllDataFromEierAndHus()
        {
            List<EierHusData> list = new List<EierHusData>();
            //var test= list.Where(eierHusData => eierHusData.AntallSoverom>1).ToList();
            return dbl.GetAllDataFromEierAndHus();
        }
        public List<EierHusData> GetAllDataFromEierAndHusWherePostnr(string TextBoxPostnr)
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.GetAllDataFromEierAndHusWherePostnr(TextBoxPostnr);
        }
        public List<EierHusData> GetAllDataFromEierAndHusWhereTLFnr(int TextBoxTLFnr)
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.GetAllDataFromEierAndHusWhereTLFnr(TextBoxTLFnr);
        }
        public List<EierHusData> GetAllDataFromEierAndHusWhereBoligtype(string TextBoxBoligtype)
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.GetAllDataFromEierAndHusWhereBoligtype(TextBoxBoligtype);
        }
        public void DeleteEierDataFromEierWhereID(int ID)
        {
            dbl.DeleteEierDataFromEierWhereID(ID);
        }
        public void AddEierData(string TextBoxFornavn, string TextBoxEtternavn, int TextBoxTelefonnr)
        {
            dbl.AddEierData(TextBoxFornavn, TextBoxEtternavn, TextBoxTelefonnr);
        }
        public void AddPostNrData(string TextBoxPostNr, string TextBoxPoststed)
        {
            dbl.AddPostNrData(TextBoxPostNr, TextBoxPoststed);
        }
        public void AddHusData(string TextBoxBoligtype, int TextBoxAntSov, int TextBoxAntEta, int TextBoxPrimærrom, int TextBoxBruksareal, int TextBoxTomteareal, string TextBoxHusfarge, int TextBoxByggeår, string TextBoxAdresse, string TextBoxPostnummer)
        {
            dbl.AddHusData(TextBoxBoligtype, TextBoxAntSov, TextBoxAntEta, TextBoxPrimærrom, TextBoxBruksareal, TextBoxTomteareal, TextBoxHusfarge, TextBoxByggeår, TextBoxAdresse, TextBoxPostnummer);
        }
        public void EditAllDataInAEier(string TextBoxFornavn, string TextBoxEtternavn, int ID, int TextBoxTelefonnr, string TextBoxBoligtype, int TextBoxAntSov, int TextBoxAntEta, int TextBoxPrimærrom, int TextBoxBruksareal, int TextBoxTomteareal, string TextBoxHusfarge, int TextBoxByggeår, string TextBoxAdresse, string TextBoxPostnummer)
        {
            dbl.EditAllDataInAEier(TextBoxFornavn, TextBoxEtternavn, ID, TextBoxTelefonnr, TextBoxBoligtype, TextBoxAntSov, TextBoxAntEta, TextBoxPrimærrom, TextBoxBruksareal, TextBoxTomteareal, TextBoxHusfarge, TextBoxByggeår, TextBoxAdresse, TextBoxPostnummer);
        }
        public List<EierHusData> GetAllDataWhereID(int ID)
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.GetAllDataWhereID(ID);
        }
        public List<EierHusData> GetDataWhereEierWithoutHus()
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.GetDataWhereEierWithoutHus();
        }
        public List<EierHusData> GetAllDataWhereHusTilSalgs()
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.GetAllDataWhereHusTilSalgs();
        }
        public void ConnectEierAndHus(int EierID, int HusID)
        {
            dbl.ConnectEierAndHus(EierID, HusID);
        }
        public List<EierHusData> AvaiablePostnr()
        {
            List<EierHusData> list = new List<EierHusData>();
            return dbl.AvaiablePostnr();
        }
    }
}