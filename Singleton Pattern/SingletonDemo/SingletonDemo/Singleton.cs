using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{

    //Sealed restricts the inheritance
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
        // Public property is used to return only one instance of the class
        // leveraging on the private property
        public static Singleton GetInstance
        {
            get
            { 
                return instance.Value;
            }
        }
        //Private constructor ensures that object is not instantiated other than within the class itself
        private Singleton()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
