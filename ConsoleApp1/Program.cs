namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList<int> minLista = new SimpleLinkedList<int>();
            minLista.AddFirst(8643);
            minLista.AddFirst(3534);
            minLista.AddFirst(6544);
            // skriver ut "count: 3"
            Console.WriteLine("count: " + minLista.Count());
        }

    }
}
