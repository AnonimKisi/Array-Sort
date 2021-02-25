using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            Console.Write("How many elements will the array have?: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = { };
            Array.Resize(ref array, x);
            Console.WriteLine();
            while (i < x)
            {
                Console.Write("element " + i + " of the array: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            i = 0;
             Array.Sort(array);
            Console.Write("\nSorted: ");
             while(i < x)
             {
                 Console.Write(array[i] + ", ");
                 i++;
             }
             Console.WriteLine("\b\b \n----------------------------");
            Main();
        }
    }
}