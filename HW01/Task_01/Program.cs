using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main()
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(Func);

            ArrayList list = new ArrayList { "Hello", 123, "World", 11.1, '!' };

            Thread thread = new Thread(threadStart);
            thread.Start(list);
        }

        static void Func(object obj)
        {
            if (obj != null || obj is ArrayList)
            {
                ArrayList list = obj as ArrayList;
                foreach (var s in list)
                {
                    Console.WriteLine(s.ToString());
                }
            }
        }
    }
}
