using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 1;
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.İo";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Musteri hem tüzel hemde gerçek müşterinin referansını tutuyor.

            MusteriManager musteriManager = new MusteriManager();



            //eğerki bir nesnede bir değeri kullanmak zorunda değilsen demekki orada soyutlama hatası yapıyosun denir.örneğin şirket adı gibi.
            //gerçek-tüzel birbirinin yerine kullanılamazlar.
            //SOLID -> L harfi bunu anlatır.
        }
    }
}
