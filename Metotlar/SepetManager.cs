using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("sepete eklendi" + product.Adi);
        }
        public void Add2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("sepete eklendi" + urunAdi);
        }
    }
}
