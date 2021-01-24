using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Harun";
            //musteri1.SoyAdi = "Didin";
            //musteri1.Id = 1;
            //musteri1.TcNo = "1212121212212";
            //musteri1.SirketAdi = "?";//şirket adı burada alakalı değil,bu kullanım hatalı. şirket adı olan veya olmayan müşteriler ileride karışır.
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "111";
            musteri1.Adi = "Harun";
            musteri1.SoyAdi = "Didin";
            musteri1.TcNo = "232323222326262";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12555";
            musteri2.SirketAdi = "DEBAK Aş";
            musteri2.VergiNo = "122232-23";

            Musteri musteri3 = new GercekMusteri();            
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
