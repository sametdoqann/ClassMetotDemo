using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.Name + " " + musteri.Surname);
        }
        public void DeleteCustomer(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Name + " " + musteri.Surname);
        }
        public void ListCustomer(Musteri[] musteriler)
        {
            Console.WriteLine();
            Console.WriteLine("******MÜŞTERİ LİSTESİ********");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
            }
            Console.WriteLine("******************************");
            Console.WriteLine();
        }
    }
}
