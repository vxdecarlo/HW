using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyMath
{
    class Math
    {
        public int DoSomething(int a, int b) {
            return a/b;
        }
        public int DoSomething(int a, int b, int c)
        {
            return a+b+c;
        }
        public int DoSomething(int a, int b, int c, int d)
        {
            return a*b*c*d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
        }
    }
}
