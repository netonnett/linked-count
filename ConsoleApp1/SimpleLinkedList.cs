namespace ConsoleApp1
{
    internal class SimpleLinkedList<T>
    {
        
        public Node<T> First;
        
        

        public void AddFirst(T data)
        {
            // skapa ett nytt Node-objekt och lägg in värdet data
            Node<T> newNode = new Node<T>();
            newNode.Value = data;

            // om det redan finns ett element (nod) inlagd, så
            // länka den nya noden till den gamla noden
            if (First != null)
                newNode.Next = First;

            // sätt listans första nod till att vara den nya noden
            First = newNode;
        }

        public int Count()
        {

            Node<T> minNod = First;

            int numdizzy = 0;
            while (minNod != null)
            {
                Console.WriteLine(minNod.Value);
                minNod = minNod.Next;
                numdizzy++;
            }
            return numdizzy;
            
            
        }

    }
}
