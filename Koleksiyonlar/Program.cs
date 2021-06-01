using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arraylerde eğer ki sonradan new yapıp veri eklersek diğer veriler bellekte kayıp olur onun yerine koleksiyonlarda list kullanyoruz.

            //string[] isimler = new string[] {"burak","murat","aysel","efe" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "samet";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "burak", "murat", "aysel", "efe" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
