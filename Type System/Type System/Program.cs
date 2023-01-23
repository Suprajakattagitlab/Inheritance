using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

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
            
            
            User us;
            var p=Console.ReadLine();
         
            us.price = int.Parse(p);
            CalculateBill(us.price, u);


    }
        private  static void CalculateBill (int price, UserType u)
        {
            switch(u)
            { 
                case UserType.Platinum:
                     Console.WriteLine(price - (price * 20 / 100));
                    break;
                case UserType.Gold:
                     Console.WriteLine(price - (price * 10 / 100));
                    break;
                case UserType.Silver:
                     Console.WriteLine(price - (price * 5 / 100));
                    break;
                case UserType.Regular:
                     Console.WriteLine(price);
                    break;
                default:
                    Console.WriteLine("Incorrect User Type");
                    break;

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

