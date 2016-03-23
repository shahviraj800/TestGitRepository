using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public abstract class Automobiles
    {
        public abstract void run();

        public string Getstatus()
        {
            return "running";
        }
    }
    public class Car : Automobiles
    {
        public override void run()
        {
            
        }

    }
    public class Truck : Automobiles
    {
        public override void run()
        {

        }

    }


}
