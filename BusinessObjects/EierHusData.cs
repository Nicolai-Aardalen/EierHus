namespace BusinessObjects
{
    public class EierHusData
    {
        public int ID { get; set; }
        public int HusID { get; set; }
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public string Adresse { get; set; }
        public string Postnr { get; set; }
        public string Sted { get; set; }
        public string Telefonnr { get; set; }
        public string Boligtype { get; set; }
        public int AntallSoverom { get; set; }
        public int AntallEtasjer { get; set; }
        public string Primærrom { get; set; }
        public string Bruksareal { get; set; }
        public string Tomteareal { get; set; }
        public string Farge { get; set; }
        public int Byggeår { get; set; }
    }
}
