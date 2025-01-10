using System;
using System.ComponentModel;
using PratikInheritance.Sınıflar;
namespace PratikInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci()
            {
                Ad = "Metin",
                Soyad = "Tan",
                OgrenciNumarasi = 601
            };
            Console.WriteLine("Öğrenci Bilgileri");
            ogrenci.OgrenciBilgileriniYazdir();


            Ogretmen ogretmen = new Ogretmen()
            {
                Ad = "Ali",
                Soyad = "Kara",
                Maas = 10.000m
            };
            Console.WriteLine("\nÖğretmen Bilgileri");
            ogretmen.OgretmenBilgileriYazdir();

        }
    }
}