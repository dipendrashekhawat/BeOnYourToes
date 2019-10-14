using System;

namespace ArrayImplementationOfQueue
{
    class MyQueue
    {
        private int []arr = new int [10]; // fixed sized integer array
        private int front = 0, rear = 0;

        public void Enqueue(int num)
        {
            // if array is already full
            if(rear == arr.Length)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                arr[rear] = num;
                rear++;
            }
            return;
        }

        public void Dequeue()
        {
            // if array is empty
            if (front == rear)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                for(int i = 0; i<rear-1; i++)
                {
                    arr[i] = arr[i+1];
                }

                if (rear < arr.Length)
                {
                    arr[rear] = 0;
                }

                rear--;
            }
            return;
        }

        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();

        }
    }
}
