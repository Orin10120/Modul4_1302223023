using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Apel + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Apel));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Aprikot + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Aprikot));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Alpukat + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Alpukat));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Pisang + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Pisang));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Paprika + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Paprika));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Blackberry + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Blackberry));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Ceri + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Ceri));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.kelapa + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.kelapa));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Jagung + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Jagung));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Kurma + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Kurma));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Durian + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Durian));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Anggur + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Anggur));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Melon + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Melon));
            Console.WriteLine("Nama Buah: " + KodeBuah.NamaBuah.Semangka + " Kode Buah: " + KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Semangka));


            PosisiKarakterGame game = new PosisiKarakterGame();
            game.RunWay();
        }
    }
}
