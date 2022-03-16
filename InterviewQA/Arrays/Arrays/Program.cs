using System;
using System.Collections;

namespace InterviewQA
{
    /// <summary>
    /// Demonstrating that if an array can store different data types
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Array is a collection of same data types. Below example illustrates that the variable intArray stores only int type
            Console.WriteLine("Demo using Array");
            int[] intArray = new int[2];
            intArray[0] = 1;
            //intArray[1] = "Santhosh";  Throws a compile time error
            intArray[1] = 2;
            foreach (int a in intArray)
            {
                Console.WriteLine(a);
            }
            #endregion
            #region If at all we want to store different data types in Array then we can use object data type or ArrayList
            Console.WriteLine("Demo using Objects");
            object[] objArray = new object[2];
            objArray[0] = 1;
            objArray[1] = "One";
            foreach (object b in objArray)
            {
                Console.WriteLine(b);
            }
            #endregion

            #region ArrayList can also store different datatypes in an Array
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add("Zero");
            foreach (var al in arrayList)
            {
                Console.WriteLine(al);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
