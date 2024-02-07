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
                if (base.flag1)
                {
                    UserFill();
                }
                else
                {
                    RndFill();
                }
            }

            public override void Mid()
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine("Среднее значение одномерных");
                Console.WriteLine(sum / array.Length);
            }


            public override void Print()
            {
                string final;
                final = string.Join(" ", array);
                Console.WriteLine("весь массив одномерных");
                Console.WriteLine(final);
            }


            private void UserFill()
            {
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Введите элемент");
                    array[i] = int.Parse(Console.ReadLine());
                }
            }


            private void RndFill()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rd.Next(-100, 101);
                }
            }
        }

}
