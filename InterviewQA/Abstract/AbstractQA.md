Q: Why do we need Abstract class
A: Consider there is an organisation which has 2 types of employees
  1. [FullTimeEmployee](https://github.com/SaiSanthosh97/MyStack/blob/develop/InterviewQA/Abstract/FullTimeEmployee.cs)
  2. [ContractEmployee](https://github.com/SaiSanthosh97/MyStack/blob/develop/InterviewQA/Abstract/ContractEmployee.cs)
  
  FullTimeEmployee and ContractEmployee classes are stand-alone classes.
  Regardless of the employee type, all employees in the organisation are going to have ID, FirstName and LastName properties. 
  We also compute the FullName of any employee by concatenating their FirstName and LastName. 
  This means that, the above two classes (FullTimeEmployee & ContractEmployee) are related and there is, a lot of common functionality duplicated in them. 
  The problem with this design is that, tomorrow, if want to introduce MiddleName property and if we have to include it in the computation of FullName, then we have to make the same change in both the classes. So code maintainability is going to be a big issue with this design.
  So to avoid this issue, we can move the common functionality into base class. Using a common base class, we are going to get rid of the duplicated code. 
  
  
The obvious next question is, How should we design the base class?
1. Should we design it as an abstract class 
OR
2. Should we design it as a Concrete (Non abstract) class 

If we go with Concrete class. Then we shall create a BaseEmployee class and move all the common properties and inherit in FullTimeEmployee and ContractEmployee

So, with the above design we got rid of duplicated code, but we introduced another problem. Since "BaseEmployee " is a concrete (Non abstract) class, there is nothing stopping us from creating an instance of BaseEmployee class and using it.

The above design is bad for 2 reasons
1. We only have 2 types of employees in our organisation - ContractEmployee  & FullTimeEmployee. The developers should only able to instantiate ContractEmployee  & FullTimeEmployee classes and not BaseEmployee class.
2. We get a run time error, if we invoke GetMonthlySalary() method on BaseEmployee class.

To get rid of the second issue, we can make the following modifications
1. Remove GetMonthlySalary() virtual method from BaseEmployee class
2. Remove "override" keyword from GetMonthlySalary() method in ContractEmployee and FullTimeEmployee classes.

With the above changes, we won't get the runtime error, but we would still be able to instantiate BaseEmployee class. So to prevent BaseEmployee class from being instantiated, let's mark it as an abstract class.

One more change is to introduce GetMonthlySalary() as an abstract method in BaseEmployee class. This will ensure that, all the classes that derive from BaseEmployee class, 
1. Will either provide implementation for GetMonthlySalary() method 
OR
2. The derived class will also be marked as an abstract class


So, in short, we would create an abstract class, when want to move the common functionality of 2 or more related classes into a base class and when, we don't want that base class to be instantiated.
