using System;
public abstract class Customer
{
    int ID;
    public void Print()
    {
        Console.WriteLine("Print");
    }
}
public interface ICustomer
{
    void Print();
}
public class Program
{
    public static void Main()
    {
    }
}
