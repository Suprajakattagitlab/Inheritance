using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp__looping
{
    class Demo_String
    {
        public static void string_demo()
        {
            var s = "Supraja";
            var s2 = "Supraja";
            bool b = s == s2;
            var a = "9";
            int s3 = int.Parse(a);
            Console.WriteLine(s3);
            var sub = s.Substring(1, 2);
           // Console.WriteLine($"{ s.ToLower()} { s.Length} {sub}");
            StringBuilder s1 = new StringBuilder();
            s1.Append(sub);

           Console.WriteLine("Additing new line");


            
           

        }
        


    }
}
