
using System;

class Program : I1, I2
{
    static void Main()
    {
        Program P = new Program();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();
    }
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface method implemented");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface method implemented");
    }
}

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}