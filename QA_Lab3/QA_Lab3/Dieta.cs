using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3
{
    /// <summary>
    /// <brief>Базовый класс "Продукт"</brief>
    /// <details>Данный класс нужен для хранения и обработки информации об одном продукте</details>
    /// </summary>
    public class Produkt
    {
        protected double price; //стоимость
        protected int kalories; //калории

        /// <summary>
        /// Конструктор класса Produkt, инициализирующий переменные
        /// </summary>
        /// <param name="p">Стоимость продукта</param>
        /// <param name="k">калорийность продукта</param>
        public void Init(double p, int k)
        {
            price = p;
            kalories = k;
        }
        /// <summary>
        /// Отображает данные о продукте на экране
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Цена продукта:" + price + " Калорийность:" + kalories);
        }
        /// <summary>
        /// Считает ценность продукта
        /// </summary>
        /// <returns></returns>
        public double cennost()
        {
            return price / kalories;
        }

        /// <summary>
        /// Доступ к полю стоимость 
        /// </summary>
        /// <returns>price - стоимость</returns>
        public double totalC()
        {
            return price;
        }

        /// <summary>
        /// Доступ к полю калории
        /// </summary>
        /// <returns>kalories -  калории</returns>
        public int totalK()
        {
            return kalories;
        }

        
    }
    /// <summary>
    /// <brief>Производный класс "Продукт-хлеб"</brief>
    /// <author>Alennikov_SI</author> 
    /// <version>1.9</version> 
    /// <date>April 2023</date>
    /// <warning>Данный класс создан в учебных целях</warning> 
    /// Обычный дочерний класс, который отнаследован от ранее созданного класса Produkt
    /// </summary>
    class Produkt_hleb : Produkt
    {
        private int kolvo; //количество хлебных единиц

        /// <summary>
        /// Конструктор класса Produkt_hleb, инициализирующий переменные
        /// </summary>
        /// <param name="p">стоимость</param>
        /// <param name="k">калории</param>
        /// <param name="kl">кол-во хлебных единиц</param>
        public void Init(double p, int k, int kl)
        {
            base.Init(p, k);
            kolvo = kl;
        }

        /// <summary>
        /// Отображает количество хлебных единиц на экране
        /// </summary>
        public void Display()
        {
            base.Display();
            Console.WriteLine("Количество хлебных единиц: " + kolvo);
        }

        /// <summary>
        /// Считает ценность продукта с учетом хлебных единиц
        /// </summary>
        /// <returns></returns>
        public double Cennost()
        {
            kalories = kalories + kolvo * 2;
            return price / kalories;
        }

        /// <summary>
        /// Доступ к полю стоимость 
        /// </summary>
        /// <returns>_price - стоимость</returns>
        public double totalC()
        {
            return price;
        }
          /// <summary>
        /// Доступ к полю калории с учетом количества хлебных единиц
        /// </summary>
        /// <returns>kalories - кол-во калорий в продукте</returns>
        /// Формула для вычисления калорий продукта, при условии, что кол-во хлебных единиц умножается на 2:
        /// \f$ kalories = kalories + kolvo \times 2 \f$
        /// 
        public int totalK()
        {
            return kalories + kolvo * 2;
        }

    }

    /// <summary>
    /// <brief>Класс "Диета"</brief>
    /// <details>Содержит информацию о продуктах, их стоимости и их калориях.
    /// Также информацию охлебных единицах продуктов и общей ценности </details>
    /// </summary>
    public class Dieta
    {
        private char[] _name;
        private Produkt TypeR1 = new Produkt();
        private Produkt_hleb TypeR2 = new Produkt_hleb();
        private double _f1kolvo;
        private double _f2kolvo;


        /// <summary>
        /// Конструктор Dieta, принимает параметры типа Produkt и его производного
        /// </summary>
        /// <param name="name">Название продукта</param>
        /// <param name="f1price">стоимость первого продукта</param>
        /// ![Image](C:/test/produkt1.jpg)
        /// <param name="f2price">стоимость второго продукта</param>
        /// ![Image](C:/test/produkt2.jpg)
        /// <param name="f1kalories">калории первого продукта</param>
        /// <param name="f2kalories">калории второго продукта</param>
        /// <param name="f1kolvo">кол-во первого продукта</param>
        /// <param name="f2kolvo">кол-во второго продукта</param>
        /// <param name="kolvo">количество хлебных единиц в продуктах</param>
        public void Init(char[] name, double f1price, double f2price, int f1kalories, int f2kalories, int kolvo, int f1kolvo, int f2kolvo)
        {
            _name = name;
            TypeR1.Init(f1price, f1kalories);
            TypeR2.Init(f2price, f2kalories, kolvo);
            _f1kolvo = f1kolvo;
            _f2kolvo = f2kolvo;
        }

        /// <summary>
        /// Отображает на экране информацию о диете
        /// </summary>
        public void Display()
        {
            Console.Write("Название продукта:");
            foreach (char ch in _name)
            {
                Console.Write(ch);
            }
            Console.WriteLine("\n\nПродукт 1");
            TypeR1.Display();
            Console.WriteLine("Количество продукта гр: " + _f1kolvo);
            Console.WriteLine("\nПродукт 2");
            TypeR2.Display();
            Console.WriteLine("Количество продукта гр: " + _f2kolvo);
        }

        /// <summary>
        /// Вычисляет вычисляет общую ценность продуктов
        /// </summary>
        /// <returns>Ценность продуктов с учетом их массы</returns>

        public double allcen()
        {
            return (TypeR1.cennost() * _f1kolvo + TypeR2.cennost() * _f2kolvo) / 100;
        }
    }
}

