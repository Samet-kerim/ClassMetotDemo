using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.MusteriAdi = "Samet";
            customer1.MusteriSoyadi = "KILIÇ";
            customer1.IbanNo = 123456;

            CustomerManager cmanager = new CustomerManager();
            cmanager.Ekle(customer1);
            cmanager.Sil(customer1);










        }

        
      
        
    }
}
