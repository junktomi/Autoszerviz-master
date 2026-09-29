using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class TeherAuto : Jarmu
    {
        private int rakomany;

        public int Rakomany
        {
            get => rakomany;
            set => rakomany = Math.Clamp(value, 0, 20);
        }

        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;

        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel, rakomány: {Rakomany} tonna.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            AkkumulatorSzint += 20;
            Console.WriteLine($"A {Rendszam} szervizelése megtörtént.");

        }
    }
}
