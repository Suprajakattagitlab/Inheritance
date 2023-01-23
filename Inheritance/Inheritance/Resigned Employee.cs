using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ResignedEmployee:Employee
    {
        public ResignedEmployee(int EmpId, string name, string emailId, int AadharId) : base(EmpId, name, emailId, AadharId)
        {


        }
        public double full_and_final_Amout(double wage, int no_leave)
        {
            return wage * (no_leave * 1200);


        }
    }
}
