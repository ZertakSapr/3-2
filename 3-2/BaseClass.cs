using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    abstract class BaseClass
    {

        protected BaseClass(bool flag)
        {
            if (flag)
            {
                UserFill();

            }
            else
            {
                RndFill();
            }
        }
        public abstract int Mid();
        public abstract void Print();

        protected abstract void UserFill();
        protected abstract void RndFill();
    }
}
