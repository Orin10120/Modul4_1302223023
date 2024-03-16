using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223023
{
     public class PosisiKarakterGame
    {
        public enum Posisi {Jongkok, Berdiri, Tengkurap, Terbang };

        public void RunWay()
        {
            Posisi posisiAwal = Posisi.Berdiri;
            String input;

            String[] ScreenName = { "Posisi StandBy", "Posisi Istirahat", "Posisi landing", "Posisi take off", "tombol arah bawah ditekan", "tombol arah atas ditekan" };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("State Awal " + posisiAwal);
                Console.WriteLine("Masukan input: ");

                input = Console.ReadLine();

                switch(posisiAwal)
                {
                    case Posisi.Berdiri:
                        if (input == "TombolW")
                        {
                            posisiAwal = Posisi.Terbang;
                        } else if(input == "TombolS")
                        {
                            posisiAwal = Posisi.Terbang;
                        }
                        break;
                }

                
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(ScreenName[(int)posisiAwal]);
        }
    }
}
