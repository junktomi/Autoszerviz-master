using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;

        public int AkkumulatorSzint
        {
            get => akkumulatorSzint;
            set => akkumulatorSzint = Math.Clamp(value, 0, 100);
        }

        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.AkkumulatorSzint = 0;
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel, {AkkumulatorSzint} % töltöttséggel.");
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
