using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class FullTimeEmployee
    {
        public int AnnualSalary { get; set; }

        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
