using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022400122
{
    internal class KodePaket
    {
        private Dictionary<string, string> tabelPaket;
        public KodePaket()
        {
            tabelPaket = new Dictionary<string, string>();
            tabelPaket.Add("Basic", "P201");
            tabelPaket.Add("Standard", "P202");
            tabelPaket.Add("Premium", "P203");
            tabelPaket.Add("Umlimited", "P204");
            tabelPaket.Add("Gaming", "P205");
            tabelPaket.Add("Streaming", "P206");
            tabelPaket.Add("Family", "P207");
            tabelPaket.Add("Business", "P208");
            tabelPaket.Add("Student", "P209");
            tabelPaket.Add("Traveler", "P210");
        }
        public string getKodePaket(string namaPaket)
        {
            if (tabelPaket.ContainsKey(namaPaket))
            {
                return tabelPaket[namaPaket];
            }
            else
            {
                return "Paket tidak ada"; 
            }
        }
    }
}
