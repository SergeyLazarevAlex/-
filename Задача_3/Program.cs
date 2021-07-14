using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static int SummValue(int value)
        {
            return value < 10 ? value : value % 10 + SummValue(value / 10);
        }
        static void Main(string[] args)
        {
            int value = 5618;
            Console.WriteLine("Сумма цифр числа 561 = "+ SummValue(value));
            Console.ReadLine();
        }
    }
}
