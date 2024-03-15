using System;

namespace Employee_Wage_Computation
{
    
    class Attendance
    {
        public void isPresent()
        {
            Random random = new Random();
            if (random.Next() % 2 == 0)
            {
                Console.WriteLine("Employee is 'ABSENT' ");
            }
            else
            { 
                Console.WriteLine("Employee is 'PRESENT'");
            }
        }

    }
}
