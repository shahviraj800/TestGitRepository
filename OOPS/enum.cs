using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public enum ABC
    {
        Java,
        C,
        NET
    }

    public class Technologies
    {
        public string Name;
        public ABC Language;

    }

    public class Test4
    {
        public void run()
        {
            Technologies tech = new Technologies();
            tech.Name="Nirav";
          //  tech.Language1=Type.Java";
            tech.Language=ABC.NET;


        }
    
    }
}
