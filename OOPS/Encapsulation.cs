using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Encapsulation
    {
        //fields
        public string Name="";

        
        private string _Age="";

        public string age
        {
            get
            {  if (Name == "")
                {
                    return "Please provide name";
                }
                else
                {
                    return Name;
                }
            }

            set
            {
                if (Name == "")
                {
                    Name = value;
                }
            
            }

        }

    }
}
