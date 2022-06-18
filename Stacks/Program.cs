using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> fruits = new Stack<string>();
            MaxStack numbers = new MaxStack();


            //fruits.push("Grapes");
            //fruits.push("Apples");
            //fruits.push("Bluberries");
            //fruits.push("PineApple");
            //fruits.push("Bananna");

            numbers.Push(1);
            numbers.Push(7);
            numbers.Push(3);
            numbers.Push(2);
            numbers.Push(12);

            int max = numbers.GetMax();
            Console.WriteLine("Max:" + max);

            int popTop = numbers.Pop();
            int max1 = numbers.GetMax();

            Console.WriteLine("Pop:" + popTop);
            Console.WriteLine("Max:" + max1);

            int popTop1 = numbers.Pop();
            int max2 = numbers.GetMax();
            Console.WriteLine("Pop:" + popTop1);
            Console.WriteLine("Max:" + max2);

            int popTop2 = numbers.Pop();
            int max3 = numbers.GetMax();
            Console.WriteLine("Pop:" + popTop2);
            Console.WriteLine("Max:" + max3);

            int popTop3 = numbers.Pop();
            int max4 = numbers.GetMax();
            Console.WriteLine("Pop:" + popTop3);
            Console.WriteLine("Max:" + max4);

            int popTop4 = numbers.Pop();
            int max5 = numbers.GetMax();
            Console.WriteLine("Pop:" + popTop4);
            Console.WriteLine("Max:" + max5);
        }
    }
}
