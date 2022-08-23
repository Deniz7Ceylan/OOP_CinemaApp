namespace SinemaClassLib
{
    public class Film
    {
        public string FilmAdi { get; set; }
        public int GosterimYili { get; set; }
        public FilmTuru FilmTuru { get; set; }

        private string baslik;

        public string Baslik
        {
            get { return $"{FilmAdi}  - ({GosterimYili})";}
            set { baslik = value; }
        }

        public List<Oyuncu>Oyuncular { get; set; } = new List<Oyuncu>();

        public decimal ToplamSatisHasilati(List<Salon> salonlar, string filmAdi)
        {
            decimal toplamHasilat = salonlar.Where(x => x.Film.FilmAdi == filmAdi).Sum(x => x.Bakiye);
            return toplamHasilat;
        }

    }

    public enum FilmTuru
        {
            BilimKurgu=0,
            Gerilim=1,
            Aksiyon=2,
            Korku=3
        }
}