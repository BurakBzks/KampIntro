using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation = nesneleri tek tek parantez içnde yollamıyoruz. direk product türünde yolluyoruz.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"eklendi");

        }

        //void =  
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }
       
    }
}
