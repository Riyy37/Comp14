using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    /// <summary>
    /// Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = InPut("n = ");
            Function(n);
            Console.ReadKey();
        }
        static void Function(int n)
        {
            
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine(i);
            }    
        }
        static int InPut(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

    }
}
