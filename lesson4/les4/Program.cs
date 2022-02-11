using System;
namespace Lesson
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic) // к 1 заданию
        {
            return  $"{lastName} {firstName} {patronymic}";
        }

        static int SumAll(string[] toConv) // ко 2 заданию
        {
            int sum = 0;
            foreach (string conv in toConv)
            {
                sum += Convert.ToInt32(conv);
            }
            return sum;
        }

        public enum Season  // к 3 заданию
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static string ReturnSeason(string month)
        {
            int monthNum;
            int seasonIndx;
            try
            {
                monthNum = Convert.ToInt32(month);
            }
            catch
            {
                return "Введено не число";
            }

            if ((monthNum < 1) || (monthNum > 12))
            {
                return "Нет столько месяцев";
            }
            else if ((monthNum >= 3) && (monthNum <= 5))
            {
                seasonIndx = 0;
            }
            else if ((monthNum >= 6) && (monthNum <= 8))
            {
                seasonIndx = 1;
            }
            else if ((monthNum >= 9) && (monthNum <= 11))
            {
                seasonIndx = 2;
            }
            else
            {
                seasonIndx = 3;
            }
            return Convert.ToString((Season)seasonIndx);
         }

        static int fib(int i) // к 3 заданию
        {
            if (i <= 1)
            {
                return i;
            } 
            else
            {
                return fib(i - 2) + fib(i - 1);
            }
        }

        static void Main(string[] args)
        {
            // 1 задание
            string firstName, lastName, patronymic;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Введите фамилию: ");
                lastName = Console.ReadLine();
                Console.Write("Введите Имя: ");
                firstName = Console.ReadLine();
                Console.Write("Введите отчество: ");
                patronymic = Console.ReadLine();
                Console.WriteLine(GetFullName(firstName, lastName, patronymic));
            }

            // 2 задание
            Console.Write("Введите числа через пробел: ");
            string[] splitString = Console.ReadLine().Split(' ');
            Console.WriteLine(SumAll(splitString));

            // 3 задание
            Console.Write("Введите номер месяца:");
            string month = Console.ReadLine();
            Console.WriteLine(ReturnSeason(month));

            // 4 задание
            Console.Write("Введите значение для вычисления числа Фибоначчи: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фиббоачи равно - {0}", fib(f));
        }
    }
}