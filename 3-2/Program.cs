using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ВВедите длину одномерных");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("ВВедите как вы хотите заполнять массив самостоятельно или нет");
            //bool k = bool.Parse(Console.ReadLine());
            //Odnomer od = new Odnomer(k, a);
            //od.Mid();
            //od.Print();
            //Console.WriteLine("ВВедите кол во строк двумерных");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("ВВедите кол во строк двумерных");
            //int b1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("ВВедите как вы хотите заполнять массив самостоятельно или нет");
            //bool k1 = bool.Parse(Console.ReadLine());
            //Dvumer dv = new Dvumer(k1, a1,b1);
            //dv.Mid();
            //dv.Print();
            Console.WriteLine("ВВедите кол во строк ступенчатых");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ВВедите как вы хотите заполнять массив самостоятельно или нет");
            bool k2 = bool.Parse(Console.ReadLine());
            Stupen st = new Stupen(k2, a2);
            st.Mid();
            st.Print();

        }
    }
}
