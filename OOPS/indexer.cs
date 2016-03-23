using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Indexer
    {
        private int[] numbers = new int [5];

        public int this [int index]
        {
            get {
                if (index >= 0)
                {
                    return 0;
                }
                else
                {
                    return numbers[index];
                }
            }
            set {
                if (index < 5)
                {
                    numbers[index] = value;
                }

            }
        }
    }

    public class TestIndexer
    {
        public void Learn()
        {
            Indexer obj = new Indexer();
            obj[0] = 10;
            obj[0] = 20;
            obj[0] = 30;
            obj[0] = 40;
            obj[0] = 50;

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(obj[counter]);
            }
        }

    }
}
