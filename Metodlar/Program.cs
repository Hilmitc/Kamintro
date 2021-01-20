using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            
            Console.WriteLine("-----------Metotlar------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetMAnager = new SepetManager();
            sepetMAnager.Ekle(urun1);
            sepetMAnager.Ekle(urun2);

            sepetMAnager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetMAnager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetMAnager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}




//Don't repeat yourself - DRY - Clean Code - Best Practise