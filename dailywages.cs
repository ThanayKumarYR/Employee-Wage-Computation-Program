using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class dailywages
    {
        public static void dailywage()
        {
            int wage_per_hour = Convert.ToInt32(Console.ReadLine());
            int per_day_work = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"the wage per day is {wage_per_hour * per_day_work}");

        }
    }
}
