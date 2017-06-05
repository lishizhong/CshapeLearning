using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRvia12
{
    public static class Program
    {
        public static void Main()
        {
            Console.Beep();
            //Console.Beep(3000, 2000);
            foreach (var s in Enum.GetValues(typeof(Data)))
            {
                int x = (int)s;
                Console.Beep(x, 100);
            }
            ValueTypePerfTest();
            //ReferenceTypePerfTest();
        }

        private static void ReferenceTypePerfTest()
        {
            const Int32 count = 100000000;
            using (new OperationTimer("List<Int32>"))
            {
                List<Int32> l = new List<int>();
                for (Int32 n = 0; n < count; n++)
                {
                    l.Add(n);
                    Int32 x = l[n];
                }
                Console.Beep();
                l = null;
            }

            using (new OperationTimer("ArrayList of Int32"))
            {
                ArrayList a = new ArrayList();
                for (Int32 n = 0; n < count; n++)
                {
                    a.Add(n);
                    Int32 x = (Int32)a[n];
                }
                Console.Beep();
                a = null;
            }
        }

        private static void ValueTypePerfTest()
        {
            const Int32 count = 100000000;

            using (new OperationTimer("List<String>"))
            {
                List<string> l = new List<string>(count);
                for (Int32 n = 0; n < count; n++)
                {
                    l.Add("X");
                    String x = l[n];
                }
                Console.Beep();
                l = null;
            }
            Console.Beep();
            using (new OperationTimer("ArrayList of String"))
            {
                ArrayList a = new ArrayList(count);
                for (Int32 n = 0; n < count; n++)
                {
                    a.Add("X");
                    String x = (String)(a[n]);
                }
                a = null;
                Console.Beep();
            }
        }
    }

    enum Data
    {
        C = 256, D = 288, E = 320, F = 341, G = 384, A = 426, B = 480, Bm = 453
    }
}
