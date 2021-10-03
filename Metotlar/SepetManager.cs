using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("sepeti eklendi ve güncellendi"+product.Adi);
        }
        public void Ekle2(string urunadi,double fiyati,string aciklamasi,int urunstogu)
        {
            Console.WriteLine("sepete eklendi ve güncellendi " + urunadi+fiyati+aciklamasi+"\n");
        }
           
    }
}
