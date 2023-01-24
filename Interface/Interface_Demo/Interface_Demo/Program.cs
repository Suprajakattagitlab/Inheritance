

using Interface_Demo;
using System;
namespace Interface_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(1001, "Supraja", "supraja67@gmail.com", 123455);
            e1.EmpDetails();
    
            Employee e2 = new Employee(102, "David", "david346@gmail.com", 462788);
            e2.EmpDetails();


            Employee r1 = new Employee(3001, "John", "John4658@gmail.com", 56788);
            r1.EmpDetails();
       
            Employee m = new Employee(201, "Catherine", "cathrine345@gmail.com", 4678);
            m.ReceiveWage(25);
            List<Employee> l= new List<Employee>();
            l.Add(e1);
            l.Add(r1);
            l.Add(m);
            l.Add(e2);
            foreach (Employee e in l)
            {
                e.EmpDetails();
            }
            Console.WriteLine("After Sorting on empID \n*****************\n************");
            l.Sort();
            foreach(Employee e in l)
            {
                e.EmpDetails();
            }
            e1.Rewards();
            Console.WriteLine(m.Compare(e2 ,e1));
          







        }
    }
}
