using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{


    sealed class OneDimension : BaseClass
    {
        private static Random rd = new Random();
        private int[] array;

        public OneDimension(bool Flag, int Length) : base(Flag)
        {
            array = new int[Length];

        }

        public override int Mid()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }


        



        public override void Print()
        {
            string final = string.Join(" ", array);
            Console.WriteLine(final);
        }


        protected override void UserFill()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент");
                array[i] = int.Parse(Console.ReadLine());
            }
        }


        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-100, 101);
            }
        }
    }

}
