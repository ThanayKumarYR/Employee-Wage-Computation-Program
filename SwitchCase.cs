using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class SwitchCase
    {
        public static void CallUseCase()
        {
            Console.Write("enter the number of day worked \nenter the pay ");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int usecase = Convert.ToInt32(Console.ReadLine());
            switch (usecase)
            {
                case 1:
                    Attendance attendance = new Attendance();
                    attendance.isPresent();
                    break;
                case 2:
                    dailywages.dailywage();
                    break;
                case 3: 
                    partTimeWages partTimeWages = new partTimeWages();
                    partTimeWages.ptWages();
                    break;
                case 4:

                    mountlyWage m = new mountlyWage(n, p);
                    break;
                case 5:
                    coinditionalWage c = new coinditionalWage(p, n);
                    break;
                default:
                    Console.WriteLine("pls select the correct one ");
                    break;
            }
        }

    }
}
