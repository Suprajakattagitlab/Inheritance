
using Inheritance;
using InheritanceDemo.HR;
using InheritanceDemo.SoftwareEmpl;
using System;
namespace InheritanceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Supraja", "supraja67@gmail.com", 123455);
            e1.EmpDetails();
           Console.WriteLine($"Emplyee wage with name {e1.name} is {e1.ReceiveWage(25)}");
            Lead e2 = new Lead(102, "David", "david346@gmail.com", 462788);
            e2.EmpDetails();
            Console.WriteLine($"Emplyee wage with name {e2.name} is {e2.ReceiveWage(25)}");
            e2.Providing_Training();
            
            ResignedEmployee r1 = new ResignedEmployee(301,"John","John4658@gmail.com",56788);
            r1.EmpDetails();
            Console.WriteLine(r1.full_and_final_Amout(r1.ReceiveWage(4), 13));
            Manager m = new Manager(201,"Catherine","cathrine345@gmail.com",4678);
            m.ReceiveWage(25);
            Console.WriteLine($"Emplyee wage with name {m.name} is {m.ReceiveWage(25)}");
            ;            
            

        }
    }
}

