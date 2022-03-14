using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("Hello");
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("World");
            Console.ReadLine();
        }
    }
}
