//да се работи с редица, дефинирана като $x_{n+1} = 2x_n + 3$,
//при начално условие $x_0 = 2$.
//Трябва да намерим сумата на нечетните елементи,
//които се намират в интервала между първия елемент, по-голям от 100,
//и първия елемент, по-голям от 10000.

namespace ExamTask2;

public class Program
{
    public static void Main(string[] args)
    {
        int start = 2;
        int x = 0;
        int sum = 0;
        List<int> list = new List<int>();
        while (start<=10000)
        {
            start = 2 * start + 3;
            if (start > 100 && start < 10000)
            {
                if (start % 2 != 0)
                {
                    sum += start;
                    list.Add(start);
                }
            }
        }
        for(int i=0;i<list.Count; i++)
        {
            Console.Write(list[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine(sum);
    }
}
