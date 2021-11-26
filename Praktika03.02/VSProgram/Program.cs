using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] B = new int[10, 10];
            Random rand = new Random();
            Console.WriteLine("Ввод n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Заполняем массив");
            Vvod(B, n);
            Sum(B, n);
            Console.WriteLine();
        }
        static void Vvod(int[,] B, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = rand.Next(0, 14);
                    Console.WriteLine("B[" + i + "][" + j + "]=" + B[i, j]);
                }
        }
        static void Sum(int[,] B, int n)
        {
            int S = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (0 < B[i, j] && B[i, j] < 10)
                        S = S + B[i, j];
                }
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
