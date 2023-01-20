using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace cs_fund
{
    class Program
    {
        static void Main(String[] args)
        {
            var student = new Stu("Supraja");
            //student.addd(100);
            //  student.showper();
            // List<double> l = new List<double>();
            student.AddScroe(95.55);
            student.AddScroe(94.55);
            student.AddScroe(77.55);
            student.AddScroe(66.55);
            student.AddScroe(100.55);
            student.per();

        }

    }
}
