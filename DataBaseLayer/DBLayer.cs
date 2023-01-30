using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DataBaseLayer
{
    public class DBLayer
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);

        public List<EierHusData> GetAllDataFromEierAndHus()
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Eier.ID, Fornavn, Etternavn, Telefonnr, Adresse, PostNr.Postnr, Sted, Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår FROM Eier INNER JOIN EierHus ON EierHus.ID = Eier.ID INNER JOIN Hus ON Hus.HusID = EierHus.HusID INNER JOIN TLFnr ON TLFnr.ID = Eier.ID INNER JOIN PostNr ON PostNr.Postnr = Hus.Postnr", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.ID = (int)reader["ID"];
                    ehd.Fornavn = (string)reader["Fornavn"];
                    ehd.Etternavn = (string)reader["Etternavn"];
                    ehd.Adresse = (string)reader["Adresse"];
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    ehd.Telefonnr = (int)reader["Telefonnr"];
                    ehd.Boligtype = (string)reader["Boligtype"];
                    ehd.AntallSoverom = (int)reader["AntallSoverom"];
                    ehd.AntallEtasjer = (int)reader["AntallEtasjer"];
                    ehd.Primærrom = (int)reader["Primærrom"];
                    ehd.Bruksareal = (int)reader["Bruksareal"];
                    ehd.Tomteareal = (int)reader["Tomteareal"];
                    ehd.Farge = (string)reader["Farge"];
                    ehd.Byggeår = (int)reader["Byggeår"];
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        public List<EierHusData> GetAllDataFromEierAndHusWherePostnr(string TextBoxPostnr)
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Eier.ID, Fornavn, Etternavn, Telefonnr, Adresse, PostNr.Postnr, Sted, Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår FROM Eier INNER JOIN EierHus ON EierHus.ID = Eier.ID INNER JOIN Hus ON Hus.HusID = EierHus.HusID INNER JOIN TLFnr ON TLFnr.ID = Eier.ID INNER JOIN PostNr ON PostNr.Postnr = Hus.Postnr WHERE PostNr.Postnr = @pn", conn);
                
                cmd.Parameters.AddWithValue("pn", TextBoxPostnr);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.ID = (int)reader["ID"];
                    ehd.Fornavn = (string)reader["Fornavn"];
                    ehd.Etternavn = (string)reader["Etternavn"];
                    ehd.Adresse = (string)reader["Adresse"];
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    ehd.Telefonnr = (int)reader["Telefonnr"];
                    ehd.Boligtype = (string)reader["Boligtype"];
                    ehd.AntallSoverom = (int)reader["AntallSoverom"];
                    ehd.AntallEtasjer = (int)reader["AntallEtasjer"];
                    ehd.Primærrom = (int)reader["Primærrom"];
                    ehd.Bruksareal = (int)reader["Bruksareal"];
                    ehd.Tomteareal = (int)reader["Tomteareal"];
                    ehd.Farge = (string)reader["Farge"];
                    ehd.Byggeår = (int)reader["Byggeår"];
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        public List<EierHusData> GetAllDataFromEierAndHusWhereTLFnr(int TextBoxTLFnr)
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Eier.ID, Fornavn, Etternavn, Telefonnr, Adresse, PostNr.Postnr, Sted, Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår FROM Eier INNER JOIN EierHus ON EierHus.ID = Eier.ID INNER JOIN Hus ON Hus.HusID = EierHus.HusID INNER JOIN TLFnr ON TLFnr.ID = Eier.ID INNER JOIN PostNr ON PostNr.Postnr = Hus.Postnr WHERE Telefonnr = @tlf", conn);

                cmd.Parameters.AddWithValue("tlf", TextBoxTLFnr);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.ID = (int)reader["ID"];
                    ehd.Fornavn = (string)reader["Fornavn"];
                    ehd.Etternavn = (string)reader["Etternavn"];
                    ehd.Adresse = (string)reader["Adresse"];
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    ehd.Telefonnr = (int)reader["Telefonnr"];
                    ehd.Boligtype = (string)reader["Boligtype"];
                    ehd.AntallSoverom = (int)reader["AntallSoverom"];
                    ehd.AntallEtasjer = (int)reader["AntallEtasjer"];
                    ehd.Primærrom = (int)reader["Primærrom"];
                    ehd.Bruksareal = (int)reader["Bruksareal"];
                    ehd.Tomteareal = (int)reader["Tomteareal"];
                    ehd.Farge = (string)reader["Farge"];
                    ehd.Byggeår = (int)reader["Byggeår"];
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        public List<EierHusData> GetAllDataFromEierAndHusWhereBoligtype(string TextBoxBoligtype)
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Eier.ID, Fornavn, Etternavn, Telefonnr, Adresse, PostNr.Postnr, Sted, Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår FROM Eier INNER JOIN EierHus ON EierHus.ID = Eier.ID INNER JOIN Hus ON Hus.HusID = EierHus.HusID INNER JOIN TLFnr ON TLFnr.ID = Eier.ID INNER JOIN PostNr ON PostNr.Postnr = Hus.Postnr WHERE Boligtype = @bt", conn);

                cmd.Parameters.AddWithValue("bt", TextBoxBoligtype);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.ID = (int)reader["ID"];
                    ehd.Fornavn = (string)reader["Fornavn"];
                    ehd.Etternavn = (string)reader["Etternavn"];
                    ehd.Adresse = (string)reader["Adresse"];
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    ehd.Telefonnr = (int)reader["Telefonnr"];
                    ehd.Boligtype = (string)reader["Boligtype"];
                    ehd.AntallSoverom = (int)reader["AntallSoverom"];
                    ehd.AntallEtasjer = (int)reader["AntallEtasjer"];
                    ehd.Primærrom = (int)reader["Primærrom"];
                    ehd.Bruksareal = (int)reader["Bruksareal"];
                    ehd.Tomteareal = (int)reader["Tomteareal"];
                    ehd.Farge = (string)reader["Farge"];
                    ehd.Byggeår = (int)reader["Byggeår"];
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        public void DeleteEierDataFromEierWhereID(int ID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE EierHus SET EierHus.ID = 13 WHERE EierHus.ID = @id", conn);

                cmd.Parameters.AddWithValue("id", ID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"Delete from TLFnr WHERE TLFnr.ID = @id ", conn);

                cmd.Parameters.AddWithValue("id", ID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Eier WHERE ID = @id", conn);

                cmd.Parameters.AddWithValue("id", ID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public void AddEierData(string TextBoxFornavn, string TextBoxEtternavn, int TextBoxTelefonnr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Eier (Fornavn, Etternavn) VALUES (@fn, @en); INSERT INTO TLFnr(Telefonnr, ID) SELECT @tlf, ID FROM Eier WHERE fornavn = @fn AND etternavn = @en;", conn);

                cmd.Parameters.AddWithValue("fn", TextBoxFornavn);
                cmd.Parameters.AddWithValue("en", TextBoxEtternavn);
                cmd.Parameters.AddWithValue("tlf", TextBoxTelefonnr);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public void AddPostNrData(string TextBoxPostNr, string TextBoxPoststed)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO PostNr (Postnr, Sted) VALUES (@pn, @ps)", conn);

                cmd.Parameters.AddWithValue("pn", TextBoxPostNr);
                cmd.Parameters.AddWithValue("ps", TextBoxPoststed);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public void AddHusData(string TextBoxBoligtype, int TextBoxAntSov, int TextBoxAntEta, int TextBoxPrimærrom, int TextBoxBruksareal, int TextBoxTomteareal, string TextBoxHusfarge, int TextBoxByggeår, string TextBoxAdresse, string TextBoxPostnummer)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Hus (Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår, Adresse, Postnr) VALUES (@bt, @as, @ae, @pr, @ba, @ta, @hf, @bå, @ad, @pn)", conn);
                
                cmd.Parameters.AddWithValue("bt", TextBoxBoligtype);
                cmd.Parameters.AddWithValue("as", TextBoxAntSov);
                cmd.Parameters.AddWithValue("ae", TextBoxAntEta);
                cmd.Parameters.AddWithValue("pr", TextBoxPrimærrom);
                cmd.Parameters.AddWithValue("ba", TextBoxBruksareal);
                cmd.Parameters.AddWithValue("ta", TextBoxTomteareal);
                cmd.Parameters.AddWithValue("hf", TextBoxHusfarge);
                cmd.Parameters.AddWithValue("bå", TextBoxByggeår);
                cmd.Parameters.AddWithValue("ad", TextBoxAdresse);
                cmd.Parameters.AddWithValue("pn", TextBoxPostnummer);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO EierHus (ID, HusID) VALUES (13, (SELECT TOP 1 HusID FROM Hus ORDER BY HusID desc))", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public void EditAllDataInAEier(string TextBoxFornavn, string TextBoxEtternavn, int ID, int TextBoxTelefonnr, string TextBoxBoligtype, int TextBoxAntSov, int TextBoxAntEta, int TextBoxPrimærrom, int TextBoxBruksareal, int TextBoxTomteareal, string TextBoxHusfarge, int TextBoxByggeår, string TextBoxAdresse, string TextBoxPostnummer)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Eier Set Fornavn = @fn, Etternavn = @en WHERE Eier.ID = @id UPDATE Hus SET Boligtype = @bt, AntallSoverom = @as, AntallEtasjer = @ae, Primærrom = @pr, Bruksareal = @ba, Tomteareal = @ta, Farge = @hf, Byggeår = @bå, Adresse = @ad, Postnr = @pn From EierHus, Hus, Eier WHERE Hus.HusID = EierHus.HusID AND (SELECT Eier.ID WHERE Eier.ID = @id) = (SELECT EierHus.ID WHERE EierHus.ID = @id) UPDATE TLFnr SET Telefonnr = @tlf From TLFnr, Eier WHERE TLFnr.ID = (SELECT Eier.ID WHERE Eier.ID = @id)", conn);

                cmd.Parameters.AddWithValue("fn", TextBoxFornavn);
                cmd.Parameters.AddWithValue("en", TextBoxEtternavn);
                cmd.Parameters.AddWithValue("id", ID);
                cmd.Parameters.AddWithValue("tlf", TextBoxTelefonnr);
                cmd.Parameters.AddWithValue("bt", TextBoxBoligtype);
                cmd.Parameters.AddWithValue("as", TextBoxAntSov);
                cmd.Parameters.AddWithValue("ae", TextBoxAntEta);
                cmd.Parameters.AddWithValue("pr", TextBoxPrimærrom);
                cmd.Parameters.AddWithValue("ba", TextBoxBruksareal);
                cmd.Parameters.AddWithValue("ta", TextBoxTomteareal);
                cmd.Parameters.AddWithValue("hf", TextBoxHusfarge);
                cmd.Parameters.AddWithValue("bå", TextBoxByggeår);
                cmd.Parameters.AddWithValue("ad", TextBoxAdresse);
                cmd.Parameters.AddWithValue("pn", TextBoxPostnummer);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public List<EierHusData> GetAllDataWhereID(int ID)
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Fornavn, Etternavn, Telefonnr, Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår, Adresse, PostNr.Postnr, Sted FROM Eier INNER JOIN EierHus ON EierHus.ID = Eier.ID INNER JOIN Hus ON Hus.HusID = EierHus.HusID INNER JOIN TLFnr ON TLFnr.ID = Eier.ID INNER JOIN PostNr ON PostNr.Postnr = Hus.Postnr WHERE Eier.ID = @id", conn);

                cmd.Parameters.AddWithValue("id", ID);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.Fornavn = (string)reader["Fornavn"];
                    ehd.Etternavn = (string)reader["Etternavn"];
                    ehd.Adresse = (string)reader["Adresse"];
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    ehd.Telefonnr = (int)reader["Telefonnr"];
                    ehd.Boligtype = (string)reader["Boligtype"];
                    ehd.AntallSoverom = (int)reader["AntallSoverom"];
                    ehd.AntallEtasjer = (int)reader["AntallEtasjer"];
                    ehd.Primærrom = (int)reader["Primærrom"];
                    ehd.Bruksareal = (int)reader["Bruksareal"];
                    ehd.Tomteareal = (int)reader["Tomteareal"];
                    ehd.Farge = (string)reader["Farge"];
                    ehd.Byggeår = (int)reader["Byggeår"];
                    EierHus.Add(ehd);
                }

                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }
        public List<EierHusData> GetDataWhereEierWithoutHus()
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Eier.ID, Fornavn, Etternavn, Telefonnr FROM eier LEFT JOIN EierHus ON eierhus.ID = Eier.ID LEFT JOIN TLFnr ON TLFnr.ID = Eier.ID WHERE EierHus.HusID IS NULL", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.ID = (int)reader["ID"];
                    ehd.Fornavn = (string)reader["Fornavn"];
                    ehd.Etternavn = (string)reader["Etternavn"];
                    if (ehd != null)
                    {
                        ehd.Telefonnr = (int)reader["Telefonnr"];
                    }
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<EierHusData> GetAllDataWhereHusTilSalgs()
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Hus.HusID, Boligtype, AntallSoverom, AntallEtasjer, Primærrom, Bruksareal, Tomteareal, Farge, Byggeår , Adresse, Hus.Postnr, Sted FROM Hus LEFT JOIN PostNr ON Hus.Postnr = PostNr.Postnr LEFT JOIN EierHus ON Hus.HusID = EierHus.HusID WHERE EierHus.ID = 13", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.HusID = (int)reader["HusID"];
                    ehd.Boligtype = (string)reader["Boligtype"];
                    ehd.AntallSoverom = (int)reader["AntallSoverom"];
                    ehd.AntallEtasjer = (int)reader["AntallEtasjer"];
                    ehd.Primærrom = (int)reader["Primærrom"];
                    ehd.Bruksareal = (int)reader["Bruksareal"];
                    ehd.Tomteareal = (int)reader["Tomteareal"];
                    ehd.Farge = (string)reader["Farge"];
                    ehd.Byggeår = (int)reader["Byggeår"];
                    ehd.Adresse = (string)reader["Adresse"];
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void ConnectEierAndHus(int EierID, int HusID)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE EierHus SET ID = @eid WHERE ID = 13 AND HusID = @hid", conn);

                cmd.Parameters.AddWithValue("eid", EierID);
                cmd.Parameters.AddWithValue("hid", HusID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (ArgumentOutOfRangeException) { }
        }
        public List<EierHusData> AvaiablePostnr()
        {
            try
            {
                List<EierHusData> EierHus = new List<EierHusData>();

                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Postnr, Sted FROM PostNr ORDER BY Postnr ASC", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EierHusData ehd = new EierHusData();
                    ehd.Postnr = (string)reader["Postnr"];
                    ehd.Sted = (string)reader["Sted"];
                    EierHus.Add(ehd);
                }
                reader.Close();
                conn.Close();

                return EierHus;
            }
            catch (Exception) { return null; }
        }
    }
}
