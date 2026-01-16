//Да се премахнат всички възли от еднопосочен списък, чиято информационна стойност е
//най-малко три пъти по-голяма от поредния номер на възела в списъка.
//Премахнатите възли да се поставят в нов списък с начало Avail.
//Елементите на списъка са цели числа.

class Node
{
    public int Data;  //стойност на възела
    public Node Next; //стойност на указателя към следващия възел

    public Node(int data)
    {
        this.Data = data;
        Next = null;
    }

    class Program
    {
        static void RemoveNodes(ref Node head,ref Node avail)
        {
            //current е списъка с елементите, 
            //от него премахва тези, отговарящи на условието
            Node current = head;
            Node prev = null;
            int pos = 1;
            while (current != null)
            {
                if (current.Data >= 3 * pos)
                {
                    //Премахваме възела, но го зап-ме, 
                    //за да го нобавим в новия списък
                    Node remove = current;

                    //Ако махаме 1-вия възел
                    if (prev == null)
                    {
                        //Преместваме напред
                        head = current.Next;
                    }

                    //Ако махаме вътрешен възел
                    else
                    {
                        prev.Next = current.Next;
                    }
                    current = current.Next;
                    remove.Next = avail;
                    //Премахнатите ел-ти се добавят в нов списък
                    avail = remove;
                }

                //Ако възела не се премахва
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

        static void Main()
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

            RemoveNodes(ref head,ref avail);

            Console.WriteLine("Списък след премахване:");
            PrintList(head);

            Console.WriteLine("Списък Avail:");
            PrintList(avail);
           
        }
    }
}