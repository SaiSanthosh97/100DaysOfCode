using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class ContractEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        public int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHoursWorked;
        }
    }
}
