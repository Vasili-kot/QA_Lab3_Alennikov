using System;

namespace QA_Lab3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Produkt rr1 = new Produkt();
            Produkt_hleb rr2 = new Produkt_hleb();
            Produkt_hleb rr3 = new Produkt_hleb();
            rr1.Init(100, 150);
            rr2.Init(315, 94, 30);
            rr3.Init(1000, 300, 60);
            Console.WriteLine("Ценность продуктов без хлебных единиц: \n" + Math.Round(rr1.cennost(), 4));
            Console.WriteLine("Ценность продуктов с хлебными единицами: \n" + Math.Round(rr2.Cennost(), 4) + "\n" + Math.Round(rr3.Cennost(), 4));

            Dieta fl = new Dieta();
            char[] nf = "Продукт 1".ToCharArray();
            fl.Init(nf, 100, 150, 220, 410, 90, 100, 400);
            fl.Display();
            Console.WriteLine("\nОбщая ценность всех продуктов: " + Math.Round(fl.allcen(), 4));
            Console.Read();
        }
    }
}
