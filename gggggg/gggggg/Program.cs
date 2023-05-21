using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gggggg
{
    class Program
    {
        static void Main(string[] args)
        {

            CircularQueue Q = new CircularQueue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(-20);
            Q.insert(-40);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Added Items Are : ");
            Q.printQueue();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Q.delete();
            Q.delete();
            Console.ResetColor();

            Q.insert(80);
            Q.insert(-60);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Now Items Are : ");
            Q.printQueue();
            Console.ResetColor();

            Q.QueueAvgMinus();

            Console.ReadKey();
        }
    }
}
