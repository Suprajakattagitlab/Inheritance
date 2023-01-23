using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        public int  EmpId;
       public  string name;
        public string emailId;
        public int AadharId;
        public int No_of_Working_days;
        public  static double tax_rate = 0.125;

        public Employee(int EmpId, string name,string emailId,int AadharId)
        {
            this.EmpId = EmpId;
            this.name = name;
            this.emailId = emailId;
            this.AadharId = AadharId;

        }
        public void EmpDetails()
        {
            Console.WriteLine($"The {name} with id {EmpId} and with email and Aadhar no is {emailId} ,{ AadharId}");
        }
        public virtual double ReceiveWage(int No_of_Working_days)
        {
            return 1000*No_of_Working_days*tax_rate;
        }
        


    }
}
