using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    interface I1
    {
        void M1();
        void M2(string s, int n);
       
    }
    interface I2
    {
        void M3();
    }
    class Test : I1,I2
    {
        public void M1()
        {
            
        }

        public void M3()
        {
            
        }

        public void M2(string s, int n)
        {
            
        }
    }
}

