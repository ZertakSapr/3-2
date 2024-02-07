using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    abstract class BaseClass
    {
        public bool flag1 { get; set; }
        protected BaseClass(bool flag)
        {
            flag1 = flag;
        }
        public abstract void Mid();
        public abstract void Print();
    }
}
