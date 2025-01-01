using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class TypeA
    {
        public TypeA()
        {
            TypeB typeB = new TypeB();

        }
        private int x;
        internal int y;
        public int z;

        void print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
