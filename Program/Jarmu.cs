using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam = "ISMERETLEN";
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        public bool SzervizSzukseges => KilometerOra>=200000;
        



        public string Rendszam
        {
            get => rendszam;
            set => rendszam = string.IsNullOrEmpty(value) ? "ISMERETLEN" : value;
        }
       
        public int Kor
        {
            get => kor;
            set => kor = Math.Clamp(value, 0, 50);
        }

        public int KilometerOra
        {
            get => kilometerOra;
            set => kilometerOra = Math.Max(0, value);
        }

        public int UzemanyagSzint
        {
            get => uzemanyagSzint;
            set => uzemanyagSzint = Math.Clamp(value, 0, 100);
        }

        

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
        }

        public override void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
        }

        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            UzemanyagSzint -= 10;
            Console.WriteLine($"A {Rendszam} szervizelése megtörtént.");
           
        }

        
    }

}

