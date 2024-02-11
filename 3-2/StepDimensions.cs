using System;
using System.Collections.Generic;
using System.Text;

namespace _3_2
{
    sealed class StepDimensions : BaseClass
    {

        OneDimension[] array;
        public StepDimensions(bool Flag, int Length) : base(Flag)
        {
            array = new OneDimension[Length];
            

        }

        protected override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кол во элементов в строке ступенчатых");
                int length = int.Parse(Console.ReadLine());
                array[i] = new OneDimension(true,length);
                
                
            }   
        }


        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите кол во элементов в строке ступенчатых");
                int length = int.Parse(Console.ReadLine());
                array[i] = new OneDimension(false, length);
                
            }
        }
        public override int Mid()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].Mid();
            }
            Console.WriteLine("Среднее значение ступенчатых");
            return sum / array.Length;
           
        }


        public override void Print()
        {
            Console.WriteLine("весь массив ступенчатых");
            for (int i=0; i < array.Length; i++)
            {
                array[i].Print();
                
            }  
        }
    }
}
