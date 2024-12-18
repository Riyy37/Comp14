using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    /// <summary>
    /// Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Function();
            Console.ReadKey();
        }
        static void Function()
        {
            for (int i = 0; i<=4; i++)
            {
                Console.WriteLine("Hi");
            } 
                
        }
    }
}
