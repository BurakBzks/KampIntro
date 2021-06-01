using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {   //int,decimal,float,boolean value types değer tiplerinde değer atanıyor bu yüz den sayi1'e bir defa değer atanınca tekrar sayı2 değişse de sayi1 değişmiyor.
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            //array,class,interface referans tipi olduğu için bellekde sadece referans numarası gidiyor bu yüzden değişiyor.
            int[] sayilar1 = new int[] {1,2,3 };
            int[] sayilar2 = new int[] {10,20,30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //Referans tipi olduğu için değişiyor.
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Bozkuş";
            person2 = person1;
            person1.FirstName = "Can";
            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Han";


            Employee employee = new Employee();


            Person person3 = customer;
            customer.FirstName = "Ahmet";

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //:person miras alma olayı yani miras aldığımız sınıfı ataya biliriz.base class denir buna.
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }



}
