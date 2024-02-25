using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            const int count = 1000000;

            Console.WriteLine("Starting queue...");
            sw.Start();
            Queue queue = new Queue();
            for (int i = 0; i < count; i++)
            {
                queue.Enqueue(i);
            }
            while (queue.Count > 0)
            {
                queue.Dequeue();
            }
            sw.Stop();
            Console.WriteLine("Queue completed!");
            Console.WriteLine($"Milliseconds: {sw.ElapsedMilliseconds}");
            Console.WriteLine($"Ticks: {sw.ElapsedTicks}");

            sw.Reset();
            Console.WriteLine();

            Console.WriteLine("Starting myQueue...");

            sw.Start();
            MyQueue myQueue = new MyQueue();
            for (int i = 0; i < count; i++)
            {
                myQueue.Enqueue(i);
            }
            while (myQueue.Count > 0)
            {
                myQueue.Dequeue();
            }
            sw.Stop();
            Console.WriteLine("MyQueue completed!");
            Console.WriteLine($"Milliseconds: {sw.ElapsedMilliseconds}");
            Console.WriteLine($"Ticks: {sw.ElapsedTicks}");
        }

    }

    //class MyStack
    //{
    //        private object?[] _items = new object?[4];

    //        public int Count { get; private set; }

    //        public void Push(object item)
    //        {
    //            if (_items.Length == Count)
    //            {
    //                Array.Resize(ref _items, _items.Length * 2);
    //            }

    //            Count++;
    //            _items[Count - 1] = item;
    //        }

    //        public object? Pop()
    //        {
    //            object? last = Peek();
    //            _items[Count - 1] = null;
    //            Count--;

    //            return last;
    //        }

    //        public object? Peek()
    //        {
    //            if (Count == 0)
    //            {
    //                throw new InvalidOperationException("Stack is empty");
    //            }
    //            return _items[Count - 1];
    //        }

    //        public void TrimToSize()
    //        {
    //            Array.Resize(ref _items, Count);
    //        }
    //    }

    class MyQueue
    {
        object?[] arr = new object?[4];

        public int Count { get; private set; }

        public void Enqueue(object item)
        {
            if (arr.Length == Count)
            {
                object[] temp = new object[Count * 2];

                for (int i = 0; i < arr.Length; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
            }
            arr[Count++] = item;
        }

        public object Dequeue()
        {
            object firstElement = Peek();
            arr[0] = null;
            Count--;
            return firstElement;
        }
        public object Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentException("Queue is empthy");
            }
            return arr[0];
        }
        //public void Trimtosize()
        //{
        //    object[] temp = new object[Count];
        //    for (int i = 0; i < queue.Length && i < temp.Length; i++)
        //    {
        //        temp[i] = queue[i];
        //    }
        //    queue = temp;
        //}
    }

}


        //public class MyQueue
        //    {
        //        private LinkedList<object> queue;

        //        public MyQueue()
        //        {
        //            queue = new LinkedList<object>();
        //        }

        //        public void Enqueue(object item)
        //        {
        //            queue.AddLast(item);
        //        }

        //        public object Dequeue()
        //        {
        //            if (!IsEmpty())
        //            {
        //                object item = queue.First.Value;
        //                queue.RemoveFirst();
        //                return item;
        //            }
        //            else
        //            {
        //                throw new InvalidOperationException("Dequeue from an empty queue");
        //            }
        //        }

        //        public bool IsEmpty()
        //        {
        //            return queue.Count == 0;
        //        }

        //        public int Size()
        //        {
        //            return queue.Count;
        //        }

        //        public object Peek()
        //        {
        //            if (!IsEmpty())
        //            {
        //                return queue.First.Value;
        //            }
        //            else
        //            {
        //                throw new InvalidOperationException("Peek from an empty queue");
        //            }
        //        }
        //    }
    