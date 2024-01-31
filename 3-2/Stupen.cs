using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    sealed class Stupen : Obschiy
    {
        public Stupen(bool Flag, int Length) : base(Flag, Length)
        {
            array = new int[base.length1][];
            if (base.flag1)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }

        }
        private int[][] array;
        private void UserFill()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кол во элементов в строке ступенчатых");
                int kol = int.Parse(Console.ReadLine());
                array[i] = new int[kol];
                for (int j = 0; j < kol; j++)
                {
                    Console.WriteLine("Введите элемент");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }   
        }


        private void RndFill()
        {
            Random rd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кол во элементов в строке ступенчатых");
                int kol = int.Parse(Console.ReadLine());
                array[i] = new int[kol];
                for (int j = 0; j < kol; j++)
                {
                    array[i][j] = rd.Next(-100, 101);
                }
            }
        }
        public override void Mid()
        {
            int sum = 0;
            int kol=0;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j=0; j<array[i].Length; j++)
                {
                    sum += array[i][j];
                    kol += 1;
                }
                
            }
            Console.WriteLine("Среднее значение");
            Console.WriteLine(sum / kol);
        }


        public override void Print()
        {
            Console.WriteLine("весь массив");
            for (int i=0; i < array.Length; i++)
            {
                string final = "";
                final = string.Join(" ", array[i]);
                Console.WriteLine(final);
            }
            
            
            
        }
    }
}
