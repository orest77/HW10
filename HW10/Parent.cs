using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine("Parent has marks {0}", mark);
        }
    }
}
