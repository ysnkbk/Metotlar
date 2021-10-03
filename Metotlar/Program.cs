using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not yourself
            Product urun1 = new Product();
            Product urun2 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";
            urun1.Id = 1424;
            urun1.UrunStogu = 45;
            urun2.Adi = "karpuz";
            urun2.Aciklama = "sulu sulu";
            urun2.Id = 14132;
            urun2.Fiyati = 45;
            urun2.UrunStogu = 50;
            Product[] urunler = new Product[] {urun1,urun2};
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Id);
                Console.WriteLine(product.UrunStogu);

            }
            Console.WriteLine("\n \n \n---------Metotlar------------------------");
            SepetManager sepetmanager = new SepetManager();
            Console.WriteLine("\n\n");
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            SepetManager sepetmanager2 = new SepetManager();
            sepetmanager2.Ekle2("elma", 40, "amasya elması",50);



            {

            }
           
            

        }
    }
}
