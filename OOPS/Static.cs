using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public static class Helper
    {
        public static void Dosomework(Data d)
        {
            d.Name = d.Name + "_Updated";
        }
    }
    public class Data
    {
        public string Name = string.Empty;
    }
}
