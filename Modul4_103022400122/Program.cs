using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022400122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodePaket Paket = new KodePaket();
            Console.Write("Masukkan nama Paket: ");
            string inputPaket = Console.ReadLine();
            string outputPaket = Paket.getKodePaket(inputPaket);
            Console.WriteLine("Nama Paket: " + inputPaket);
            Console.WriteLine("Kode Paket: " + outputPaket);
        }
    }
}
