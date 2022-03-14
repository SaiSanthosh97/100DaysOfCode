using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{

    //This code works when single thread is trying to create instance of a class
    //This is not enough to handle multiple thread

    //Making this as sealed so it cannot be inherited
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        //As the class is sealed we need to provide an alternate way to give back the singleton object creation
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        //Using private constructor to avoid multiple instance creation of a class
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
