using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Employee: IEmployee,IComparable,IComparer

    {
        public int EmpId;
        public string name;
        public string emailId;
        public int AadharId;
        public int No_of_Working_days;
        public static double tax_rate = 0.125;

        public Employee(int EmpId, string name, string emailId, int AadharId)
        {
            this.EmpId = EmpId;
            this.name = name;
            this.emailId = emailId;
            this.AadharId = AadharId;

        }
        public void EmpDetails()
        {
            Console.WriteLine($"The {name} with id {EmpId} and with email and Aadhar no is {emailId} ,{AadharId}");
        }
        public virtual double ReceiveWage(int No_of_Working_days)
        {
            return 1000 * No_of_Working_days * tax_rate;
        }
        public void Rewards()

        {
            Console.WriteLine($"You have done a good job {this.name}");
        }
        public int CompareTo(object obj)
        {
            var otherEmp = (Employee)obj;
            return string.Compare(this.name,otherEmp.name);
        }
        public int Compare(object obj1,object obj2)
        {
            Employee e1 = (Employee)obj1;
            Employee e2= (Employee)obj2;
            return string.Compare(e1.emailId,e2.emailId);


        }


    }
}