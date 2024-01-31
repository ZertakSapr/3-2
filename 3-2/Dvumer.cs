using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    sealed class Dvumer : Obschiy
    {
        private int[,] array;
        public Dvumer(bool Flag, int Length, int kolstlb) : base(Flag, Length)
        {
            array = new int[base.length1,kolstlb];
            if (base.flag1)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }

        }
        private void UserFill()
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0; j < array.GetLength(1);j++)
                {
                    Console.WriteLine("Введите элемент");
                    array[i,j] = int.Parse(Console.ReadLine());
                }
                
            }
        }


        private void RndFill()
        {
            Random rd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);)
                {
                    array[i,j] = rd.Next(-100, 101);
                }
            }
        }
        public override void Mid()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    sum += array[i,j];
                }
            }
            Console.WriteLine("Среднее значение");
            Console.WriteLine(sum / array.Length);
        }
        public override void Print()
        {
            Console.WriteLine("весь массив");
            for (int i=0; i < array.GetLength(0); i++)
            {
                string final = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    final += array[i, j].ToString()+" ";
                }
                Console.WriteLine(final);
            }

        }
    }
}
