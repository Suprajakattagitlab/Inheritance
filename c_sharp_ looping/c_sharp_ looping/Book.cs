using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp__looping
{
   
    public class Nameobject
    {

    }

    class Book
    {
        public int bill = 0;
        public Book(string name)
        {
            Name = name;
         
        }
        List<int> price = new List<int>();
        public string Name
        {
            get;
             set;
        }
            
        
        public  void AddBookPrice(int p)
        {
            price.Add(p);
            
        }

        public int TotalBill()
        {
            //int bill = 0;
            foreach (int p in price) 
            {
                this.bill = p + this.bill;
            }
            return this.bill;  
        }
        public int TotalBill(char Badge,int bill)
        {
            
           
            switch (Badge)
            {
                case 'A':
                    //Console.WriteLine($"you are getting 50% discount{bill}");
                    return bill-((bill*50)/100);

                 case 'B':
                    return bill-((bill * 20)/ 100);

                  case 'C':
                    return bill-((bill * 10) / 100);
                default:
                    return bill;
            }
            
        }
        public char Badge(int bill)
        {
            switch (bill)
            {
                case var l when l > 500:
                    return 'A';

                case var l when l > 200:
                    return 'B';

                case var l when l > 100:
                    return 'C';
                default:
                    return 'D';
            }
        }
            public void Badge(char A)
            {
                switch (A)
                {
                    case'A':
                        Console.WriteLine("platinum user");
                        break;
                    case 'B':
                        Console.WriteLine("Golden user");
                        break;
                    case 'C':
                        Console.WriteLine("Silver user");
                        break;
                    default:
                        Console.WriteLine("Regular user");
                        break;
                }

            }
       public delegate void demodelegate(int message);

        public void implementingDelegate()
        {
            demodelegate log= Windowlogin;
            //log = Windowlogin;
            log+= Linuxlogin;

           log(100);
           Console.WriteLine(log);
          //additting new line in remote

        }
        public void Windowlogin(int s)
        {
            Console.WriteLine(s);
        }
        public void Linuxlogin(int s)
        {
            Console.WriteLine(s+10);
        }

    }
}
