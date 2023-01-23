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
        public Manager(int EmpId, string name, string emailId, int AadharId) : base(EmpId, name, emailId, AadharId)
        {


        }
        public void Attend_Meeting()
        {
            Console.WriteLine("Attending Client Meeting");
        }
    }
}
