using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public class Class2
    {
// test comment
        private delegate string MyDelegate(int n);
         MyDelegate CallMe;

        public void MyMethod()
        {
            MyDelegate newDelegate = new MyDelegate(ConvertIntToString);
            newDelegate += ConvertIntToStringCustomised;
            //MyOtherMethod(newDelegate);
            CallMe = newDelegate;
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

        //public void MyOtherMethod(MyDelegate passedDelegate)
        //{
        //    passedDelegate(10);
        //}
        public class SomeotherClass {
            public Class2 obj = new Class2();
            public void Process()
            {
                int result = 20;
                obj.CallMe(result);
            }
        }
      public class Next
        {
            SomeotherClass obj1 = new SomeotherClass();
        public void Run()
        {
            obj1.obj.CallMe += M1;
            obj1.Process();
        }
            public string M1(int n)
            {
                return string.Empty;
            }

    }

    }
}
