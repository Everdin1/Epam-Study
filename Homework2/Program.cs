using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Введите сколько у вас денег =  ");
            double  n = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1 бутылка воды стоит 2$\n1 булочка стоит = 1$ ");
            Console.Write("\n Сколько бутылок воды желаете приобрести? = ");
            double  waterCol = double.Parse(Console.ReadLine());

            Console.Write("\n Сколько булочек хотите скушать? = ");
            double  cookiesCol = double.Parse(Console.ReadLine());

            // цена
            int water = 2 * waterCol;
            int cookies = 1 * cookiesCol;

            if ((n - (water + cookies)) >= 0)
                Console.Write($"Сумма к оплате ={(water + cookies)} Ваш остаток = { n - (water + cookies) }");
            else
                Console.Write($"Сумма к оплате ={(water + cookies)}, Извините, но вам не хватает {n - (water + cookies)}$ ");
            Console.ReadKey();
        }

    }

}
