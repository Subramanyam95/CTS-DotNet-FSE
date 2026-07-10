using System;

class Employee
{
    public int EmployeeId;
    public string Name;
    public string Position;
    public double Salary;

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"{EmployeeId} {Name} {Position} {Salary}");
    }
}

class EmployeeManagement
{
    Employee[] employees = new Employee[10];
    int count = 0;

    // Add Employee
    public void AddEmployee(Employee emp)
    {
        if (count < employees.Length)
        {
            employees[count] = emp;
            count++;
            Console.WriteLine("Employee Added");
        }
        else
        {
            Console.WriteLine("Array is Full");
        }
    }

    // Search Employee
    public void SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                Console.WriteLine("Employee Found:");
                employees[i].Display();
                return;
            }
        }

        Console.WriteLine("Employee Not Found");
    }

    // Display All Employees
    public void DisplayEmployees()
    {
        Console.WriteLine("\nEmployee List:");

        for (int i = 0; i < count; i++)
        {
            employees[i].Display();
        }
    }

    // Delete Employee
    public void DeleteEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    employees[j] = employees[j + 1];
                }

                employees[count - 1] = null;
                count--;

                Console.WriteLine("Employee Deleted");
                return;
            }
        }

        Console.WriteLine("Employee Not Found");
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagement emp = new EmployeeManagement();

        emp.AddEmployee(new Employee(101, "Rahul", "Manager", 50000));
        emp.AddEmployee(new Employee(102, "Priya", "Developer", 40000));
        emp.AddEmployee(new Employee(103, "Arjun", "Tester", 35000));

        emp.DisplayEmployees();

        Console.WriteLine();
        emp.SearchEmployee(102);

        Console.WriteLine();
        emp.DeleteEmployee(102);

        emp.DisplayEmployees();
    }
}