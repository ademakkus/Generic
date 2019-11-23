using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithMethodFilter
{
    class Student
    {
        public string Name { get; set; }
    }
    class ClassRoom
    {
        public string Name { get; set; }
    }
    class Test
    {

    }
    abstract class Base
    {


    }
    class Program 
    {

        static void SetName<T>(string value, T obj) where T : Base
        {
           

            obj.Name = value;
        }
        static void Main(string[] args)
        {
            SetName("Ahmet", new Student());
            SetName("9-D", new ClassRoom());
            SetName("3-D", new Test());
            Console.ReadKey();

        }
    }
}
