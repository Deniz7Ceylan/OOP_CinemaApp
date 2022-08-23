using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaClassLib
{
    public class Salon
    {
        public string SalonAdi { get; set; }
        public int KoltukSayisi { get; set; }
        public int BosKoltukSayisi { get; set; }
        public decimal BiletFiyati { get; set; }
        public decimal IndirimliBiletFiyati { get; set; }
        public decimal Bakiye { get; set; }
        public Film Film { get; set; } = new Film();

        public void BiletSat(int biletSayisi, bool indirimlimi)
        {
            BosKoltukSayisi -= biletSayisi;

            if (indirimlimi)
                Bakiye += IndirimliBiletFiyati * biletSayisi;
            else
                Bakiye += BiletFiyati * biletSayisi;
        }

        public void BiletIptal(int biletSayisi, bool indirimlimi)
        {
            BosKoltukSayisi += biletSayisi;

            if (indirimlimi)
                Bakiye -= IndirimliBiletFiyati * biletSayisi;
            else
                Bakiye -= BiletFiyati * biletSayisi;
        }
    }
}
