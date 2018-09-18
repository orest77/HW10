using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Accounting 
    {
        

        public void ScholarshipPayment(int s)
        {
            if (s < 5)
            {
                Console.WriteLine("The student will not have a scholarship");
            }
            else
            {
                Console.WriteLine("The student will  have a scholarship");
            }
        }
    }
}
