using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    internal class Taxi : Jarmu
    {
        private int utasokSzama;

        public int UtasokSzama
        {
            get => utasokSzama;
            set => utasokSzama = Math.Clamp(value, 0, 4);
        }

        public Taxi(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int utasokSzama) : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            UtasokSzama = utasokSzama;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel, utasok száma: {UtasokSzama}.");
        }

        public override void Szervizel(int dij)
        {
            //szervízelés előtt lerakjuk az utasokat
            UtasokSzama = 0;
            base.Szervizel(dij);
        }
    }
}
