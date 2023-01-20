using c_sharp__looping;
using System;
using System.Reflection.Metadata.Ecma335;
using static c_sharp_looping.loop;

namespace c_sharp_looping
{
    public class loop
    {
        public static void Main(String[] args)
        {
            Book b = new Book("Think like a monk");
             //b.Name = "Kite Runner";
             Boolean f = true;
             while (f != false)
             {
                 Console.WriteLine("Enter the grades or enter 0 if wants to quite");

                 var input = Console.ReadLine();
                 var pr = int.Parse(input);
                 if (pr == 0)
                 {
                     break;
                 }

                 b.AddBookPrice(pr);
             }
             int re = b.TotalBill();
             Console.WriteLine(re);
             char c = b.Badge(re);
            int ree=b.TotalBill(c,b.bill);
             Console.WriteLine($"The badge with book namen {b.Name} is {c} with bill {ree}");
             b.implementingDelegate();
            //Adding new lines from remote repo
            
            Demo_String.string_demo();
            

        }

           
           



    }
    








}
       
            

  
