using System;

namespace EmployeeApp
{

    class Employee {
        private string empName;

        public string GetName() => empName;

        public void SetName(string newName) => Name = newName;

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }
        private int empAge;

        public int Age
        {
            get => empAge;
            set => empAge = value;
        }

        public double Pay {get; set; }

    private string _empssn;
        public string SSN 
        {
            get => _empssn;
            private set => _empssn = value;
            }

        public Employee() { }
        public Employee(string name, int age, double pay, string ssn)
        {
            empName = name;
            empAge = age;
            Pay = pay;
            SSN = ssn;
        }

        public void ShowData()
        {
            Console.WriteLine("Employee Name: {0}", empName);
            Console.WriteLine("Employee Age: {0}", empAge);
            Console.WriteLine("Employee Pay: {0}", Pay);
        }
    }
}