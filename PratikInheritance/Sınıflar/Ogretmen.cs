using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikInheritance.Sınıflar
{
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }
        public void OgretmenBilgileriYazdir()
        {
            // Base sınıfın metodunu çağırıyoruz
            BilgileriYazdir();
            Console.WriteLine($"Maaş: {Maas}"); // Maaş bilgisi para formatında yazdırılır


        }
    }
}
