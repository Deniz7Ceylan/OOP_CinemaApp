using MFramework.Services.FakeData;
using SinemaClassLib;

namespace OOP_CinemaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Film> FilmListesi = new List<Film>();
        List<Salon> SalonListesi = new List<Salon>();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Transformers
            Film film = new Film
            {
                FilmAdi = "Transformers",
                FilmTuru = FilmTuru.BilimKurgu,
                GosterimYili = 2017
            };

            for (int i = 0; i < 5; i++)
            {
                film.Oyuncular.Add(new Oyuncu
                {
                    DogumTarihi = DateTimeData.GetDatetime(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(-10)),
                    OyuncuAdi = NameData.GetFullName()

                });
            }
            FilmListesi.Add(film);
            #endregion

            #region Er˛an Kuneri
            Film film2 = new Film
            {
                FilmAdi = "Er˛an Kuneri",
                FilmTuru = FilmTuru.Aksiyon,
                GosterimYili = 2022
            };

            for (int i = 0; i < 5; i++)
            {
                film2.Oyuncular.Add(new Oyuncu
                {
                    DogumTarihi = DateTimeData.GetDatetime(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(-10)),
                    OyuncuAdi = NameData.GetFullName()

                });
            }
            FilmListesi.Add(film2);
            #endregion

            listFilmler.DataSource = FilmListesi;
            listFilmler.DisplayMember = "Baslik";
            listFilmler.ValueMember = "FilmAdi";


            #region Salon 1
            Salon salon1 = new Salon
            {
                SalonAdi = "Salon 1",
                BiletFiyati = 120,
                IndirimliBiletFiyati = 100,
                KoltukSayisi = 40,
                Film = film,
                BosKoltukSayisi = 40
            };

            SalonListesi.Add(salon1);
            #endregion

            #region Salon 2
            Salon salon2 = new Salon
            {
                SalonAdi = "Salon 2",
                BiletFiyati = 90,
                IndirimliBiletFiyati = 75,
                KoltukSayisi = 50,
                Film = film2,
                BosKoltukSayisi = 50
            };

            SalonListesi.Add(salon2);
            #endregion

            #region Salon 3
            Salon salon3 = new Salon
            {
                SalonAdi = "Salon 3",
                BiletFiyati = 110,
                IndirimliBiletFiyati = 95,
                KoltukSayisi = 45,
                Film = film,
                BosKoltukSayisi = 45
            };

            SalonListesi.Add(salon3);
            #endregion

            #region Salon 4
            Salon salon4 = new Salon
            {
                SalonAdi = "Salon 4",
                BiletFiyati = 85,
                IndirimliBiletFiyati = 60,
                KoltukSayisi = 60,
                Film = film2,
                BosKoltukSayisi = 60
            };

            SalonListesi.Add(salon4);
            #endregion


        }


        private void listFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film film = ((Film)listFilmler.SelectedItem);

            List<Salon> filtreli = SalonListesi.Where(x => x.Film.FilmAdi == film.FilmAdi).ToList();
            listSalonlar.DataSource = filtreli;
            listSalonlar.DisplayMember = "SalonAdi";
            listSalonlar.ValueMember = "SalonAdi";

            lblFilmAdi.Text = film.FilmAdi;
            lblGosterimYili.Text = film.GosterimYili.ToString();
            lblTuru.Text = film.FilmTuru.ToString();
            lblBaslik.Text = film.Baslik;
            lblHasilat.Text = film.ToplamSatisHasilati(SalonListesi, film.FilmAdi).ToString("n2");

            lstOyuncular.DataSource = film.Oyuncular;
            lstOyuncular.DisplayMember = "OyuncuAdi";
            lstOyuncular.ValueMember = "OyuncuAdi";
        }

        private void lstOyuncular_SelectedIndexChanged(object sender, EventArgs e)
        {
            Oyuncu oyuncu = ((Oyuncu) lstOyuncular.SelectedItem);
            lblOyuncuAdi.Text = oyuncu.OyuncuAdi;
            lblDogumTarihi.Text = oyuncu.DogumTarihi.ToShortDateString();
            lblYas.Text = oyuncu.Yas.ToString();
        }

        private void listSalonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Salon salon = ((Salon) listSalonlar.SelectedItem);

            lblKoltukSayisi.Text = salon.KoltukSayisi.ToString();
            lblBosKoltukSayisi.Text = salon.BosKoltukSayisi.ToString();
            lblFiyat.Text = salon.BiletFiyati.ToString("n2");
            lblIndFiyat.Text = salon.IndirimliBiletFiyati.ToString("n2");
            lblBakiye.Text = salon.Bakiye.ToString("n2");
        }


        private void btnBilet›ptal_Click(object sender, EventArgs e)
        {
            if (nupBiletSayisi.Value <= 0)
            {
                MessageBox.Show("Bilet say˝s˝ seÁmediniz!");
                return;
            }

            Salon salon = ((Salon)listSalonlar.SelectedItem);
            salon.BiletIptal((int)nupBiletSayisi.Value, chkInd˝r˝mli.Checked);

            listFilmler_SelectedIndexChanged(null, null);
            listSalonlar_SelectedIndexChanged(null, null);

        }

        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if (nupBiletSayisi.Value <= 0)
            {
                MessageBox.Show("Bilet say˝s˝ seÁmediniz!");
                return;
            }

            Salon salon = ((Salon)listSalonlar.SelectedItem);
            salon.BiletSat((int)nupBiletSayisi.Value, chkInd˝r˝mli.Checked);

            listFilmler_SelectedIndexChanged(null, null);
            listSalonlar_SelectedIndexChanged(null, null);

        }

        private void btnVerileriYenile_Click(object sender, EventArgs e)
        {
            decimal satilanKoltukSayisi = SalonListesi.Sum(x => x.KoltukSayisi - x.BosKoltukSayisi);
            decimal bosKoltukSayisi = SalonListesi.Sum(x => x.BosKoltukSayisi);
            decimal toplamHasilat = SalonListesi.Sum(x => x.Bakiye);

            lblSatKoltukSayisi.Text = satilanKoltukSayisi.ToString();
            lblToplamBosKoltukSayisi.Text = bosKoltukSayisi.ToString();
            lblToplamHasilat.Text = toplamHasilat.ToString();            
        }
    }
}