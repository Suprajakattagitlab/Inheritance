using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace cs_fund
{
   public class Stu
    {

        List<double> score = new List<double>();
        public string s;
        double re = 0; 
        public Stu(string s)
        {
            this.s = s;
            Console.WriteLine($"This is{s} scoreCard");

        }



        public void AddScroe(double scc)
        {
            if(score>100 && score<200)
            {
                return false;
            }
            score.Add(scc);

        }
        public double per()
        {

            foreach (double i in score)
            {
                re = re + i;
            }
            Console.WriteLine(re);
            Console.WriteLine($"the per is {(re) * 50 / 100} ");
            return re;
        }

    }

}
