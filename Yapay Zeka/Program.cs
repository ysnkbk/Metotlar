using System;
using System.Collections.Generic;
using System.Text;
namespace Yapay_Zeka
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            Console.WriteLine("Selam Yasin " );
            
            Console.WriteLine("Lutfen devam etmek icin 0 a bas Yasin askım");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Yasin Aşkım sana nasıl yardımcı olabilirim" + "\t");
                    Console.WriteLine("gırdıgın sayının karesini söylemem ici 1 e" + "\t");
                    Console.WriteLine("gırdıgın sayının ıstedıgın sayı ıle carpımı ıcın 2 ye" + "\t");
                    Console.WriteLine("gırdıgın sayı kadar senı sevıyorum demem ıcın 3 e" + "\t");
                    Console.WriteLine("HIC ISIK YOK ISE 4 E BAS ASKO" + "\t");
                    int sayin = Convert.ToInt32(Console.ReadLine());
                    if (sayin > 4 || sayin < 1)
                    {
                        i = 0;
                    }
                    else
                    {
                        if (sayin == 1)
                        {
                            Console.WriteLine("Yasin Aşko sayını gir" + "\t");
                            int sayim = Convert.ToInt32(Console.ReadLine());
                            int sonuc = sayim * sayim;
                            Console.WriteLine("Yasin Aşko karesi bu ediyor = "+sonuc + "\t");
                        }
                        if (sayin == 2)
                        {
                            Console.WriteLine("Yasin Aşko sayını gir" + "\t");
                            int sayi1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Yasin Aşko ıkıncı sayını gir" + "\t");
                            int sayi2 = Convert.ToInt32(Console.ReadLine());
                            int sonuc = sayi1 * sayi2;
                            Console.WriteLine("Yasin Aşko karesi bu ediyor = " + sonuc + "\t");
                        }
                        if (sayin == 3)
                        {
                            Console.WriteLine("Yasin Aşko sayını gir" + "\t");
                            int Ss = Convert.ToInt32(Console.ReadLine());
                            for (int s = 0; s < Ss; s++)
                            {
                                Console.WriteLine("Yasin Aşko Senı COOOOOOOK SEVİYOMM" + "\t");

                            }
                           
                        }
                        if (sayin == 4)
                        {
                            Console.WriteLine("HIC ISIK YOK" + "\t");
                            i = 3;
                            Console.WriteLine("bye bye yasin asko" + "\t");
                        }
                    }

                }
            }
        }
    }
}
