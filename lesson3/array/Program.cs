using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 пункт не понял, сделал как понял XD
            int indexJ = 0;
            Console.Write("Введите размер матрицы: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int[,] dArray = new int[r, r];
            for (int i = 0; i < r; i++)
            {

                for (int j = 0; j < r; j++)
                {
                    if (j == indexJ) {
                        dArray[i, j] = 1;
                    }
                    else
                    {
                        dArray[i, j] = 0;
                    }
                    Console.Write("{0}\t", dArray[i, j]);
                }
                indexJ++;
                Console.WriteLine();
            }

            // 2 пункт - справочник

            string[,] phoneNumb = new string[5, 2] { { "Иванов", "991" }, { "Петров", "992" }, { "Сидоров", "993" }, { "Кротов", "994" }, { "Котов", "995" } };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", phoneNumb[i, j]);
                }
                Console.WriteLine();
            }

            // 3 пункт

            string hello = "Hello";
            int re = hello.Length;
            for (int i = 1; i <= re; i++)
            {
                Console.Write(hello[^i]);
            }
            Console.WriteLine();

            //4 пункт
            char[][] sBattle = new char[][]
            {
                new char[] {'X','O','O','O','O','X','O','O','O','X'},
                new char[] {'X','O','O','O','O','X','O','O','O','O'},
                new char[] {'X','O','O','O','O','O','O','X','O','O'},
                new char[] {'O','O','O','O','O','O','O','O','O','O'},
                new char[] {'O','O','O','O','O','O','O','O','O','O'},
                new char[] {'O','O','O','X','X','X','X','O','O','O'},
                new char[] {'O','X','O','O','O','O','O','X','O','O'},
                new char[] {'O','O','O','X','O','O','O','O','O','O'},
                new char[] {'X','X','O','X','O','X','O','O','O','O'},
                new char[] {'O','O','O','X','O','O','O','O','X','X'},
            };
            for (int i = 0; i < sBattle.Length; i++)
            {
                for (int j = 0; j < sBattle[i].Length; j++)
                {
                    Console.Write(sBattle[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
