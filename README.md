# C#'de Kalıtım Örneği

Bu proje, C#'de kalıtım (inheritance) kavramını basit bir örnekle göstermektedir. Projede bir temel sınıf (`BaseKisi`) ve bu sınıftan türeyen öğrenci (`Ogrenci`) ve öğretmen (`Ogretmen`) sınıfları yer almaktadır.

## Proje Yapısı

### Ad Alanı: `PratikInheritance`

#### Sınıflar

1. **`BaseKisi`** (Temel Sınıf)
   - **Özellikler**:
     - `Ad` (string): Kişinin adı.
     - `Soyad` (string): Kişinin soyadı.
   - **Metotlar**:
     - `BilgileriYazdir()`: `Ad` ve `Soyad` bilgilerini konsola yazdırır.

2. **`Ogrenci`** (`BaseKisi`'den türemiştir)
   - **Ek Özellikler**:
     - `OgrenciNumarasi` (int): Öğrenci numarası.
   - **Metotlar**:
     - `OgrenciBilgileriniYazdir()`: Öğrenci numarası, adı ve soyadını konsola yazdırır. `BaseKisi` sınıfındaki `BilgileriYazdir()` metodunu kullanır.

3. **`Ogretmen`** (`BaseKisi`'den türemiştir)
   - **Ek Özellikler**:
     - `Maas` (decimal): Öğretmenin maaşı.
   - **Metotlar**:
     - `OgretmenBilgileriniYazdir()`: Öğretmenin maaşı, adı ve soyadını konsola yazdırır. `BaseKisi` sınıfındaki `BilgileriYazdir()` metodunu kullanır.

### Program Sınıfı
`Program` sınıfı, `Ogrenci` ve `Ogretmen` sınıflarından nesneler oluşturur, bu nesnelerin özelliklerini doldurur ve bilgilerini konsola yazdırır.

## Örnek Kod

```csharp
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
            ogretmen.OgretmenBilgileriniYazdir();
        }
    }
}
```

## Çıktı Örneği

Programı çalıştırdığınızda konsol çıktısı aşağıdaki gibi olacaktır:

```
Öğrenci Bilgileri
Ad: Metin, Soyad: Tan
Öğrenci Numarası: 601

Öğretmen Bilgileri
Ad: Ali, Soyad: Kara
Maaş: 10.000
```

## Gösterilen Özellikler
- Kalıtım
- Nesne oluşturma
- Özellik atama
- Konsol çıktısı formatlama

## Nasıl Çalıştırılır
1. Proje kodunu IDE'nize kopyalayın.
2. Programı çalıştırarak çıktıyı gözlemleyin.

