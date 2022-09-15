using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsPrimeNumbers
{
    public class MyTask
    {
        static public int start;
        static public int end;
        public Task task;
        static public Action Mystart = new Action(Generete);
        public static List<int> vs;
        static public void Generete()
        {
            vs.Clear();
            for (int i = start; i <= end; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 & i % 1 == 0)
                    {
                        b = false;
                    }
                }
                if (b) vs.Add(i);
            }

        }
        public MyTask()
        {
            vs = new List<int>();
        }
    }
}
