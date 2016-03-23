using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class ParentClass
    {
        public virtual void test()
        {
        }
    }
    public class ChildClass : ParentClass
    {
        public override void test()
        {

        }
    }
    public class GrandChildClass : ChildClass
    {
        public override void test()
        {
            
        }     

    }
}
