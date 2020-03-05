using System;
namespace Employees
{
  public class Employee
  {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }

    public DateTime StartDate
    {
      get
      {
        return DateTime.Now;
      }
    }
    public Employee(string firstName, string lastName, string title)
    {
      FirstName = firstName;
      LastName = lastName;
      Title = title;
    }
  }
}
