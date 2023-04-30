namespace G09_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Pop();

            for (int i = 0; i < myStack.Count; i++)
            {
                Console.WriteLine(myStack.Get(i));
            }

            //MyList<int> myList = new MyList<int>();
            //myList.Add(1);
            //myList.Add(2);
            //myList.Add(3);
            //myList.Add(4);
            //myList.RemoveAt(2);

            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList.Get(i));
            //}

            //MyQueue<int> myQueue = new MyQueue<int>();
            //myQueue.Enqueue(1);
            //myQueue.Enqueue(2);
            //myQueue.Enqueue(3);
            //myQueue.Enqueue(4); 
            //myQueue.Dequeue();

            //for (int i = 0; i < myQueue.Count; i++)
            //{
            //    Console.WriteLine(myQueue.Get(i));
            //}
        }
    }
}