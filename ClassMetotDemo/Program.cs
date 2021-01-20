using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(1, "Engin", "DEMIROG", 10);
            Musteri musteri2 = new Musteri(2, "Samet", "DOGAN", 20);

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddCustomer(musteri1);
            musteriManager.AddCustomer(musteri2);
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.ListCustomer(musteriler);
            musteriManager.DeleteCustomer(musteri2);
            
        }
    }
}
