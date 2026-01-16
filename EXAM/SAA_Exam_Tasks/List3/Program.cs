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
    static void AddNode(ref Node head, ref Node avail)
    {
        if (head == null || avail == null) return;

        Node current = head;
        int pos = 1;

        while (current != null && current.Next != null)
        {
            if (pos % 2 == 0 && current.Data > 0 && avail != null)
            {
                Node newNode = avail;
                avail = avail.Next;

                newNode.Data = current.Next.Data * 2;
                newNode.Next = current.Next;
                current.Next = newNode;

                current = newNode.Next; 
                pos += 2;
            }
            else
            {
                current = current.Next;
                pos++;
            }
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
        Node head = new Node(5);
        head.Next = new Node(2);
        head.Next.Next = new Node(9);
        head.Next.Next.Next = new Node(3);
        head.Next.Next.Next.Next = new Node(20);

        Node avail = new Node(0);
        avail.Next = new Node(0);
        avail.Next.Next = new Node(0);

        Console.WriteLine("Оригинален списък:");
        PrintList(head);

        AddNode(ref head, ref avail);

        Console.WriteLine("Списък след премахване:");
        PrintList(head);

        Console.WriteLine("Списък Avail:");
        PrintList(avail);
    }
}