//Да се премахне всеки втори възел от списък,
//чиято стойност е два пъти по-голяма от поредния номер на възела в списъка.
//Премахнатите ел-ти да се поставят в нов списък
//с начало Avail

namespace MatrixTask1;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class Program
{
    static void RemoveNode(ref Node head, ref Node avail)
    {
        Node current = head;
        Node prev = null;
        int pos = 1;
        while (current != null)
        {
            if (current.Data >= 2 * pos)
            {
                Node remove=current;
                if(prev == null)
                {
                    head = current.Next;
                }
                else
                {
                    prev.Next = current.Next;
                }
                current = current.Next;
                remove.Next = avail;
                avail = remove;
            }
            else
            {
                prev = current;
                current = current.Next;
            }
            pos++;
        }
    }
    static void PrintList(Node head)
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        // Примерен списък: 5 → 2 → 9 → 3 → 20
        Node head = new Node(5);
        head.Next = new Node(2);
        head.Next.Next = new Node(9);
        head.Next.Next.Next = new Node(3);
        head.Next.Next.Next.Next = new Node(20);

        Node avail = null;

        Console.WriteLine("Оригинален списък:");
        PrintList(head);

        RemoveNode(ref head, ref avail);

        Console.WriteLine("Списък след премахване:");
        PrintList(head);

        Console.WriteLine("Списък Avail:");
        PrintList(avail);
    }
}