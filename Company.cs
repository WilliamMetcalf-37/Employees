
using System;
using System.Collections.Generic;

namespace Employees
{
  public class Company
  {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn
    {
      get;
    }

    // Create a public property for holding a list of current employees
    public List<Employee> ThemEmployees { get; private set; } = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
      ThemEmployees.Add(employee);
    }
    public void PrintEmployees(Company business)
    {
      foreach (Employee employee in business.ThemEmployees)
      {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Title}");
      }
    }

    public Company(string name, DateTime createdOn)
    {
      Name = name;
      CreatedOn = createdOn;
    }
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
  }
}

