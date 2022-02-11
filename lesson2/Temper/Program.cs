using System;
namespace Tempa
{
    class Program
    {
       static void ChotOrNot(int t)
       {
            if (t%2 == 0)
            {
                Console.WriteLine("Введено четное число");
            } else
            {
                Console.WriteLine("Введено нечетное число");
            }
       }

        static void RainyMan(int m,int r)
        {
            if (((m == 1) || (m == 2) || (m == 12 )) && (r > 0))
            {
                Console.WriteLine("И сегодня он влажный");
            }
        }
        static void Months(int m, int r)
        {
            switch (m)
            {
                case 1:
                    Console.WriteLine("Это Январь");
                    RainyMan(m, r);
                    break;
                case 2:
                    Console.WriteLine("Это Февраль");
                    RainyMan(m, r);
                    break;
                case 3:
                    Console.WriteLine("Это Март");
                    break;
                case 4:
                    Console.WriteLine("Это Апрель");
                    break;
                case 5:
                    Console.WriteLine("Это Ласковый Май");
                    break;
                case 6:
                    Console.WriteLine("Это Июнь");
                    break;
                case 7:
                    Console.WriteLine("Это Июль");
                    break;
                case 8:
                    Console.WriteLine("Это Август");
                    break;
                case 9:
                    Console.WriteLine("Это Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Это Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Это Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Это Декабрь");
                    RainyMan(m, r);
                    break;
                default:
                    Console.WriteLine("А это нихера не месяц");
                    break;
            }
        }

   
        static void Main(string[] args)
        {
            Console.Write("Введите минималную температуру за сутки: ");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            ChotOrNot(minTemp);
            Console.Write("Введите максимальную температуру за сутки: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            ChotOrNot(maxTemp);
            int srT = Convert.ToInt32(((float)minTemp + (float)maxTemp) / 2);
            Console.WriteLine($"Среднесуточная температура: {srT}");
            Console.Write("Введите порядковый номер месца: ");
            int mon = Convert.ToInt32(Console.ReadLine());
            Months(mon, srT);

        }
    }
}
