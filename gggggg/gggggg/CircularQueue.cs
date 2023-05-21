using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gggggg
{
    class CircularQueue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;
        private int count;

        public CircularQueue(int size)
        {
            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;
        }

        public void insert(int item)
        {
            if (count == max)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                rear = (rear + 1) % max;
                ele[rear] = item;

                count++;
            }
        }

        public void delete()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Deleted Element Is: " + ele[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public void printQueue()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("Queue Is Empty");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);

                    i = (i + 1) % max;
                    j++;

                }
            }
        }
        public void QueueAvgMinus()
        {
            int k = 0;
            int l = 0;
            int sum = 0;
            int Avg;
            int c = 0;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Minus Items Are : ");
            for (k = front; l < count;)
            {
                if (ele[k] < 0)
                {
                    sum += ele[k];
                    Console.WriteLine(ele[k]);
                    c++;
                }

                k = (k + 1) % max;
                l++;

            }
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Minus Average Is : ");
            Avg = sum / c;
            Console.WriteLine(Avg.ToString());
            Console.ResetColor();
        }
    }
}
