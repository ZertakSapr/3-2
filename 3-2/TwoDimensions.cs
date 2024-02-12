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
            base.TypeOfInizialization();

        }

        protected override void UserFill()
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


        protected override void RndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);)
                {
                    array[i,j] = rnd.Next(-100, 101);
                }
            }
        }

        public override int Mid()
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
            return sum / (array.Length);
            
        }

        public void Recreate(int ColumnCount, int RowCount, bool Flag)
        {
            array = new int[RowCount,ColumnCount];
            base.flag = Flag;
            base.TypeOfInizialization();
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
