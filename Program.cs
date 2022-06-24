using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ULPRbezvar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Прога А
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var dt = new DateTime(c, b, a);
            var bdt = new DateTime(c, 1, 1);
            Console.WriteLine();
            Console.WriteLine("Сейчас {0}-й день в году", (dt - bdt).Days + 1);
            Console.WriteLine();

            if ((c % 4 == 0) && (c % 100 != 0) && (c % 400 == 0))
            {
                Console.WriteLine("Осталось {0} дней до конца года", 366 - (dt - bdt).Days + 1);
            }

            Console.WriteLine("Осталось {0} дней до конца года", 365 - ((dt - bdt).Days + 1));
            Console.ReadKey();

            //Прога Б
            /*
            
            int c = 0;
            Console.WriteLine("Введите число, месяц и год: ");
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            DateTime today = DateTime.Parse($"{day}.{month}.{Convert.ToString(year)}");
            Console.WriteLine(today);
            int jYear = year;
            while (jYear > 0)
            {
                jYear = jYear - 128;
                c++;
            }
            today = today.AddDays(c);
            Console.WriteLine(today.ToShortDateString());
            Console.ReadKey();

            */

            // Прога В
            /*
            
            Console.WriteLine("Введите кол-во элементов: ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next();
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            if (mas.Length < 1) return;
            for (int i = 0; i < mas.Length; i++)
            {
                int k = mas[i];
                int rnd = r.Next(i, mas.Length);
                mas[i] = mas[rnd];
                mas[rnd] = k;
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();

            */

            //Прога Г
            /*
            
            Console.Write("Введите конечное число диапозона n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество попыток: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int value = rnd.Next(1, n);
            int i = 0;
            do
            {
                Console.WriteLine("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == value)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                if (a < value) Console.WriteLine("Число больше");
                if (a > value) Console.WriteLine("Число меньше");
                i++;
            }
            while (i != k);
            Console.WriteLine();
            Console.WriteLine("Игра завершена!");
            Console.ReadLine();

            */
        }
        //Прога Д и Е
        /*
        
        public static byte rand()
        {
            RNGCryptoServiceProvider r = new RNGCryptoServiceProvider();
            byte[] rnb = new byte[1];
            r.GetBytes(rnb);
            return (rnb[0]);
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                double Random = rand();
                Console.Write(Random);
                Console.Write(" ");
            }
            Console.ReadLine();
            Console.ReadKey();
        }

        */
    }
}