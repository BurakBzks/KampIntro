using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //Diziyi newlememiz lazım . Referans tipi olduğu için newlememiz lazım.
        //alt taraftaki bloğa constructor denir bir class new lendiğinde çalışacak bloğa denir
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //tempArray=geçici dizi oluşturuyoruz yeni bir eleman eklediğimizde diğer elemanlarımız kayıp olmasın diye.
            //for yapıpsp ilede geçici dizide bulunan verileri ekliyoruz .
            T[] tempArray = items; 
            //dizinin eleman sayısını bir arttırıyor.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //son elemanını vermiş olduk aslında son elemanı şuanda eklemiş olduk.
            items[items.Length - 1] = item;
        }
        
    }
}
