//Вход: Два масива($A$ и $B$) с дължина $n$,
//запълнени с положителни цели числа.
//Сравняваме елементите на еднакви позиции.
//По-големият от двата се записва в нов масив $C$.
//Изход: Изчисляваме сумата на елементите в масив $C$.
//Ако тази сума е трицифрено положително число (между 100 и 999 включително),
//извеждаме последната ѝ цифра.

namespace ArrayExamTask1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 2, 5, 6, 34, 8 };
        int[] b = { 5, 67, 32, 12, 5 };
        int[] c = new int[5];

        for (int i = 0; i < 5; i++) 
        {
            if (a[i] > b[i])
            {
                c[i] = a[i];
            }
            else
            {
                c[i] = b[i];
            }
        }

        int sum = 0;
        for (int i = 0; i < 5; i++) 
        {
            sum += c[i];
            Console.Write(c[i]+" ");
        }
        Console.WriteLine();
        if (sum >= 100 && sum <= 999)
        {
            //last digit
            sum=sum % 10;
        }
        Console.WriteLine(sum);

    }
}
