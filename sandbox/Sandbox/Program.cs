using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        Hero bruce = new Hero("Bruce", "Bard", 50);
        Hero tom = new Hero("Tom", "Fighter", 80);
        tom.DisplayHero();
        bruce.DisplayHero();
        
        
        //From the Employee and HourlyEmployee classes:
        // Create a list of Employees
        List<Employee> employees = new List<Employee>();

        // Create different kinds of employees and add them to the same list
        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());

        // Get a custom calculation for each one
        foreach(Employee employee in employees)
        {
        float pay = employee.CalculatePay();
        Console.WriteLine($"${pay}");
        }   
        }

}