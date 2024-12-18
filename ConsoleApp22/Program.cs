using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    /// <summary>
    /// Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Function();
            Console.ReadKey();
        }
        //static void Function()
        //{
        //    int x = 1;

        //    while (x<=10)
        //    {
        //        Console.WriteLine(x);
        //        x++;
        //    }
        //}
        //static void Function()
        //{
        //    int x = 1;
        //    do
        //    {

        //    }
        //        while (x <= 10) ;
        //}

        //static void Function()
        //{
        //    for (int x=1;x<=10;x++)
        //    {
        //        Console.WriteLine(x);
        //    }
        //}
        static void Function()
        {
            for (int x = 10; x >= 1; x--)
            {
                Console.WriteLine(x);
            }
        }
    }
}
