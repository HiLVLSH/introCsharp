using System;
namespace HHelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            } while (n < 0);
        }
    }
}