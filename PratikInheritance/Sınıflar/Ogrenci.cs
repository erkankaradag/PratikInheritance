using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikInheritance.Sınıflar
{
    internal class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi { get; set; }
        public void OgrenciBilgileriniYazdir()
        {
            // Base sınıfın metodunu çağırıyoruz
            BilgileriYazdir();
            Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}");
        }
    }
}
