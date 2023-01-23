using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Type_System
{
    class Program
    {
      
       public  static void Main(String[] args)
        {
            UsingEnumeration();
           
        }
        public static void UsingEnumeration()
        {
            UserType userType = UserType.Platinum;
            UserType u2 = UserType.Gold;
            Console.WriteLine("Enter user type: Platinum, Gold, Silver, Regular");
            
            var u = Enum.Parse<UserType>(Console.ReadLine());
            Console.WriteLine("Enter the user name");





            User us;
            us.name = Console.ReadLine();
            Console.WriteLine("Enter the price of the book");

            var p=Console.ReadLine();
         
            us.price = int.Parse(p);
            int bill =CalculateBill(us.price, u);
            Console.WriteLine($"With username {us.name} the bill is {bill}");   



    }
        private  static int CalculateBill (int price, UserType u)
        {
            switch(u)
            { 
                case UserType.Platinum:
                     return price - (price * 20 / 100);
                   
                case UserType.Gold:
                     return price - (price * 10 / 100);
                    
                case UserType.Silver:
                     return price - (price * 5 / 100);
                   
                case UserType.Regular:
                     return price;
                   
                default:
                    return 0;
                

            }
            
        }
          enum UserType
        {
            Regular,
            Silver,
            Gold,
            Platinum


        }
        struct  User
        {
             public string name;
            public int id;
            public int price;
        }


        
    }
}

