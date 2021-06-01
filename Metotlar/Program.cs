using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //class çağırma...
            Product product1 = new Product();
            product1.Adi = "Bilgisayar";
            product1.Aciklama = "Teknoloji";
            product1.Fiyati = 200;

            Product product2 = new Product();
            product2.Adi = "Kamera";
            product2.Aciklama = "Teknoloji";
            product2.Fiyati = 300;

            Product[] product = new Product[] {product1,product2 };

            foreach (var products in product)
            {
                Console.WriteLine(products.Adi);
                Console.WriteLine(products.Aciklama);
                Console.WriteLine(products.Fiyati);
                Console.WriteLine("--------");
            }
            Console.WriteLine("--------------------");
            //instance - örnek
            //metot çağırma.
            //encapsulation (class yapısı ile ilgili düzenli yazma.)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            //class yapısı kullanmadan yapılan sistem özellik eklenince sıkıntı çıkarır.
            sepetManager.Add2("elma","yeşil",12);
            sepetManager.Add2("erik","yeşil",15);
            
        }
    }
}
