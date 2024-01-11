using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class EligibleStudent
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Marks in Maths");
            int maths =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks in Phys");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks in Chem");
            int chem = Convert.ToInt32(Console.ReadLine());

            if(maths >=65 && phy>=55 && chem>=50 && ((maths+phy+chem)>=180) || ((maths+phy)>=140))
            {
                Console.WriteLine("Candidate Eligible for admission");
            }
            else
            {
                Console.WriteLine("Candidate Not Eligible");
            }
        }
    }
}
