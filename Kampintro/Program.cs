using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //Do not repeat yourselt - Kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int öğrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");            
            }
            else
            {
                Console.WriteLine("degişmedi butonu");
            }
            

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);




        }
    }
}