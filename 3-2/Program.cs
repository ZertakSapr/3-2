using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass[] mass = new BaseClass[3];
            Console.WriteLine("Как вы хотите заполянть массив одномерных");
            bool flagone = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во злементов вы хотите в одномерном масииве");
            int count = int.Parse(Console.ReadLine());
            mass[0] = new OneDimension(flagone, count);

            Console.WriteLine("Как вы хотите заполянть массив двумерных");
            bool flagtwo = bool.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во строк вы хотите в двумерном масииве");
            int counttwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Какое кол-во столбцов вы хотите в двумерном масииве");
            int counttwoс = int.Parse(Console.ReadLine());
            mass[1] = new TwoDimensions(flagtwo, counttwo,counttwoс);

            Console.WriteLine("Как вы хотите заполянть массив ступенчатых");
            bool flagst = bool.Parse(Console.ReadLine());
            Console.WriteLine("Каок кол-во строк вы хотите в ступенчатом масииве");
            int countst = int.Parse(Console.ReadLine());
            mass[2] = new StepDimensions(flagst, countst);
            for(int i=0; i<mass.Length; i++)
            {
                mass[i].Print();
                mass[i].Mid();
            }
        }
    }
}
