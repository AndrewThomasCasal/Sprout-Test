using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.Common
{
    public class ContractualEmployee : IEmployee
    {
        decimal dailyRate = (decimal)500.00;

        public decimal CalculatePay(decimal workedDays)
        {
            decimal pay  = dailyRate * workedDays;

            return decimal.Round(pay, 2);
        }
    }
}
