using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public class MyClass1
    {
        public delegate string MyDelegate(int n);

        public void MyMethod()
        {
            MyDelegate newDelegate = new MyDelegate(ConvertIntToString);
            newDelegate += ConvertIntToStringCustomised;
            MyOtherMethod(newDelegate);
        }
        public string ConvertIntToString(int number)
        {
            Console.WriteLine("" + number.ToString());
            return number.ToString();
        }
        public string ConvertIntToStringCustomised(int number)
        {
            Console.WriteLine("" + number.ToString() + "");
            return number.ToString(); 
        }

        public void MyOtherMethod(MyDelegate passedDelegate)
        {
            passedDelegate(10);
        }
            
            }
}
