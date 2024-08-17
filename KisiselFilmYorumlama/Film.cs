using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProje
{
    public class Film
    {

        public string FilmAd { get; set; }
        public string Yonetmen { get; set; }
        public int Yil { get; set; }
        public string Tur { get; set; }
        public double Puan { get; set; }
        public string Yorum { get; set; }

        public Film(string filmAd, string yonetmen, int yil, string tur, double puan)
        {
            FilmAd = filmAd;
            Yonetmen = yonetmen;
            Yil = yil;
            Tur = tur;
            Puan = puan;
        }
    }
}
