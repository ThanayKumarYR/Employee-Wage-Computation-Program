﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    class conditionalWage
    {
        private int limit = 12;
        private int pay;
        private int noOfDayWork;
        public conditionalWage(int pay, int noOfDayWork)
        {

            this.pay = pay;
            this.noOfDayWork = noOfDayWork;
        }

        public void decide_pay()
        {
            if (limit > noOfDayWork)
            {
                Console.WriteLine("pls work for some more day");
            }
            else
            {
                Console.WriteLine($"amount of salary {(noOfDayWork - limit) * pay}");
            }
        }
    }
}
