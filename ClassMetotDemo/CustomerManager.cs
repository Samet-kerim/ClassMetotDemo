using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager 
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi={0}", customer.MusteriAdi);
        
        
        }
        public void Sil(Customer customer)
        {
            Console.WriteLine("Müşteri silindi={0}", customer.MusteriAdi);


        }
    }
}
