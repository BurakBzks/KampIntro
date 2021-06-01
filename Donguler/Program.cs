using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kursu";
            string kurs2 = "C# Yazılım Kursu";
            string kurs3 = "Java Yazılım Kursr";

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirme Kursu","C# Yazılım Kursu","Java Yazılım Kursr","Python  Yazılım Kursu"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
