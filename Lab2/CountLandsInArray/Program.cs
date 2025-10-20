using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLandsInArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            int counter = 0;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Enter number {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < len - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine($"Count lands in array is: {counter}");
        }
    }
}
