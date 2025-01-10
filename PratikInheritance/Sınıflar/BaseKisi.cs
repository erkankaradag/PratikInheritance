using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikInheritance.Sınıflar
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }

    }
}
