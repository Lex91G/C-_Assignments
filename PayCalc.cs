using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PayCalc
    {
        // member variables
        public double hoursWorked;
        public double payRate;
        public double totalPay;

        // constructor
        public PayCalc()
        {

        }

        // member methods
        public double GetHours()
        {
            Console.WriteLine("How many hours have you  worked?");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            return hoursWorked;
        }
        public double GetPayRate()
        {
            Console.WriteLine("How much do you get paid hourly?");
            payRate = Convert.ToDouble(Console.ReadLine());
            return payRate;
        }
        public double GetTotalPay()
        {
            totalPay = hoursWorked * payRate;
            return totalPay;
        }
            
    }
}
