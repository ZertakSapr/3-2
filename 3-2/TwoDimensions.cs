using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    sealed class TwoDimensions : BaseClass
    {
        private int[,] array;

        static private Random rnd = new Random();
        public TwoDimensions(bool Flag, int RowCount, int CountColumn) : base(Flag)
        {
            array = new int[RowCount,CountColumn];
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
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);)
                {
                    array[i,j] = rnd.Next(-100, 101);
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
            Console.WriteLine("Среднее значение двумерных");
            Console.WriteLine(sum / (array.GetLength(0)*array.GetLength(1)));
        }

        public override void Print()
        {
            Console.WriteLine("весь массив двумерных");
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
