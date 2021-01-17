using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.Id = 1;
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Yeşil Elma";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Adi = "Karpuz";
            product2.Fiyat = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2};

            //type-safe -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine("ID : " + product.Id);
                Console.WriteLine("Ürün Adı : " + product.Adi);
                Console.WriteLine("Fiyatı : " + product.Fiyat);
                Console.WriteLine("Açıklama : " + product.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("--------------------Metotlar---------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

        }
    }
}
