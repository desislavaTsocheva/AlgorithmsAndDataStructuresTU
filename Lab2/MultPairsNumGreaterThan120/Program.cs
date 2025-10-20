using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultPairsNumGreaterThan120
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            int multiplication = 1;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Enter number {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < len - 1; i++)
            {
                if ((array[i] + array[i + 1]) > 120)
                {
                    multiplication *= array[i] + array[i + 1];
                }
            }
            Console.WriteLine($"Multiplication of pairs with sum greater than 120 is: {multiplication}");
        }
    }
}
