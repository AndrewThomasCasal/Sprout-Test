using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.Common
{
    public class RegularEmployee : IEmployee
    {
        decimal totalDays = 22,
            basicSalary = 20000;

        decimal taxRate = (decimal)0.12;

        public decimal CalculatePay(decimal absentDays)
        {
            decimal deduction = (basicSalary / totalDays) * absentDays;
            decimal tax = basicSalary * taxRate;
            decimal pay = (basicSalary - deduction - tax);

            return decimal.Round(pay, 2);
        }
    }
}
