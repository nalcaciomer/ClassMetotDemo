using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir bankada müşteri takibi yapmak istiyorsunuz.
            // Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz.(Id, Ad, Soyad)
            // MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri 
            // ekleme, listeleme, silme gibi metotları simule ediniz.

            Musteri musteri = new Musteri() { Adi = "Ömer", Soyadi = "Nalçacı", Adres = "Çorum", Eposta = "nalcaciomer@outlook.com", Id = 1 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteri);

            musteriManager.Ekle(musteri);

            musteriManager.Sil(musteri);

            musteriManager.Guncelle(musteri);

        }
    }
}
