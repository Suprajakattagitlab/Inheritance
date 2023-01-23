using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.SoftwareEmpl
{
    class Lead:Employee
    {
        public Lead(int EmpId, string name, string emailId, int AadharId) : base(EmpId, name, emailId, AadharId)
        {

        }
        
        public void Providing_Training()
        {
            Console.WriteLine($"{name} Providing Training");
        }
    }

}
