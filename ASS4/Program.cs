namespace ASS4;

class Program
{
    static void Main(string[] args)
    {
        #region Customer
        List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "Adel", Mobile = "1234567890", Email = "Adel@example.com" },
            new Customer { Name = "AbuSaadya", Mobile = "0987654321", Email = "Abusaadya@example.com" }
        };

        // Print customer details
        Console.WriteLine("Customer Details:");
        CustomerService.PerformActionOnCustomers(customers, CustomerService.PrintCustomerDetails);

        // Send welcome emails
        Console.WriteLine("\nSending Welcome Emails:");
        CustomerService.PerformActionOnCustomers(customers, CustomerService.SendWelcomeEmail);
        #endregion

        #region Employee
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John", YearsOfExperience = 5, Salary = 60000 },
            new Employee { Name = "Jane", YearsOfExperience = 3, Salary = 50000 },
            new Employee { Name = "Alice", YearsOfExperience = 10, Salary = 90000 }
        };

        // Sort employees by salary
        Console.WriteLine("Employees sorted by Salary:");
        EmployeeService.SortEmployees(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));
        employees.ForEach(e => Console.WriteLine($"{e.Name} - Salary: {e.Salary}"));

        // Calculate bonus based on years of experience
        Console.WriteLine("\nBonuses based on experience:");
        EmployeeService.CalculateBonus(employees, e => e.YearsOfExperience * 1000);

        // Calculate bonus based on salary
        Console.WriteLine("\nBonuses based on salary:");
        EmployeeService.CalculateBonus(employees, e => e.Salary * 0.1);
        #endregion
    }
}
