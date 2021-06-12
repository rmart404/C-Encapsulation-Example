using System;
using EmployeeApp;

Employee emp = new Employee("Ray", 35, 10_000, "555-55-5555");

emp.ShowData();

Console.WriteLine(emp.GetName());

emp.SetName("Raymundo Martinez");

Console.WriteLine(emp.GetName());

emp.Name = "Ray is a really weird guy who does not know how to code";
Console.WriteLine(emp.GetName());
Console.WriteLine(emp.Name);

emp.Age = 35;
emp.ShowData();
Console.WriteLine(emp.Pay);

Console.WriteLine(emp.SSN);
