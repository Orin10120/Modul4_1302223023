using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302223023
{
     class KodeBuah
    {
        public enum NamaBuah {Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

        public static String getKodeBuah(NamaBuah namaBuah)
        {
            String[] KodeBuah = {"A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00"};
            return KodeBuah [(int) namaBuah];
        }
    }
}
