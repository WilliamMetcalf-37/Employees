using System;
using System.Collections.Generic;

namespace Employees
{


  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      Company Walmart = new Company("Walmart", DateTime.Now);
      // Create three employees
      Employee Kevin = new Employee("Kevin", "Penny", "AssManager");
      Employee Holden = new Employee("Holden", "Parker", "dumbass");
      Employee Audrey = new Employee("Audrey", "Borgra", "Boss - CEO");
      // Assign the employees to the company
      Walmart.AddEmployee(Kevin);
      Walmart.AddEmployee(Holden);
      Walmart.AddEmployee(Audrey);
      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */
      Walmart.PrintEmployees(Walmart);
    }
  }
}