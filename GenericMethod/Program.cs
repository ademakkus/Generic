using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {


        //static void Swap(ref int s1,ref int s2)
        //{
        //    int temp = s1;
        //    s1 = s2;
        //    s2 = temp;
        //}
        //static void Swap(ref double s1, ref double s2)
        //{
        //    double temp = s1;
        //    s1 = s2;
        //    s2 = temp;
        //}
        static void Swap<T>(ref T s1,ref T s2){
            T temp = s1;
            s1 = s2;
            s2 = temp;

        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            string st1 = "AKKUŞ";
            string st2 = "Adem";
            Swap<int>(ref a, ref b);
            Swap(ref st1,ref st2);
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine("str1={0},str2={1}", st1, st2);
            Console.ReadKey();
        }
    }
}
