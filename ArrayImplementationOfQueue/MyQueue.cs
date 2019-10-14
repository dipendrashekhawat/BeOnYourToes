using System;

namespace ArrayImplementationOfQueue
{
    class MyQueue
    {
        private static int []arr = new int [5] {1, 2, 3, 4, 5}; // fixed sized integer array
        private static int front = 0, rear = 0;

        public void Enqueue(int num)
        {
            // if array is already full
            if(rear == arr.Length)
            {
                Console.WriteLine("\nQueue is full while inserting elemenet:  {0}", num);
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
                for(int i = 0; i< rear-1; i++)
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

        public void Display(int size)
        {   
            // if array is empty
            if (front == rear)
            {
                Console.WriteLine("No elements");
                return;
            }

            for(int i = front; i< rear; i++)  
            {  
                Console.Write("{0}  ", arr[i]);  
            }
        }

        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            Console.Write("\nElements in queue are: ");
            queue.Display(5);
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.Write("\nElements in queue after Enqueing: ");
            queue.Display(5);

            queue.Enqueue(6); // will get an error here as the array will be full and eement '6' will not be inserted
            
            queue.Dequeue(); // 1 will be removed
            queue.Dequeue(); // 2 will be removed

            Console.Write("\nElements in queue after Dequeing: ");
            queue.Display(5);

            // 6 & 7 will be inserted as we have removed 2 elements from the array
            queue.Enqueue(6); 
            queue.Enqueue(7);

            Console.Write("\nElements in queue after Enqueing again: ");
            queue.Display(5);

        }
    }
}
