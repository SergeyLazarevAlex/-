using System;

namespace MyProgramm1
{   
    class Program
    {
        static void ArrayRecursion(int[] MyArray, int index=0)
        {
            if (index >= MyArray.Length)
                return;

            Console.WriteLine(MyArray[index]);
            ArrayRecursion(MyArray, index+1);
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8};
            Console.WriteLine("Вывод массива: ");
            ArrayRecursion(MyArray: arr);
            Console.ReadLine();
        }
    }
}
