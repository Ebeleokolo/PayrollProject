
using PayrollProject.Models;

PayrollManager payrollManager = new PayrollManager();

while (true)
{
    Console.WriteLine("Enter employee details (or type 'exit' to finish):");

    Console.Write("Name: ");
    string name = Console.ReadLine();

    if (name.ToLower() == "exit")
        break;
    Employee employee = new Employee(0,0);
    Console.WriteLine($"Your id is {employee.EmployeeID}");

    Console.WriteLine("Employee Id: ");
    string Id = Console.ReadLine();

    Console.Write("Is Active (true/false): ");
    bool isActive = Convert.ToBoolean(Console.ReadLine());

    Console.Write("Start Date (yyyy-mm-dd): ");
    DateTime startDate = DateTime.Parse(Console.ReadLine());

    // Convert EndDate to PayDate
    Console.Write("Pay Date (yyyy-mm-dd): ");
    DateTime payDate = DateTime.Parse(Console.ReadLine());
    DateTime endDate = payDate;

    // Set a definite value for regular hours (e.g., 40 hours)
    double regularHours = 160;

    Console.Write("Overtime Hours: ");
    double overtimeHours = Convert.ToDouble(Console.ReadLine());

    Employee newEmployee = new Employee(100000, 150000)
    {
        Name = name,
        IsActive = isActive,
        StartDate = startDate,
        EndDate = endDate,
        PayDate = payDate,
        RegularHours = regularHours,
        OvertimeHours = overtimeHours
    };

    payrollManager.AddEmployee(newEmployee);
}

payrollManager.PrintEmployeeInfo();
        

