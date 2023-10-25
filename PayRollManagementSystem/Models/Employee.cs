using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject.Models;

public class Employee : BaseEntity
{
    public string EmployeeID { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime PayDate { get; set; }
    public double RegularHours { get; set; }
    public double OvertimeHours { get; set; }


    private double regularRate;
    private double overtimeRate;


    public double RegularRate
    {
        get { return regularRate; }
    }

    public double OvertimeRate
    {
        get { return overtimeRate; }
    }

    public double GrossPay { get; private set; }
    public double NetPay { get; private set; }
    public double MedicareDeduction { get; private set; }
    public double RentDeduction { get; private set; }
    public double FoodDeduction { get; private set; }

    public Employee(double regularRate, double overtimeRate)
    {
        this.regularRate = regularRate;
        this.overtimeRate = overtimeRate;
    }

    public void CalculatePayroll()
    {
        if (IsActive)
        {
            // Gross Pay
            GrossPay = (RegularHours * RegularRate) + (OvertimeHours * OvertimeRate);

            // Deductions
            MedicareDeduction = 0.02 * GrossPay;
            RentDeduction = 0.05 * GrossPay;
            FoodDeduction = 0.03 * GrossPay;

            // Net Pay
            NetPay = GrossPay - (MedicareDeduction + RentDeduction + FoodDeduction);
        }
    }
}
