using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //To create an Interface, we use interface keyword.
    interface ICustomer1
    {
        //Interface methods have only declaration and no implementation
        //Interface members are public by default. We need not to use any explicit access modifier.
        //Interface cannot have fields
        void Print1();
    }
    interface ICustomer2:ICustomer1
    {
        void Print2();
    }


    class Customer:ICustomer2
    {
        //When a class inherits a Interface. Then the class should provide implementation for interface methods.
        public void Print1()
        {

        }

        public void Print2()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Cannot create object for ICustomer1 because the method has no implementation and it is incomplete
            ICustomer1 Cust = new Customer();
            Cust.Print1();
        }
    }
}
