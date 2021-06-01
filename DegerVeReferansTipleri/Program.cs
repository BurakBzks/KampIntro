using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30 olur 


            //sayısal veri tipleri (int , double , float .. )bunlar değer tipi
            //array,class,interface = referans tipleridir bunlar.
            //Bellekte stock ve heap de tutuler. değer tiplerinde (stockk) sadece değerler tutulur ve değerler taşınır.
            //referans tiplerinde stack de sayilar1 tutulur ve heapde[değerler tutuler].
            //aslında bellekte referans numaralarına bakıyorsun bu yüzden sonradan veri değişirse her yerde değişir.
            //Değer tiplerinde değerleri atıyorsun
            //Referans tiplerinde sadece referansları atıyorsun.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar1[0]);

        }
    }
}
