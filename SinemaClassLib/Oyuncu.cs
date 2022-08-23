namespace SinemaClassLib
{
    public class Oyuncu
    {
        public string OyuncuAdi { get; set; }
        public DateTime DogumTarihi { get; set; }

        private int yas;

        public int Yas
        {
            get { return DateTime.Now.Year - DogumTarihi.Year; }
            set { yas = value; }
        }

    }
}