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
            
        int bill = 0;
        public  void AddBookPrice(int p)
        {
            price.Add(p);
            
        }
        public int TotalBill()
        {
            foreach (int p in price) 
            {
                bill = p + bill;
            }
            return bill;  
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
                        Console.WriteLine("Normal user");
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
           //Console.WriteLine(res);


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
