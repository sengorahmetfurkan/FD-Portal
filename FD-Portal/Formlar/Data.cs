using System.IO;

namespace FD_Portal.Formlar
{
    internal class Data
    {
        internal static Data result;

        public object TeklifNo { get; set; }
        public string TeklifistemeTarihi { get; set; }
        public string FirmaAdi { get; set; }
        public string isinadi { get; set; }
        public int Hatve { get; set; }
        public int Miktar { get; set; }
        public string CncTeklifTarihi { get; set; }
        public int CncTeklifFiyati { get; set; }
        public int FdkesimFiyati { get; set; }
        public string LzrTeklifTarihi { get; set; }
        public int LzrTeklifFiyati { get; set; }
        public string Aciklama { get; set; }
        public MemoryStream ms { get; internal set; }
        public string CncTeknikresim { get; internal set; }
    }
}