using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool loginControl = false;
            double dolarBugun = 7.35;
            double dolarDun = 7.45;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Sabit Oku");
            }

            if (loginControl == true)
            {
                Console.WriteLine("Kullanıcı ayarları sayfası");
            }
            else
            {
                Console.WriteLine("Giriş yap sayfası");
            }


        }
    }
}
