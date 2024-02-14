﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    abstract class BaseClass
    {
        public bool flag { get; set; }

        protected BaseClass()
        {
            flag = false;
        }
        public abstract int Mid();
        public abstract void Print();

        protected abstract void UserFill();
        protected abstract void RndFill();


        protected void TypeOfInizialization()
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
    }
}
