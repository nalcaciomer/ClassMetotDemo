using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + ". Müşteri");
            Console.WriteLine("Adı: " + musteri.Adi + " Soyadı: " + musteri.Soyadi  + " Eposta: " + musteri.Eposta);
        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sisteme Müşteri Ekleme İşlemi Gerçekleştiriliyor...");
            Console.WriteLine("Tebrikler! Müşteri Sisteme Başarıyla Eklendi!");
            Console.WriteLine("Müşteri Bilgileri: ");
            Listele(musteri);
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Hangi Bilgisini Güncellemek İstiyorsunuz? (1-Ad, 2-Soyad, 3-Adres,4-Eposta");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Müşterinin Yeni Adını Yazınız: ");
                    musteri.Adi = Console.ReadLine();
                    Console.WriteLine("Müşteri Adı Başarıyla Güncellendi!");
                    Listele(musteri);
                    break;
                case "2":
                    Console.WriteLine("Müşterinin Yeni Soyadını Yazınız: ");
                    musteri.Soyadi = Console.ReadLine();
                    Console.WriteLine("Müşteri Soyadı Başarıyla Güncellendi!");
                    Listele(musteri);
                    break;
                case "3":
                    Console.WriteLine("Müşterinin Yeni Epostasını Yazınız: ");
                    musteri.Eposta = Console.ReadLine();
                    Console.WriteLine("Müşteri Eposta Başarıyla Güncellendi!");
                    Listele(musteri);
                    break;
                default:
                    Console.WriteLine("Güncelleme İşlemi Başarısız!");
                    break;
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteriyi Silme İşlemini Onaylıyor musunuz? (y / n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Müşteri Sistemden Siliniyor...");
                Console.WriteLine("Silme İşlemi Başarıyla Tamamlandı!");
            }
            else
            {
                Console.WriteLine("Müşteri Silme İşlemi İptal Edildi!");
            }
        }
    }
}
