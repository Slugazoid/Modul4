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

            Console.WriteLine(" ");

            MesinKopi Kopi = new MesinKopi();
            Kopi.ubahState(MesinKopi.Trigger.POWER_ON);
            Kopi.ubahState(MesinKopi.Trigger.START_BREW);
            Kopi.ubahState(MesinKopi.Trigger.FINISH_BREW);
            Kopi.ubahState(MesinKopi.Trigger.START_MAINTENANCE);
            Kopi.ubahState(MesinKopi.Trigger.FINISH_MAINTENANCE);
            Kopi.ubahState(MesinKopi.Trigger.POWER_OFF);
        }
    }
}
