using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class mountlyWage
    {
        private int numberOfDay;
        private int payPerday;
        public mountlyWage(int numberOfDay, int payPerDay)
        {
            this.numberOfDay = numberOfDay;
            this.payPerday = payPerDay;
        }
        public void calculateMountlyWage()
        {
            Console.WriteLine($"the mountly wage is {numberOfDay * payPerday}");
        }
    }
}
