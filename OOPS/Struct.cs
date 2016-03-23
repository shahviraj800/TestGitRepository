using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    struct Car2
    {   //properties
        public string Model;
        public string Make;

        //methods
        public string GetDetails()//this is struct method
        {
            return Model + " " + Make;
        }

        public Car2(string model, string make)  //parameter const.
        {
            Model = model;
            Make = make;
        }
    }
}
