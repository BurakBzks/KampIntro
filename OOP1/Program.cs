using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Bilgisayar";
            product.UnitPrice = 2000;
            product.UnitsInstock = 100;

            //PascalCase= Kelimelerin baş harfi büyük olur sınıflarda .
            //camelCase =kelimenin ilk kelimesinin harfi küçük olur sonraki kelimeler büyük ile başlar.(değişken isimleri)
            //case sensitive = küçük büyük harf duyarlı c#.
            //sol taraf stack sağ tarafta new-lediğimiz zaman heap da olur.
            Product product1 = new Product { Id=2,ProductName="Kalem",CategoryId=3,UnitPrice=500,UnitsInstock=89};

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);





            //int,double,bool ... değer tipi
            //diziler,class,abstract class, interface ... referans tipleridir.

           
        }
    }
}
