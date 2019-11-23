using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class MyList<T>
    {
        private T[] items = new T[1];
        /// <summary>
        /// listede eleman yoksa ilk elemana ekler
        /// </summary>
        /// <param name="item">int[] tipinde.</param>
        /// 
        bool firstItem = true;
        public void Add(T item)
        {
            //eğer dizinin ilk elemanın değeri null ise gelen değeri ata
            if (firstItem)
            {
                items[0] = item;
                firstItem = false;
            }
            else
            {
                Array.Resize(ref items, items.Length + 1);
                items[items.Length - 1] = item;

            }
        }
        /// <summary>
        /// listenin eleman sayısını döndürür.
        /// </summary>
        public int Count
        {
            get
            {
                return items.Length;
            }
        }
        //indexer
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set{
                items[index] = value;

        }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> liste = new MyList<int>();
            liste.Add(2);
            liste.Add(5);
            liste.Add(10);
            liste[0] = 123;
            MyList<char> liste2 = new MyList<char>();
            liste2.Add('A');
            liste2.Add('X');
            for (int i = 0; i < liste2.Count; i++)
            {
                Console.WriteLine(liste2[i]);
            }
            Console.WriteLine("Eleman sayısı : {0}",liste.Count);
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine("liste[{0}]={1}",i,liste[i]);
            }
            Console.ReadKey();
        }
    }
}
