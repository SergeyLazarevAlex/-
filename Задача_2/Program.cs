using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static int SummArrayRecursion(int[] MyMass, int index = 0)
        {
            if (index >= MyMass.Length)
                return 0;
            return MyMass[index] + SummArrayRecursion(MyMass, index +1);
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,5 };
            Console.Write("Сумма эллементов масссива = "+ SummArrayRecursion(MyMass: arr));
            Console.ReadLine();
        }
    }
}
