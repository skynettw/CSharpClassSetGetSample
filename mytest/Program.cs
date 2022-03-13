using System;

namespace mytest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] d = {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 9}
            };
            Console.WriteLine(d.Length);
            Person richard = new Person("Richard", 1.74, 70.0, 20);
            Person tom = new Person("Tom", 1.74, 70.0, 20);
            richard.Age = 50;
            Console.WriteLine(richard.Age);
            Console.WriteLine(Person.count);
        }
    }
}
