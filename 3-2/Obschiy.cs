using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    abstract class Obschiy
    {
        public int length1 { get; set; }
        public bool flag1 { get; set; }
        protected Obschiy(bool flag, int length)
        {
            length1 = length;
            flag1 = flag;
        }
        public abstract void Mid();
        public abstract void Print();
    }
}
