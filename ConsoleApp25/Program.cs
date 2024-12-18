using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    /// <summary>
    /// С использованием цветового оформления консоли:
    ///а) вывести на экран горизонтальную строку из 18 символов.
    ///б) вывести на экран вертикальную строку из 25 символов.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа с консолью";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Function();
            Function1();
            Console.ReadKey();
        }
        static void Function()
        {
            for (int i = 1; i <= 18; i++)
            {
                Console.Write("#");
            }
        }
        static void Function1()
        {
            for (int i = 1;i <= 18;i++)
            {
                Console.WriteLine("#");
            }
        }
    }
}
