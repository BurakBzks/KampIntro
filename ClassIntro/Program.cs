using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursEgitmeni = "Burak Bozkuş";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = "1000";

            Kurs kurs2 = new Kurs();
            kurs2.KursEgitmeni = "Aysel ALTUN";
            kurs2.KursAdi = "Python";
            kurs2.IzlenmeOrani = "2000";

            Kurs kurs3 = new Kurs();
            kurs3.KursEgitmeni = "Murat ÖLÇAL";
            kurs3.KursAdi = "C++";
            kurs3.IzlenmeOrani = "3000";

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurslarim in kurslar)
            {
                //Console.WriteLine(kurslarim.KursAdi);
                Console.WriteLine(kurslarim.KursAdi + ":" + kurslarim.KursEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public string IzlenmeOrani { get; set; }
    }

}
