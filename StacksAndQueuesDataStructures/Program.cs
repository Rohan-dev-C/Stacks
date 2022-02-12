using System;

namespace StacksAndQueuesDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stak = new ArrayStack<int>();

            stak.Push(5);
            Console.WriteLine(stak.Pop().ToString());
            stak.Push(1);
            stak.Push(2);
            stak.Push(3);
            stak.Push(4);
            stak.Push(9); 
     
            Console.WriteLine(stak.Pop().ToString());

            stak.Push(5);
            stak.Push(6);
            stak.Push(7);
            stak.Push(8);
            stak.Pop();
            Console.WriteLine(stak.Peek().ToString()); 


            
        }
    }
}
