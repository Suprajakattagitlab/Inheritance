using Array_Collections;
namespace Array_Collections
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Train_Schedule t1 = new Train_Schedule(23, "Solapur", "Pune");
            Train_Schedule t2 = new Train_Schedule(24, "Pune", "Solapur");
            Train_Schedule [] t=new Train_Schedule[2];
            t[0] = t1;
            t[1] = t1;

            int[] a = new int[3];
            foreach(Train_Schedule train in t)
            {
                Console.WriteLine(train.to);
            }


        }
    }
}