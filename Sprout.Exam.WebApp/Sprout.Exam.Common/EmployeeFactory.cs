using Sprout.Exam.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.Common
{
    public class EmployeeFactory
    {
        public IEmployee GetEmployeeType(int employeeTypeId)
        {
            IEmployee employee = null;

            if (employeeTypeId == (int)EmployeeType.Regular)
            {
                employee = new RegularEmployee();
            }
            else
            {
                employee = new ContractualEmployee();
            }

            return employee;
        }
    }
}
