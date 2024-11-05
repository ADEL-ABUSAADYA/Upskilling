namespace ASS4;

public class EmployeeService
{
    public static void SortEmployees(List<Employee> employees, Func<Employee, Employee, int> comparison)
    {
        employees.Sort((e1, e2) => comparison(e1, e2));
    }

    public static void CalculateBonus(List<Employee> employees, Func<Employee, double> bonusCalculator)
    {
        foreach (var employee in employees)
        {
            double bonus = bonusCalculator(employee);
            Console.WriteLine($"Bonus for {employee.Name}: {bonus:C}");
        }
    }
}
