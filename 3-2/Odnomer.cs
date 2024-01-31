using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    
    
        sealed class Odnomer : Obschiy
        {
            
            
            
            public Odnomer(bool Flag, int Length) : base(Flag, Length)
            {
                array = new int[base.length1];
                if (base.flag1)
                {
                    UserFill();
                }
                else
                {
                    RndFill();
                }
                
            }
            private int[] array;


            public override void Mid()
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine("Среднее значение");
                Console.WriteLine(sum / array.Length);
            }


            public override void Print()
            {
                string final;
                final = string.Join(" ", array);
                Console.WriteLine("весь массив");
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
                Random rd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rd.Next(-100, 101);
                }
            }
        }

}
