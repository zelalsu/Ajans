using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProjeOdevi
{
    public class Oyuncu
    {
        public string oyuncuIsmi { get; set; }
        public string rol { get; set; }
        public string kategori { get; set; }
        public string aktiflikDurumu { get; set; }
        public string mevcutProje { get; set; }
        public string isBaslangic { get; set; }
        public string isBitis { get; set; }
    }
    public class SinemaOyuncusu : Oyuncu
    {

    }
    public class ReklamOyuncusu : Oyuncu
    {

    }
    public class RadyoOyuncusu : Oyuncu
    {

    }

}
