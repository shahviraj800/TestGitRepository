using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Inheritance
            //ChildClass childobj = new ChildClass();
            //childobj.test();

            //ParentClass handle = new ChildClass();
            //handle.test();

            //GrandChildClass grandchild = new GrandChildClass();
            //grandchild.test();

            ////Encapsulation
            //Test obj = new Test();
            //obj.M1();
            //Encapsulation ec = new Encapsulation();
            //ec.Name = "Nirav Patel (SOPHOS)";

            //string s = ec.Name;
            //Console.WriteLine(s);
            //Console.ReadKey();
            ////Constructor
            ////Constuctor obj1 = new Constuctor("Nirav",23);
            //Constuctor obj = new Constuctor();
            //obj.Name = "SOPHOS";
            //obj.age=1999;
            //Console.WriteLine(obj.Name +" " +obj.age);
            //Console.ReadKey();


            ////Static
            //Data d1 = new Data();
            //d1.Name = "D1";

            //Data d2 = new Data();
            //d1.Name = "D2";

            //Helper.Dosomework(d1);
            //Helper.Dosomework(d2);

            //Console.WriteLine(d1.Name);
            //Console.WriteLine(d2.Name);
            //Console.ReadLine();

            //Car2 c1;                     //Struct file 
            //c1.Model = "Honda";
            //c1.Make = "2015";

            //Console.Write("Model: ");
            //Console.WriteLine("Model = {0}, Make = {1}", c1.Model, c1.Make);

            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            string a = new string(new char[] {'h','e','l','l','o' });
            string b = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
            Console.ReadKey();



        }

    }
}
