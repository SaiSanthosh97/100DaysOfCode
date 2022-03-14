using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintS1(),
                () => PrintS2());
            Console.ReadLine();
        }

        private static void PrintS2()
        {
            Singleton s2 = Singleton.GetInstance;
            s2.PrintDetails("from s2");
        }

        private static void PrintS1()
        {
            Singleton s1 = Singleton.GetInstance;
            s1.PrintDetails("from s1");
        }
    }
}
