using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.HR
{
    class Manager:Employee
       
    {
        static int shift_allowance = 3000;
        public Manager(int EmpId, string name, string emailId, int AadharId) : base(EmpId, name, emailId, AadharId)
        {


        }
        public void Attend_Meeting()
        {
            Console.WriteLine("Attending Client Meeting");
        }
        public override double ReceiveWage(int No_of_Working_days)
        {
            return 1000 * No_of_Working_days * tax_rate+shift_allowance;
        }
    }
}
